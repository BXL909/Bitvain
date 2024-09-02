//?░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
/*
░░░░░░  ░░ ░░░░░░░░ ░░    ░░  ░░░░░  ░░ ░░░    ░░ 
▒▒   ▒▒ ▒▒    ▒▒    ▒▒    ▒▒ ▒▒   ▒▒ ▒▒ ▒▒▒▒   ▒▒ 
▒▒▒▒▒▒  ▒▒    ▒▒    ▒▒    ▒▒ ▒▒▒▒▒▒▒ ▒▒ ▒▒ ▒▒  ▒▒ 
▓▓   ▓▓ ▓▓    ▓▓     ▓▓  ▓▓  ▓▓   ▓▓ ▓▓ ▓▓  ▓▓ ▓▓ 
██████  ██    ██      ████   ██   ██ ██ ██   ████ 
=========== VANITY ADDRESS GENERATOR ============
 */
//!● Homepage.......... https://bitvain.btcdir.org/
//!● Version history... https://bitvain.btcdir.org/version-history/
//!● Download.......... https://bitvain.btcdir.org/download/
//
//TODO LIST______________________________________________________________________________________________
//BUG LIST_______________________________________________________________________________________________
//?░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

using System.Net;
using System.Runtime.InteropServices;

namespace Bitvain
{
    public partial class Bitvain : Form
    {
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
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]  // needed for the code that moves the form as not using a standard control
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")] // needed for the code that moves the form as not using a standard control
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        public Bitvain()
        {
            InitializeComponent();

            #region rounded form
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            // Add a 1-pixel border around the form
            Padding = new Padding(1);
            #endregion

            #region rounded panels
            Control[] panelsToBeRounded = { panelInputs, panelStatus, panelResults, panelInputStringContainer, panelCaseSensitiveContainer, panelTargetPositionContainer };
            foreach (Control control in panelsToBeRounded)
            {
                control.Paint += Panel_Paint;
            }
            #endregion
        }

        private void Bitvain_Load(object sender, EventArgs e)
        {
            comboBoxCaseSensitive.SelectedIndex = 0;
            comboBoxTargetPosition.SelectedIndex = 0;
            lblExampleTarget.Invoke((MethodInvoker)delegate
            {
                lblExampleTarget.Text = string.Empty;
            });
        }

        #region error handler
        private void HandleException(Exception ex, string methodName)
        {
            string errorMessage;
            errorMessage = $"Error in {methodName}: {ex.Message}";

            const int MaxErrorMessageLength = 130;

            if (errorMessage.Length > MaxErrorMessageLength)
            {
                errorMessage = $"{errorMessage.Substring(0, MaxErrorMessageLength)}...";
            }

            lblErrorMessage.Invoke((MethodInvoker)delegate
            {
                lblErrorMessage.Text = errorMessage;
            });
        }
        #endregion

        #region input/validate target string & calculate difficulty
        private void textBoxTargetString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'O' || e.KeyChar == 'I' || e.KeyChar == 'l')
            {
                lblTargetStringInputError.Visible = true;
                timerTargetStringMessage.Start();
                e.Handled = true;
            }
        }

        private void timerTargetStringMessage_Tick(object sender, EventArgs e)
        {
            timerTargetStringMessage.Stop();
            lblTargetStringInputError.Visible = false;
        }

        private void textBoxTargetString_TextChanged(object sender, EventArgs e)
        {

            RecalculateDifficulty();
            ConstructExample();
        }

        private void comboBoxTargetPosition_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            RecalculateDifficulty();
            ConstructExample();
        }

        private void comboBoxCaseSensitive_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            RecalculateDifficulty();
            ConstructExample();
        }

        private void RecalculateDifficulty()
        {
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

            int availableCharacters;
            int totalAddressLength = 34; //Legacy addresses(P2PKH)
            int prefixLength = 1; //Legacy addresses(P2PKH)
            int availableAddressLength = totalAddressLength - prefixLength;
            
            int stringLength = textBoxTargetString.Text.Length;
            if (comboBoxCaseSensitive.SelectedIndex == 0)
            {
                availableCharacters = 33;
            }
            else
            {
                availableCharacters = 59;
            }

            int attempts = 1;
            if (comboBoxTargetPosition.SelectedIndex == 1)
            {
                attempts = availableAddressLength - (stringLength - 1);
            }

            double difficulty = Math.Pow(availableCharacters, stringLength) / attempts ;

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
                    lblExampleAddressPart1.Text = "Gxp4vRoCGJym3xR7yCVPFHoCNxv4Twseo";
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
                    lblExampleAddressPart1.Text = "Gxp4vRoCGJym3xR7yCVPFHoCNxv4Twseo";
                    lblExampleAddressPart1.Text = lblExampleAddressPart1.Text.Substring(textBoxTargetString.Text.Length);
                    lblExampleAddressPart1.Location = new Point(lblExampleTarget.Location.X + lblExampleTarget.Width - 4, lblExampleAddressPart1.Location.Y);
                });
            }

            //suffix
            if (comboBoxTargetPosition.SelectedIndex == 2)
            {
                lblExampleAddressPart2.Visible = false;

                lblExampleAddressPart1.Invoke((MethodInvoker)delegate
                {
                    lblExampleAddressPart1.Text = "Gxp4vRoCGJym3xR7yCVPFHoCNxv4Twseo";
                    lblExampleAddressPart1.Text = lblExampleAddressPart1.Text.Substring(0, lblExampleAddressPart1.Text.Length - textBoxTargetString.Text.Length);
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

                string fullAddress = "Gxp4vRoCGJym3xR7yCVPFHoCNxv4Twseo";
                
                Random random = new Random();
                int randomNumber = random.Next(1, fullAddress.Length - textBoxTargetString.Text.Length - 1);

                lblExampleAddressPart1.Text = fullAddress.Substring(0, randomNumber);
                lblExampleAddressPart2.Text = fullAddress.Substring(randomNumber + textBoxTargetString.Text.Length);
                lblErrorMessage.Text = Convert.ToString(randomNumber);
                lblExampleAddressPart1.Location = new Point(lblExamplePrefix.Location.X + lblExamplePrefix.Width - 4, lblExampleAddressPart1.Location.Y);
                lblExampleTarget.Location = new Point(lblExampleAddressPart1.Location.X + lblExampleAddressPart1.Width - 4, lblExampleTarget.Location.Y);
                lblExampleAddressPart2.Location = new Point(lblExampleTarget.Location.X + lblExampleTarget.Width - 4, lblExampleAddressPart2.Location.Y);
            }


        }
        #endregion

        #region generic controls
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region move window
        private void BtnMoveWindow_MouseDown(object sender, MouseEventArgs e) // move the form when the move control is used
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

        private void BtnMoveWindow_MouseUp(object sender, MouseEventArgs e) // reset colour of the move form control
        {
            try
            {
                var args = e as MouseEventArgs;
                if (args.Button == MouseButtons.Right)
                {
                    return;
                }
                btnMoveWindow.BackColor = System.Drawing.ColorTranslator.FromHtml("#1D1D1D");
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

        private void Panel_Paint(object? sender, PaintEventArgs e)
        {
            try
            {
                if (sender == null)
                {
                    return;
                }
                Panel panel = (Panel)sender;

                // Create a GraphicsPath object with rounded corners
                System.Drawing.Drawing2D.GraphicsPath path = new();
                int cornerRadius = 20;
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Set the panel's region to the rounded path
                panel.Region = new Region(path);
            }
            catch (Exception ex)
            {
                HandleException(ex, "Panel_Paint");
            }
        }


    }
}
