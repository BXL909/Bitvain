//!░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
/*
   ░░░░░░  ░░ ░░░░░░░░ ░░    ░░  ░░░░░  ░░ ░░░    ░░ 
   ▒▒   ▒▒ ▒▒    ▒▒    ▒▒    ▒▒ ▒▒   ▒▒ ▒▒ ▒▒▒▒   ▒▒ 
   ▒▒▒▒▒▒  ▒▒    ▒▒    ▒▒    ▒▒ ▒▒▒▒▒▒▒ ▒▒ ▒▒ ▒▒  ▒▒ 
   ▓▓   ▓▓ ▓▓    ▓▓     ▓▓  ▓▓  ▓▓   ▓▓ ▓▓ ▓▓  ▓▓ ▓▓ 
   ██████  ██    ██      ████   ██   ██ ██ ██   ████ */
//?=========== VANITY ADDRESS GENERATOR ============
// 
//!● Homepage.......... https://bitvain.btcdir.org/
//!● Version history... https://bitvain.btcdir.org/version-history/
//!● Download.......... https://bitvain.btcdir.org/download/
//
//TODO LIST______________________________________________________________________________________________
//TODO reset/initialise values to numerics instead of '-'
//TODO test
//TODO installer
//BUG LIST_______________________________________________________________________________________________
//!░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

using System.Net;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections.Concurrent;
using NBitcoin;
using System.Drawing.Drawing2D;

namespace Bitvain
{
    public partial class Bitvain : Form
    {
        #region variable declaration, etc

        long addressesGenerated; // total generated for the query
        private CancellationTokenSource _cancellationTokenSource;
        private int ThreadCount = 8;
        private Stopwatch stopwatch;
        private System.Windows.Forms.Timer updateTimer;
        bool caseSensitiveSearch;
        string targetLocation; // 'prefix' (after prefix), 'anywhere', 'suffix'
        ScriptPubKeyType addressType; // currently selected address type
        int addressPrefixLength; // represents number of characters in prefix of selected address type
        int totalAddressLength; // total address length for the address type
        string exampleAddressWithoutPrefix;
        List<char> disallowedCharacters = [];
        string disallowedCharsErrorMessage;

        #region rounded form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
         );
        #endregion

        #region custom move form button
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]  // needed for the code that moves the form
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")] // needed for the code that moves the form
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        #endregion

        #region initialise
        public Bitvain()
        {
            InitializeComponent();

            #region rounded form
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Padding = new Padding(1);
            #endregion

            #region rounded panels
            Control[] panelsToBeRounded = [panelInputs, panelStatus, panelResults, panelInputStringContainer, panelCaseSensitiveContainer, panelTargetPositionContainer, panelAddressTypeContainer, panelErrorMessage, panel1, panelHelp];
            foreach (Control control in panelsToBeRounded)
            {
                control.Paint += Panel_Paint;
            }
            #endregion

            InitializePerformanceTimer();
        }

        private void InitializePerformanceTimer()
        {
            stopwatch = new Stopwatch();
            updateTimer = new System.Windows.Forms.Timer
            {
                Interval = 1000 // Update every second
            };
            updateTimer.Tick += UpdatePerformanceMetrics;
        }

        private void Bitvain_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            comboBoxAddressType.SelectedIndex = 0; // legacy address type
            comboBoxCaseSensitive.SelectedIndex = 0; // not case sensitive
            comboBoxTargetPosition.SelectedIndex = 0; // after prefix
            lblExampleTarget.Invoke((MethodInvoker)delegate
            {
                lblExampleTarget.Text = string.Empty;
            });

            label11.Text = $"CPU threads ({Environment.ProcessorCount} recommended)";
            lblCPUThreads.Text = Convert.ToString(Environment.ProcessorCount);
            ThreadCount = Environment.ProcessorCount;
            timerRepaintStuff.Start();
        }
        #endregion

        #region input/validate target string & calculate difficulty
        private void TextBoxTargetString_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for non-alphanumerics
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                lblErrorMessage.Text = "Only alphanumeric characters are allowed.";
                panelErrorMessage.Visible = true;
                timerHideErrorMessage.Start();
                e.Handled = true;  // Prevents the character from being entered into the TextBox
            }

            if (disallowedCharacters.Contains(e.KeyChar))
            {
                lblErrorMessage.Text = disallowedCharsErrorMessage;
                panelErrorMessage.Visible = true;
                timerHideErrorMessage.Start();
                e.Handled = true;
            }
        }

        private void TextBoxTargetString_TextChanged(object sender, EventArgs e)
        {
            if (!comboBoxCaseSensitive.Enabled)
            {
                int selectionStart = textBoxTargetString.SelectionStart;
                textBoxTargetString.Text = textBoxTargetString.Text.ToLower();
                textBoxTargetString.SelectionStart = selectionStart;

            }
            RecalculateDifficulty();
            ConstructExample();
        }

        private void ComboBoxTargetPosition_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            RecalculateDifficulty();
            ConstructExample();
        }

        private void ComboBoxCaseSensitive_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            RecalculateDifficulty();
            ConstructExample();
        }

        private void RecalculateDifficulty()
        {
            #region button states
            if (textBoxTargetString.Text.Length > 0)
            {
                btnGenerate.Enabled = true;
                lblDifficultyFormula.Visible = true;
            }
            else
            {
                btnGenerate.Enabled = false;
                lblDifficultyFormula.Visible = false;
                lblDifficulty.Text = "-";
                return;
            }
            #endregion
            int availableCharacters;

            int availableAddressLength = totalAddressLength - addressPrefixLength;

            int stringLength = textBoxTargetString.Text.Length;
            if (comboBoxCaseSensitive.Enabled)
            {
                if (comboBoxCaseSensitive.SelectedIndex == 0)
                {
                    availableCharacters = 32;
                }
                else
                {
                    availableCharacters = 58;
                }
            }
            else
            {
                availableCharacters = 32;
            }

            int attempts = 1;
            if (comboBoxTargetPosition.SelectedIndex == 1)
            {
                attempts = availableAddressLength - (stringLength - 1);
            }

            double difficulty = Math.Pow(availableCharacters, stringLength) / attempts;

            lblDifficulty.Invoke((MethodInvoker)delegate
            {
                lblDifficulty.Text = $"{Math.Truncate(Convert.ToDouble(difficulty))}";
            });

            lblDifficultyFormula.Invoke((MethodInvoker)delegate
            {
                lblDifficultyFormula.Text = $"({availableCharacters}^{stringLength} / {attempts})";
                lblDifficultyFormula.Location = new Point(lblDifficulty.Location.X + lblDifficulty.Width, lblDifficultyFormula.Location.Y);
            });
        }

        private void ConstructExample()
        {
            //empty target string
            if (textBoxTargetString.Text.Length == 0)
            {
                lblExampleTarget.Invoke((MethodInvoker)delegate
                {
                    lblExampleTarget.Text = string.Empty;
                });
                lblExampleAddressPart1.Invoke((MethodInvoker)delegate
                {
                    lblExampleAddressPart1.Text = exampleAddressWithoutPrefix;
                    lblExampleAddressPart1.Location = new Point(lblExamplePrefix.Location.X + lblExamplePrefix.Width - 4, lblExampleAddressPart1.Location.Y);
                });
                return;
            }

            lblExampleTarget.Invoke((MethodInvoker)delegate
            {
                lblExampleTarget.Text = textBoxTargetString.Text;
            });

            //prefix
            if (comboBoxTargetPosition.SelectedIndex == 0)
            {
                lblExampleAddressPart2.Visible = false;

                lblExampleTarget.Invoke((MethodInvoker)delegate
                {
                    lblExampleTarget.Location = new Point(lblExamplePrefix.Location.X + lblExamplePrefix.Width - 4, lblExampleTarget.Location.Y);
                });

                lblExampleAddressPart1.Invoke((MethodInvoker)delegate
                {
                    lblExampleAddressPart1.Text = exampleAddressWithoutPrefix;
                    lblExampleAddressPart1.Text = lblExampleAddressPart1.Text[textBoxTargetString.Text.Length..];
                    lblExampleAddressPart1.Location = new Point(lblExampleTarget.Location.X + lblExampleTarget.Width - 4, lblExampleAddressPart1.Location.Y);
                });
            }

            //suffix
            if (comboBoxTargetPosition.SelectedIndex == 2)
            {
                lblExampleAddressPart2.Visible = false;

                lblExampleAddressPart1.Invoke((MethodInvoker)delegate
                {
                    lblExampleAddressPart1.Text = exampleAddressWithoutPrefix;
                    lblExampleAddressPart1.Text = lblExampleAddressPart1.Text[..^textBoxTargetString.Text.Length];
                    lblExampleAddressPart1.Location = new Point(lblExamplePrefix.Location.X + lblExamplePrefix.Width - 4, lblExampleAddressPart1.Location.Y);
                });

                lblExampleTarget.Invoke((MethodInvoker)delegate
                {
                    lblExampleTarget.Location = new Point(lblExampleAddressPart1.Location.X + lblExampleAddressPart1.Width - 4, lblExampleTarget.Location.Y);
                });
            }

            //anywhere
            if (comboBoxTargetPosition.SelectedIndex == 1)
            {
                lblExampleAddressPart2.Visible = true;

                Random random = new();
                int randomNumber = random.Next(1, exampleAddressWithoutPrefix.Length - textBoxTargetString.Text.Length - 1);

                lblExampleAddressPart1.Text = exampleAddressWithoutPrefix[..randomNumber];
                lblExampleAddressPart2.Text = exampleAddressWithoutPrefix[(randomNumber + textBoxTargetString.Text.Length)..];
                lblExampleAddressPart1.Location = new Point(lblExamplePrefix.Location.X + lblExamplePrefix.Width - 4, lblExampleAddressPart1.Location.Y);
                lblExampleTarget.Location = new Point(lblExampleAddressPart1.Location.X + lblExampleAddressPart1.Width - 4, lblExampleTarget.Location.Y);
                lblExampleAddressPart2.Location = new Point(lblExampleTarget.Location.X + lblExampleTarget.Width - 4, lblExampleAddressPart2.Location.Y);
            }
        }
        #endregion

        #region generate and compare addresses
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            ClearPreviousResults();

            if (comboBoxCaseSensitive.SelectedIndex == 0)
            {
                caseSensitiveSearch = false;
            }
            else
            {
                caseSensitiveSearch = true;
            }

            if (comboBoxTargetPosition.SelectedIndex == 0)
            {
                targetLocation = "prefix";
            }
            else
            {
                if (comboBoxTargetPosition.SelectedIndex == 1)
                {
                    targetLocation = "anywhere";
                }
                else
                {
                    targetLocation = "suffix";
                }
            }

            _cancellationTokenSource?.Cancel();
            _cancellationTokenSource = new CancellationTokenSource();

            string pattern = textBoxTargetString.Text;

            DisableParams();

            stopwatch.Restart();
            updateTimer.Start();

            Task.Run(() => RunParallelVanityAddressGeneration(pattern, _cancellationTokenSource.Token));
        }

        private void DisableParams()
        {
            this.Invoke((MethodInvoker)delegate
            {
                textBoxTargetString.Enabled = false;
                comboBoxCaseSensitive.Enabled = false;
                comboBoxTargetPosition.Enabled = false;
                btnCPUThreadsLess.Enabled = false;
                btnCPUThreadsMore.Enabled = false;
                btnGenerate.Enabled = false;
                comboBoxAddressType.Enabled = false;
            });
        }

        private void EnableParams()
        {
            this.Invoke((MethodInvoker)delegate
            {
                textBoxTargetString.Enabled = true;
                if (comboBoxAddressType.SelectedIndex != 2 && comboBoxAddressType.SelectedIndex != 3)
                {
                    comboBoxCaseSensitive.Enabled = true;
                }
                comboBoxTargetPosition.Enabled = true;
                btnCPUThreadsLess.Enabled = true;
                btnCPUThreadsMore.Enabled = true;
                btnGenerate.Enabled = true;
                comboBoxAddressType.Enabled = true;
            });
        }

        private void ClearPreviousResults()
        {
            lblGeneratedAddress.Invoke((MethodInvoker)delegate
            {
                lblGeneratedAddress.Text = string.Empty;
            });
            lblGeneratedPrivateKey.Invoke((MethodInvoker)delegate
            {
                lblGeneratedPrivateKey.Text = string.Empty;
            });
            lblAddressesPerSecond.Text = "-";

            addressesGenerated = 0;

            btnCancel.Enabled = true;

            btnCopyAddress.Visible = false;
            btnCopyPrivateKey.Visible = false;
            lblCompleted.Visible = false;
            timerCompletedMessage.Stop();
        }

        private void RunParallelVanityAddressGeneration(string pattern, CancellationToken token)
        {
            // Using ConcurrentBag to safely share data across tasks
            ConcurrentBag<string> result = [];

            // Create and start multiple tasks
            Task[] tasks = new Task[ThreadCount];
            for (int i = 0; i < ThreadCount; i++)
            {
                if (targetLocation == "prefix")
                {
                    tasks[i] = Task.Run(() => GenerateVanityAddressPrefix(pattern, result, token));
                }
                if (targetLocation == "anywhere") //anywhere in address
                {
                    tasks[i] = Task.Run(() => GenerateVanityAddressAnywhere(pattern, result, token));
                }
                if (targetLocation == "suffix")
                {
                    tasks[i] = Task.Run(() => GenerateVanityAddressSuffix(pattern, result, token));
                }
            }

            // Wait for any task to complete
            Task.WaitAny(tasks);

            // Cancel remaining tasks
            _cancellationTokenSource.Cancel();
            stopwatch.Stop();
            updateTimer.Stop();

            // Display the result
            if (result.TryTake(out var foundAddress))
            {
                this.Invoke((MethodInvoker)delegate
                {
                    btnCancel.Enabled = false;
                    lblGeneratedAddress.Text = foundAddress.Split('|')[0];
                    lblGeneratedPrivateKey.Text = foundAddress.Split('|')[1];
                    btnCopyAddress.Location = new Point(lblGeneratedAddress.Location.X + lblGeneratedAddress.Width, btnCopyAddress.Location.Y);
                    btnCopyAddress.Visible = true;
                    btnCopyPrivateKey.Location = new Point(lblGeneratedPrivateKey.Location.X + lblGeneratedPrivateKey.Width, btnCopyPrivateKey.Location.Y);
                    btnCopyPrivateKey.Visible = true;
                    timerCompletedMessage.Start();
                });
                EnableParams();
            }
        }



        private void GenerateVanityAddressPrefix(string pattern, ConcurrentBag<string> result, CancellationToken token)
        {
            ReadOnlySpan<char> searchPattern = pattern.AsSpan(); // Using Span for pattern search
            bool isCaseSensitive = caseSensitiveSearch;

            while (!token.IsCancellationRequested)
            {
                Key privateKey = new Key();
                BitcoinSecret bitcoinSecret = privateKey.GetBitcoinSecret(Network.Main);
                string address = bitcoinSecret.GetAddress(addressType).ToString();

                // Efficiently slice the part of the address where the prefix should appear
                ReadOnlySpan<char> addressSpan = address.AsSpan(addressPrefixLength);

                Interlocked.Increment(ref addressesGenerated);
                if (addressesGenerated % 100 == 0)
                {
                    UpdateAddressesGeneratedUI();
                }

                // Perform a case-insensitive or case-sensitive match as needed
                if (addressSpan.StartsWith(searchPattern, isCaseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase))
                {
                    result.Add($"{address}|{bitcoinSecret}");
                    return;  // Exit once a match is found
                }
            }
        }


        private void GenerateVanityAddressAnywhere(string pattern, ConcurrentBag<string> result, CancellationToken token)
        {
            ReadOnlySpan<char> searchPattern = pattern.AsSpan();  // Use Span for efficient memory usage
            bool isCaseSensitive = caseSensitiveSearch;

            while (!token.IsCancellationRequested)
            {
                Key privateKey = new();
                BitcoinSecret bitcoinSecret = privateKey.GetBitcoinSecret(Network.Main);
                string address = bitcoinSecret.GetAddress(addressType).ToString();
                ReadOnlySpan<char> addressSpan = address.AsSpan();

                Interlocked.Increment(ref addressesGenerated);
                if (addressesGenerated % 100 == 0)
                {
                    UpdateAddressesGeneratedUI();
                }

                // Perform pattern matching depending on case sensitivity
                StringComparison comparison = isCaseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;

                if (address.Contains(pattern, comparison)) // Efficiently match based on case sensitivity
                {
                    result.Add($"{address}|{bitcoinSecret}");
                    return; // Exit once a match is found
                }
            }
        }


/*
        private void GenerateVanityAddressAnywhere(string pattern, ConcurrentBag<string> result, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                Key privateKey = new();
                BitcoinSecret bitcoinSecret = privateKey.GetBitcoinSecret(Network.Main);
                string address = bitcoinSecret.GetAddress(addressType).ToString();

                Interlocked.Increment(ref addressesGenerated);
                if (addressesGenerated % 100 == 0)
                {
                    UpdateAddressesGeneratedUI();
                }

                if (address.Contains(pattern, StringComparison.OrdinalIgnoreCase)) // found a match regardless of case settings
                {
                    if (!caseSensitiveSearch) // if not a case sensitive search
                    {
                        result.Add($"{address}|{bitcoinSecret}"); // return this result
                        return;
                    }
                    else // if it is a case sensitive search
                    {
                        if (address.Contains(pattern)) // if this match was case sensitive
                        {
                            result.Add($"{address}|{bitcoinSecret}"); // return this result
                            return;
                        }
                    }
                }
            }
        }
*/

        private void GenerateVanityAddressSuffix(string pattern, ConcurrentBag<string> result, CancellationToken token)
        {
            ReadOnlySpan<char> searchPattern = pattern.AsSpan();  // Use Span for efficient memory usage
            bool isCaseSensitive = caseSensitiveSearch;

            while (!token.IsCancellationRequested)
            {
                Key privateKey = new();
                BitcoinSecret bitcoinSecret = privateKey.GetBitcoinSecret(Network.Main);
                string address = bitcoinSecret.GetAddress(addressType).ToString();
                ReadOnlySpan<char> addressSpan = address.AsSpan();

                Interlocked.Increment(ref addressesGenerated);
                if (addressesGenerated % 100 == 0)
                {
                    UpdateAddressesGeneratedUI();
                }

                // Perform the check for suffix match (either case-sensitive or case-insensitive)
                if (addressSpan.EndsWith(searchPattern, isCaseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase))
                {
                    result.Add($"{address}|{bitcoinSecret}");
                    return; // Exit the loop once a match is found
                }
            }
        }

        /*
        private void GenerateVanityAddressSuffix(string pattern, ConcurrentBag<string> result, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                Key privateKey = new();
                BitcoinSecret bitcoinSecret = privateKey.GetBitcoinSecret(Network.Main);
                string address = bitcoinSecret.GetAddress(addressType).ToString();

                Interlocked.Increment(ref addressesGenerated);
                if (addressesGenerated % 100 == 0)
                {
                    UpdateAddressesGeneratedUI();
                }

                if (address.EndsWith(pattern, StringComparison.OrdinalIgnoreCase)) // found a match regardless of case settings
                {
                    if (!caseSensitiveSearch) // if not a case sensitive search
                    {
                        result.Add($"{address}|{bitcoinSecret}"); // return this result
                        return;
                    }
                    else // if it is a case sensitive search
                    {
                        if (address.Contains(pattern)) // if this match was case sensitive
                        {
                            result.Add($"{address}|{bitcoinSecret}"); // return this result
                            return;
                        }
                    }
                }
            }
        }
        */
        private void UpdateAddressesGeneratedUI()
        {
            lblAddressesGenerated.Invoke((MethodInvoker)delegate
            {
                lblAddressesGenerated.Text = addressesGenerated.ToString();
            });
        }

        private void UpdatePerformanceMetrics(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                //addresses per second
                double addressesPerSecond = addressesGenerated / stopwatch.Elapsed.TotalSeconds;
                lblAddressesPerSecond.Invoke((MethodInvoker)delegate
                {
                    lblAddressesPerSecond.Text = $"{addressesPerSecond:F2}";
                });

                //elapsed time
                TimeSpan elapsedTime = stopwatch.Elapsed;
                string formattedElapsedTime = $"{elapsedTime.Days}d, {elapsedTime.Hours}h, {elapsedTime.Minutes}m, {elapsedTime.Seconds}s";
                lblTimeElapsed.Invoke((MethodInvoker)delegate
                {
                    lblTimeElapsed.Text = formattedElapsedTime;
                });
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
            stopwatch.Stop();
            updateTimer.Stop();
            EnableParams();
            btnCancel.Enabled = false;
        }
        #endregion

        #region common stuff

        private void Bitvain_Paint(object sender, PaintEventArgs e)
        {
            using var pen = new Pen(Color.DimGray, 1);
            var rect = ClientRectangle;
            rect.Inflate(-1, -1);
            e.Graphics.DrawPath(pen, GetRoundedRect(rect, 30));
        }

        private static GraphicsPath GetRoundedRect(Rectangle rectangle, int radius)
        {
            GraphicsPath path = new();
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        #region error handler
        private void HandleException(Exception ex, string methodName)
        {
            string errorMessage;
            errorMessage = $"Error in {methodName}: {ex.Message}";

            const int MaxErrorMessageLength = 130;

            if (errorMessage.Length > MaxErrorMessageLength)
            {
                errorMessage = $"{errorMessage[..MaxErrorMessageLength]}...";
            }

            lblErrorMessage.Invoke((MethodInvoker)delegate
            {
                lblErrorMessage.Text = errorMessage;
                panelErrorMessage.Visible = true;
            });
        }

        private void TimerHideErrorMessage_Tick(object sender, EventArgs e)
        {
            timerHideErrorMessage.Stop();
            panelErrorMessage.Visible = false;
        }
        #endregion

        private void Panel_Paint(object? sender, PaintEventArgs e)
        {
            try
            {
                if (sender == null)
                {
                    return;
                }
                Panel panel = (Panel)sender;

                System.Drawing.Drawing2D.GraphicsPath path = new();
                int cornerRadius = 20;
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                panel.Region = new Region(path);
            }
            catch (Exception ex)
            {
                HandleException(ex, "Panel_Paint");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region move window
        private void BtnMoveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch (WebException ex)
            {
                HandleException(ex, "BtnMoveWindow_MouseDown");
            }
        }

        private void BtnMoveWindow_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                var args = e as MouseEventArgs;
                if (args.Button == MouseButtons.Right)
                {
                    return;
                }
                btnExit.Focus();
            }
            catch (WebException ex)
            {
                HandleException(ex, "BtnMoveWindow_MouseUp");
            }
        }

        private void BtnMoveWindow_Click(object sender, EventArgs e)
        {
            try
            {
                var args = e as MouseEventArgs;
                if (args!.Button == MouseButtons.Right)
                {
                    return;
                }
            }
            catch (WebException ex)
            {
                HandleException(ex, "BtnMoveWindow_Click");
            }
        }

        #endregion
        #endregion

        private void BtnCPUThreadsLess_Click(object sender, EventArgs e)
        {
            if (ThreadCount > 1)
            {
                ThreadCount--;
                lblCPUThreads.Invoke((MethodInvoker)delegate
                {
                    lblCPUThreads.Text = ThreadCount.ToString("D2");
                });
            }
            if (ThreadCount < 2)
            {
                btnCPUThreadsLess.Enabled = false;
            }
            else
            {
                btnCPUThreadsLess.Enabled = true;
            }
            btnCPUThreadsMore.Enabled = true;
        }

        private void BtnCPUThreadsMore_Click(object sender, EventArgs e)
        {
            if (ThreadCount < 64)
            {
                ThreadCount++;
                lblCPUThreads.Invoke((MethodInvoker)delegate
                {
                    lblCPUThreads.Text = ThreadCount.ToString("D2");
                });
            }
            if (ThreadCount >= 64)
            {
                btnCPUThreadsMore.Enabled = false;
            }
            else
            {
                btnCPUThreadsMore.Enabled = true;
            }
            btnCPUThreadsLess.Enabled = true;
        }

        private void ComboBoxAddressType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAddressType.SelectedIndex == 0) // legacy P2PKH (1 prefix) base58
            {
                comboBoxCaseSensitive.Enabled = true;
                lblExamplePrefix.Invoke((MethodInvoker)delegate
                {
                    lblExamplePrefix.Text = "1";
                });
                addressType = ScriptPubKeyType.Legacy;
                addressPrefixLength = 1;
                totalAddressLength = 34;
                exampleAddressWithoutPrefix = "BvBMSEYstWetqTFn5Au4m4GFg7xJaNVN2";
                disallowedCharacters = ['0', 'O', 'I', 'l'];
                disallowedCharsErrorMessage = "Legacy: O (upper o), 0 (zero), I (upper i) && l (lower L) are invalid characters";
            }

            if (comboBoxAddressType.SelectedIndex == 1) // segwitP2SH (3 prefix) base58
            {
                comboBoxCaseSensitive.Enabled = true;
                lblExamplePrefix.Invoke((MethodInvoker)delegate
                {
                    lblExamplePrefix.Text = "3";
                });
                addressType = ScriptPubKeyType.SegwitP2SH;
                addressPrefixLength = 1;
                totalAddressLength = 34;
                exampleAddressWithoutPrefix = "BpNv8kWhGqjiKysyaADpsdrFABNqZhdCE";
                disallowedCharacters = ['0', 'O', 'I', 'l'];
                disallowedCharsErrorMessage = "SegwitP2SH: O (upper o), 0 (zero), I (upper i) && l (lower L) are invalid characters";
            }

            if (comboBoxAddressType.SelectedIndex == 2) // segwit (bc1q prefix) bech32
            {
                comboBoxCaseSensitive.SelectedIndex = 0;
                comboBoxCaseSensitive.Enabled = false;
                textBoxTargetString.Text = textBoxTargetString.Text.ToLower();
                lblExamplePrefix.Invoke((MethodInvoker)delegate
                {
                    lblExamplePrefix.Text = "bc1q";
                });
                addressType = ScriptPubKeyType.Segwit;
                addressPrefixLength = 4;
                totalAddressLength = 42;
                exampleAddressWithoutPrefix = "ar0srrr7xfkvy5l643lydnw9re59gtzzwf5mdq";
                disallowedCharacters = ['b', 'i', 'o', 'l', 'O', 'B', 'I', 'L']; // nb the caps get translated to lower-case so they need disallowing too
                disallowedCharsErrorMessage = "Segwit: b, i, o (lower O) && l (lower L) are invalid characters";
            }

            if (comboBoxAddressType.SelectedIndex == 3) // taproot (bc1p prefix) bech32
            {
                comboBoxCaseSensitive.SelectedIndex = 0;
                comboBoxCaseSensitive.Enabled = false;
                textBoxTargetString.Text = textBoxTargetString.Text.ToLower();
                lblExamplePrefix.Invoke((MethodInvoker)delegate
                {
                    lblExamplePrefix.Text = "bc1p";
                });
                addressType = ScriptPubKeyType.TaprootBIP86;
                addressPrefixLength = 4;
                totalAddressLength = 62;
                exampleAddressWithoutPrefix = "0xlxvlhemja6c4dqv22uapctqupfhlxm9h8z3k2e72q4k9hcz7vqzk5jj0";
                disallowedCharacters = ['b', 'i', 'o', 'l', 'O', 'B', 'I', 'L']; // nb the caps get translated to lower-case so they need disallowing too
                disallowedCharsErrorMessage = "Taproot: b, i, o (lower O) && l (lower L) are invalid characters";
            }

            RecalculateDifficulty();
            ConstructExample();
        }

        private void BtnCopyAddress_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblGeneratedAddress.Text);
            lblCopied.Location = new Point(btnCopyAddress.Location.X + btnCopyAddress.Width, label7.Location.Y);
            lblCopied.Visible = true;
            timerHideCopiedMessage.Start();
        }

        private void BtnCopyPrivateKey_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblGeneratedPrivateKey.Text);
            lblCopied.Location = new Point(btnCopyPrivateKey.Location.X + btnCopyPrivateKey.Width, label8.Location.Y);
            lblCopied.Visible = true;
            timerHideCopiedMessage.Start();
        }

        private void TimerHideCopiedMessage_Tick(object sender, EventArgs e)
        {
            timerHideCopiedMessage.Stop();
            lblCopied.Visible = false;
        }

        private void Copy_MouseUp(object sender, MouseEventArgs e)
        {
            btnMoveWindow.Focus();
        }

        private void TimerCompletedMessage_Tick(object sender, EventArgs e)
        {
            if (lblCompleted.Visible)
            {
                lblCompleted.Visible = false;
            }
            else
            {
                lblCompleted.Visible = true;

                panelInputStringContainer.Invoke((MethodInvoker)delegate
                {
                    panelInputStringContainer.BackColor = Color.FromArgb(24, 27, 36);
                    panelInputStringContainer.Invalidate();
                });
            }
        }

        private void TimerRepaintStuff_Tick(object sender, EventArgs e) // hacky way to overcome a couple of see-through panels.
        {
            panelInputStringContainer.Invoke((MethodInvoker)delegate
            {
                panelInputStringContainer.BackColor = Color.FromArgb(24, 27, 36);
                panelInputStringContainer.Invalidate();
            });
            panelCaseSensitiveContainer.Invoke((MethodInvoker)delegate
            {
                panelCaseSensitiveContainer.BackColor = Color.FromArgb(24, 27, 36);
                panelCaseSensitiveContainer.Invalidate();
            });
            panelTargetPositionContainer.Invoke((MethodInvoker)delegate
            {
                panelTargetPositionContainer.BackColor = Color.FromArgb(24, 27, 36);
                panelTargetPositionContainer.Invalidate();
            });
            panelAddressTypeContainer.Invoke((MethodInvoker)delegate
            {
                panelAddressTypeContainer.BackColor = Color.FromArgb(24, 27, 36);
                panelAddressTypeContainer.Invalidate();
            });
            timerRepaintStuff.Stop();
        }

        private void BtnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            try
            {
                // display semi-transparent overlay form
                Form overlay = new Overlay()
                {
                    Owner = this,
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.None,
                    BackColor = Color.Black,
                    Opacity = 0.5,
                };
                overlay.StartPosition = FormStartPosition.CenterParent;
                // Calculate the overlay form's location to place it in the center of the parent form
                overlay.StartPosition = FormStartPosition.Manual;
                int parentCenterX = this.Location.X + this.Width / 2;
                int parentCenterY = this.Location.Y + this.Height / 2;
                int overlayX = parentCenterX - overlay.Width / 2;
                int overlayY = parentCenterY - overlay.Height / 2;
                overlay.Location = new Point(overlayX, overlayY);
                overlay.Show(this);

                // display about screen on top of the overlay
                Form frm = new About()
                {
                    Owner = this,
                    StartPosition = FormStartPosition.CenterParent,
                };
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(this);

                overlay.Close();
                this.Focus();
                this.BringToFront();
            }
            catch (Exception ex)
            {
                HandleException(ex, "BtnAbout_Click");
            }
        }

        private void BtnCloseInfo_Click(object sender, EventArgs e)
        {
            panelHelp.Invoke((MethodInvoker)delegate
            {
                panelHelp.Visible = false;
                panelHelp.SendToBack();
                timerRepaintStuff.Start();
            });
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            panelHelp.Invoke((MethodInvoker)delegate
            {
                panelHelp.BringToFront();
                panelHelp.Visible = true;
            });
        }
    }
}
