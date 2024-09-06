using Bitvain.Properties;

namespace Bitvain
{
    partial class Bitvain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitvain));
            pictureBox1 = new PictureBox();
            btnExit = new CustomControls.RJControls.RJButton();
            panelInputs = new Panel();
            panel1 = new Panel();
            comboBoxAddressType = new CustomControls.RJControls.RJComboBox();
            label12 = new Label();
            btnCPUThreadsMore = new CustomControls.RJControls.RJButton();
            btnCPUThreadsLess = new CustomControls.RJControls.RJButton();
            lblCPUThreads = new Label();
            label11 = new Label();
            lblExampleAddressPart2 = new Label();
            lblExampleTarget = new Label();
            lblExampleAddressPart1 = new Label();
            panelTargetPositionContainer = new Panel();
            comboBoxTargetPosition = new CustomControls.RJControls.RJComboBox();
            label5 = new Label();
            lblExamplePrefix = new Label();
            label4 = new Label();
            lblDifficultyFormula = new Label();
            label3 = new Label();
            panelCaseSensitiveContainer = new Panel();
            comboBoxCaseSensitive = new CustomControls.RJControls.RJComboBox();
            lblDifficulty = new Label();
            label2 = new Label();
            label1 = new Label();
            panelInputStringContainer = new Panel();
            textBoxTargetString = new TextBox();
            btnGenerate = new CustomControls.RJControls.RJButton();
            panelResults = new Panel();
            lblCopied = new Label();
            btnCopyPrivateKey = new CustomControls.RJControls.RJButton();
            btnCopyAddress = new CustomControls.RJControls.RJButton();
            lblGeneratedPrivateKey = new Label();
            lblGeneratedAddress = new Label();
            label8 = new Label();
            label7 = new Label();
            panelStatus = new Panel();
            lblTimeElapsed = new Label();
            label10 = new Label();
            label9 = new Label();
            lblAddressesPerSecond = new Label();
            btnCancel = new CustomControls.RJControls.RJButton();
            lblAddressesGenerated = new Label();
            label6 = new Label();
            timerHideErrorMessage = new System.Windows.Forms.Timer(components);
            btnMoveWindow = new CustomControls.RJControls.RJButton();
            lblErrorMessage = new Label();
            timerHideCopiedMessage = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelInputs.SuspendLayout();
            panel1.SuspendLayout();
            panelTargetPositionContainer.SuspendLayout();
            panelCaseSensitiveContainer.SuspendLayout();
            panelInputStringContainer.SuspendLayout();
            panelResults.SuspendLayout();
            panelStatus.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(19, 22, 31);
            pictureBox1.BackgroundImage = Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 102);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += BtnMoveWindow_Click;
            pictureBox1.MouseDown += BtnMoveWindow_MouseDown;
            pictureBox1.MouseUp += BtnMoveWindow_MouseUp;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(62, 72, 91);
            btnExit.BackgroundColor = Color.FromArgb(62, 72, 91);
            btnExit.BorderColor = Color.PaleVioletRed;
            btnExit.BorderRadius = 12;
            btnExit.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(623, 10);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(2, 2, 0, 0);
            btnExit.Size = new Size(24, 24);
            btnExit.TabIndex = 2;
            btnExit.Text = "X";
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += BtnExit_Click;
            // 
            // panelInputs
            // 
            panelInputs.BackColor = Color.FromArgb(13, 16, 24);
            panelInputs.Controls.Add(panel1);
            panelInputs.Controls.Add(label12);
            panelInputs.Controls.Add(btnCPUThreadsMore);
            panelInputs.Controls.Add(btnCPUThreadsLess);
            panelInputs.Controls.Add(lblCPUThreads);
            panelInputs.Controls.Add(label11);
            panelInputs.Controls.Add(lblExampleAddressPart2);
            panelInputs.Controls.Add(lblExampleTarget);
            panelInputs.Controls.Add(lblExampleAddressPart1);
            panelInputs.Controls.Add(panelTargetPositionContainer);
            panelInputs.Controls.Add(label5);
            panelInputs.Controls.Add(lblExamplePrefix);
            panelInputs.Controls.Add(label4);
            panelInputs.Controls.Add(lblDifficultyFormula);
            panelInputs.Controls.Add(label3);
            panelInputs.Controls.Add(panelCaseSensitiveContainer);
            panelInputs.Controls.Add(lblDifficulty);
            panelInputs.Controls.Add(label2);
            panelInputs.Controls.Add(label1);
            panelInputs.Controls.Add(panelInputStringContainer);
            panelInputs.Controls.Add(btnGenerate);
            panelInputs.Location = new Point(12, 110);
            panelInputs.Name = "panelInputs";
            panelInputs.Size = new Size(632, 148);
            panelInputs.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 27, 36);
            panel1.Controls.Add(comboBoxAddressType);
            panel1.Location = new Point(113, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 24);
            panel1.TabIndex = 23;
            // 
            // comboBoxAddressType
            // 
            comboBoxAddressType.BackColor = Color.FromArgb(24, 27, 36);
            comboBoxAddressType.BorderColor = Color.MediumSlateBlue;
            comboBoxAddressType.BorderSize = 0;
            comboBoxAddressType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAddressType.Font = new Font("Segoe UI", 10F);
            comboBoxAddressType.ForeColor = Color.LightGray;
            comboBoxAddressType.IconColor = Color.White;
            comboBoxAddressType.Items.AddRange(new object[] { "Legacy P2PKH (prefix 1)", "SegwitP2SH (prefix 3)" });
            comboBoxAddressType.ListBackColor = Color.FromArgb(24, 27, 36);
            comboBoxAddressType.ListTextColor = Color.White;
            comboBoxAddressType.Location = new Point(10, 1);
            comboBoxAddressType.MaximumSize = new Size(168, 23);
            comboBoxAddressType.MinimumSize = new Size(168, 23);
            comboBoxAddressType.Name = "comboBoxAddressType";
            comboBoxAddressType.Size = new Size(168, 23);
            comboBoxAddressType.TabIndex = 10;
            comboBoxAddressType.Texts = "Legacy P2PKH (prefix 1)";
            comboBoxAddressType.OnSelectedIndexChanged += comboBoxAddressType_OnSelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.ForeColor = Color.FromArgb(127, 137, 163);
            label12.Location = new Point(14, 13);
            label12.Name = "label12";
            label12.Size = new Size(89, 19);
            label12.TabIndex = 22;
            label12.Text = "Address type";
            // 
            // btnCPUThreadsMore
            // 
            btnCPUThreadsMore.BackColor = Color.Transparent;
            btnCPUThreadsMore.BackgroundColor = Color.Transparent;
            btnCPUThreadsMore.BorderColor = Color.PaleVioletRed;
            btnCPUThreadsMore.BorderRadius = 12;
            btnCPUThreadsMore.BorderSize = 0;
            btnCPUThreadsMore.FlatAppearance.BorderSize = 0;
            btnCPUThreadsMore.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 22, 31);
            btnCPUThreadsMore.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 22, 31);
            btnCPUThreadsMore.FlatStyle = FlatStyle.Flat;
            btnCPUThreadsMore.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btnCPUThreadsMore.ForeColor = Color.FromArgb(62, 72, 91);
            btnCPUThreadsMore.Location = new Point(260, 78);
            btnCPUThreadsMore.Name = "btnCPUThreadsMore";
            btnCPUThreadsMore.Padding = new Padding(2, 2, 0, 0);
            btnCPUThreadsMore.Size = new Size(24, 24);
            btnCPUThreadsMore.TabIndex = 21;
            btnCPUThreadsMore.Text = "▶";
            btnCPUThreadsMore.TextColor = Color.FromArgb(62, 72, 91);
            btnCPUThreadsMore.UseVisualStyleBackColor = false;
            btnCPUThreadsMore.Click += BtnCPUThreadsMore_Click;
            // 
            // btnCPUThreadsLess
            // 
            btnCPUThreadsLess.BackColor = Color.Transparent;
            btnCPUThreadsLess.BackgroundColor = Color.Transparent;
            btnCPUThreadsLess.BorderColor = Color.PaleVioletRed;
            btnCPUThreadsLess.BorderRadius = 12;
            btnCPUThreadsLess.BorderSize = 0;
            btnCPUThreadsLess.FlatAppearance.BorderSize = 0;
            btnCPUThreadsLess.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 22, 31);
            btnCPUThreadsLess.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 22, 31);
            btnCPUThreadsLess.FlatStyle = FlatStyle.Flat;
            btnCPUThreadsLess.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btnCPUThreadsLess.ForeColor = Color.FromArgb(62, 72, 91);
            btnCPUThreadsLess.Location = new Point(222, 78);
            btnCPUThreadsLess.Name = "btnCPUThreadsLess";
            btnCPUThreadsLess.Padding = new Padding(2, 2, 0, 0);
            btnCPUThreadsLess.Size = new Size(24, 24);
            btnCPUThreadsLess.TabIndex = 20;
            btnCPUThreadsLess.Text = "◀";
            btnCPUThreadsLess.TextColor = Color.FromArgb(62, 72, 91);
            btnCPUThreadsLess.UseVisualStyleBackColor = false;
            btnCPUThreadsLess.Click += BtnCPUThreadsLess_Click;
            // 
            // lblCPUThreads
            // 
            lblCPUThreads.AutoSize = true;
            lblCPUThreads.Font = new Font("Segoe UI", 10F);
            lblCPUThreads.ForeColor = Color.FromArgb(148, 84, 5);
            lblCPUThreads.Location = new Point(241, 81);
            lblCPUThreads.Name = "lblCPUThreads";
            lblCPUThreads.Size = new Size(25, 19);
            lblCPUThreads.TabIndex = 19;
            lblCPUThreads.Text = "00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.ForeColor = Color.FromArgb(127, 137, 163);
            label11.Location = new Point(14, 81);
            label11.Name = "label11";
            label11.Size = new Size(206, 19);
            label11.TabIndex = 18;
            label11.Text = "CPU threads (00 recommended)";
            // 
            // lblExampleAddressPart2
            // 
            lblExampleAddressPart2.AutoSize = true;
            lblExampleAddressPart2.Font = new Font("Consolas", 11.25F);
            lblExampleAddressPart2.ForeColor = Color.FromArgb(148, 84, 5);
            lblExampleAddressPart2.Location = new Point(420, 116);
            lblExampleAddressPart2.Margin = new Padding(0);
            lblExampleAddressPart2.Name = "lblExampleAddressPart2";
            lblExampleAddressPart2.Size = new Size(16, 18);
            lblExampleAddressPart2.TabIndex = 17;
            lblExampleAddressPart2.Text = "X";
            lblExampleAddressPart2.Visible = false;
            // 
            // lblExampleTarget
            // 
            lblExampleTarget.AutoSize = true;
            lblExampleTarget.Font = new Font("Consolas", 11.25F);
            lblExampleTarget.ForeColor = Color.FromArgb(247, 147, 26);
            lblExampleTarget.Location = new Point(93, 116);
            lblExampleTarget.Margin = new Padding(0);
            lblExampleTarget.Name = "lblExampleTarget";
            lblExampleTarget.Size = new Size(56, 18);
            lblExampleTarget.TabIndex = 16;
            lblExampleTarget.Text = "vAniTy";
            // 
            // lblExampleAddressPart1
            // 
            lblExampleAddressPart1.AutoSize = true;
            lblExampleAddressPart1.Font = new Font("Consolas", 11.25F);
            lblExampleAddressPart1.ForeColor = Color.FromArgb(148, 84, 5);
            lblExampleAddressPart1.Location = new Point(143, 116);
            lblExampleAddressPart1.Margin = new Padding(0);
            lblExampleAddressPart1.Name = "lblExampleAddressPart1";
            lblExampleAddressPart1.Size = new Size(272, 18);
            lblExampleAddressPart1.TabIndex = 15;
            lblExampleAddressPart1.Text = "Gxp4vRoCGJym3xR7yCVPFHoCNxv4Twseo";
            // 
            // panelTargetPositionContainer
            // 
            panelTargetPositionContainer.BackColor = Color.FromArgb(24, 27, 36);
            panelTargetPositionContainer.Controls.Add(comboBoxTargetPosition);
            panelTargetPositionContainer.Location = new Point(264, 46);
            panelTargetPositionContainer.Name = "panelTargetPositionContainer";
            panelTargetPositionContainer.Size = new Size(88, 24);
            panelTargetPositionContainer.TabIndex = 11;
            // 
            // comboBoxTargetPosition
            // 
            comboBoxTargetPosition.AutoSize = true;
            comboBoxTargetPosition.BackColor = Color.FromArgb(24, 27, 36);
            comboBoxTargetPosition.BorderColor = Color.MediumSlateBlue;
            comboBoxTargetPosition.BorderSize = 0;
            comboBoxTargetPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTargetPosition.Font = new Font("Segoe UI", 10F);
            comboBoxTargetPosition.ForeColor = Color.LightGray;
            comboBoxTargetPosition.IconColor = Color.White;
            comboBoxTargetPosition.Items.AddRange(new object[] { "after prefix", "anywhere", "suffix" });
            comboBoxTargetPosition.ListBackColor = Color.FromArgb(24, 27, 36);
            comboBoxTargetPosition.ListTextColor = Color.White;
            comboBoxTargetPosition.Location = new Point(0, 1);
            comboBoxTargetPosition.MaximumSize = new Size(84, 22);
            comboBoxTargetPosition.MinimumSize = new Size(84, 22);
            comboBoxTargetPosition.Name = "comboBoxTargetPosition";
            comboBoxTargetPosition.Size = new Size(84, 22);
            comboBoxTargetPosition.TabIndex = 10;
            comboBoxTargetPosition.Texts = "after prefix";
            comboBoxTargetPosition.OnSelectedIndexChanged += ComboBoxTargetPosition_OnSelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.FromArgb(127, 137, 163);
            label5.Location = new Point(201, 47);
            label5.Name = "label5";
            label5.Size = new Size(57, 19);
            label5.TabIndex = 10;
            label5.Text = "Position";
            // 
            // lblExamplePrefix
            // 
            lblExamplePrefix.AutoSize = true;
            lblExamplePrefix.Font = new Font("Consolas", 11.25F);
            lblExamplePrefix.ForeColor = Color.FromArgb(148, 84, 5);
            lblExamplePrefix.Location = new Point(84, 116);
            lblExamplePrefix.Margin = new Padding(0);
            lblExamplePrefix.Name = "lblExamplePrefix";
            lblExamplePrefix.Size = new Size(16, 18);
            lblExamplePrefix.TabIndex = 14;
            lblExamplePrefix.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(127, 137, 163);
            label4.Location = new Point(14, 115);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 13;
            label4.Text = "Example";
            // 
            // lblDifficultyFormula
            // 
            lblDifficultyFormula.AutoSize = true;
            lblDifficultyFormula.Font = new Font("Segoe UI", 10F);
            lblDifficultyFormula.ForeColor = Color.FromArgb(148, 84, 5);
            lblDifficultyFormula.Location = new Point(373, 81);
            lblDifficultyFormula.Name = "lblDifficultyFormula";
            lblDifficultyFormula.Size = new Size(21, 19);
            lblDifficultyFormula.TabIndex = 12;
            lblDifficultyFormula.Text = "( )";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(127, 137, 163);
            label3.Location = new Point(14, 47);
            label3.Name = "label3";
            label3.Size = new Size(94, 19);
            label3.TabIndex = 9;
            label3.Text = "Case sensitive";
            // 
            // panelCaseSensitiveContainer
            // 
            panelCaseSensitiveContainer.BackColor = Color.FromArgb(24, 27, 36);
            panelCaseSensitiveContainer.Controls.Add(comboBoxCaseSensitive);
            panelCaseSensitiveContainer.Location = new Point(114, 46);
            panelCaseSensitiveContainer.Name = "panelCaseSensitiveContainer";
            panelCaseSensitiveContainer.Size = new Size(50, 24);
            panelCaseSensitiveContainer.TabIndex = 6;
            // 
            // comboBoxCaseSensitive
            // 
            comboBoxCaseSensitive.BackColor = Color.FromArgb(24, 27, 36);
            comboBoxCaseSensitive.BorderColor = Color.MediumSlateBlue;
            comboBoxCaseSensitive.BorderSize = 0;
            comboBoxCaseSensitive.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCaseSensitive.Font = new Font("Segoe UI", 10F);
            comboBoxCaseSensitive.ForeColor = Color.LightGray;
            comboBoxCaseSensitive.IconColor = Color.White;
            comboBoxCaseSensitive.Items.AddRange(new object[] { "N", "Y" });
            comboBoxCaseSensitive.ListBackColor = Color.FromArgb(24, 27, 36);
            comboBoxCaseSensitive.ListTextColor = Color.White;
            comboBoxCaseSensitive.Location = new Point(10, 1);
            comboBoxCaseSensitive.MaximumSize = new Size(30, 22);
            comboBoxCaseSensitive.MinimumSize = new Size(20, 22);
            comboBoxCaseSensitive.Name = "comboBoxCaseSensitive";
            comboBoxCaseSensitive.Size = new Size(30, 22);
            comboBoxCaseSensitive.TabIndex = 10;
            comboBoxCaseSensitive.Texts = "N";
            comboBoxCaseSensitive.OnSelectedIndexChanged += ComboBoxCaseSensitive_OnSelectedIndexChanged;
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Font = new Font("Segoe UI", 10F);
            lblDifficulty.ForeColor = Color.FromArgb(148, 84, 5);
            lblDifficulty.Location = new Point(350, 81);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(17, 19);
            lblDifficulty.TabIndex = 8;
            lblDifficulty.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(127, 137, 163);
            label2.Location = new Point(290, 81);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 7;
            label2.Text = "Difficulty";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(127, 137, 163);
            label1.Location = new Point(317, 13);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 6;
            label1.Text = "Vanity string";
            // 
            // panelInputStringContainer
            // 
            panelInputStringContainer.BackColor = Color.FromArgb(24, 27, 36);
            panelInputStringContainer.Controls.Add(textBoxTargetString);
            panelInputStringContainer.Location = new Point(406, 12);
            panelInputStringContainer.Name = "panelInputStringContainer";
            panelInputStringContainer.Size = new Size(130, 24);
            panelInputStringContainer.TabIndex = 5;
            // 
            // textBoxTargetString
            // 
            textBoxTargetString.BackColor = Color.FromArgb(24, 27, 36);
            textBoxTargetString.BorderStyle = BorderStyle.None;
            textBoxTargetString.Font = new Font("Segoe UI", 10F);
            textBoxTargetString.ForeColor = Color.LightGray;
            textBoxTargetString.Location = new Point(10, 1);
            textBoxTargetString.MaxLength = 12;
            textBoxTargetString.Name = "textBoxTargetString";
            textBoxTargetString.Size = new Size(110, 18);
            textBoxTargetString.TabIndex = 4;
            textBoxTargetString.TextChanged += TextBoxTargetString_TextChanged;
            textBoxTargetString.KeyPress += TextBoxTargetString_KeyPress;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(62, 72, 91);
            btnGenerate.BackgroundColor = Color.FromArgb(62, 72, 91);
            btnGenerate.BorderColor = Color.PaleVioletRed;
            btnGenerate.BorderRadius = 12;
            btnGenerate.BorderSize = 0;
            btnGenerate.Enabled = false;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(555, 116);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(71, 24);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Generate";
            btnGenerate.TextColor = Color.White;
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += BtnGenerate_Click;
            // 
            // panelResults
            // 
            panelResults.BackColor = Color.FromArgb(13, 16, 24);
            panelResults.Controls.Add(lblCopied);
            panelResults.Controls.Add(btnCopyPrivateKey);
            panelResults.Controls.Add(btnCopyAddress);
            panelResults.Controls.Add(lblGeneratedPrivateKey);
            panelResults.Controls.Add(lblGeneratedAddress);
            panelResults.Controls.Add(label8);
            panelResults.Controls.Add(label7);
            panelResults.Location = new Point(12, 357);
            panelResults.Name = "panelResults";
            panelResults.Size = new Size(632, 84);
            panelResults.TabIndex = 4;
            // 
            // lblCopied
            // 
            lblCopied.AutoSize = true;
            lblCopied.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCopied.ForeColor = Color.FromArgb(127, 137, 163);
            lblCopied.Location = new Point(571, 14);
            lblCopied.Name = "lblCopied";
            lblCopied.Size = new Size(42, 13);
            lblCopied.TabIndex = 23;
            lblCopied.Text = "copied";
            lblCopied.Visible = false;
            // 
            // btnCopyPrivateKey
            // 
            btnCopyPrivateKey.BackColor = Color.Transparent;
            btnCopyPrivateKey.BackgroundColor = Color.Transparent;
            btnCopyPrivateKey.BackgroundImage = Resources.copy;
            btnCopyPrivateKey.BackgroundImageLayout = ImageLayout.Stretch;
            btnCopyPrivateKey.BorderColor = Color.PaleVioletRed;
            btnCopyPrivateKey.BorderRadius = 0;
            btnCopyPrivateKey.BorderSize = 0;
            btnCopyPrivateKey.FlatAppearance.BorderSize = 0;
            btnCopyPrivateKey.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCopyPrivateKey.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCopyPrivateKey.FlatStyle = FlatStyle.Flat;
            btnCopyPrivateKey.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCopyPrivateKey.ForeColor = Color.White;
            btnCopyPrivateKey.Location = new Point(555, 50);
            btnCopyPrivateKey.Name = "btnCopyPrivateKey";
            btnCopyPrivateKey.Size = new Size(14, 16);
            btnCopyPrivateKey.TabIndex = 22;
            btnCopyPrivateKey.TextColor = Color.White;
            btnCopyPrivateKey.UseVisualStyleBackColor = false;
            btnCopyPrivateKey.Visible = false;
            btnCopyPrivateKey.Click += btnCopyPrivateKey_Click;
            // 
            // btnCopyAddress
            // 
            btnCopyAddress.BackColor = Color.Transparent;
            btnCopyAddress.BackgroundColor = Color.Transparent;
            btnCopyAddress.BackgroundImage = Resources.copy;
            btnCopyAddress.BackgroundImageLayout = ImageLayout.Stretch;
            btnCopyAddress.BorderColor = Color.PaleVioletRed;
            btnCopyAddress.BorderRadius = 0;
            btnCopyAddress.BorderSize = 0;
            btnCopyAddress.FlatAppearance.BorderSize = 0;
            btnCopyAddress.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCopyAddress.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCopyAddress.FlatStyle = FlatStyle.Flat;
            btnCopyAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCopyAddress.ForeColor = Color.White;
            btnCopyAddress.Location = new Point(555, 16);
            btnCopyAddress.Name = "btnCopyAddress";
            btnCopyAddress.Size = new Size(14, 16);
            btnCopyAddress.TabIndex = 21;
            btnCopyAddress.TextColor = Color.White;
            btnCopyAddress.UseVisualStyleBackColor = false;
            btnCopyAddress.Visible = false;
            btnCopyAddress.Click += btnCopyAddress_Click;
            // 
            // lblGeneratedPrivateKey
            // 
            lblGeneratedPrivateKey.AutoSize = true;
            lblGeneratedPrivateKey.Font = new Font("Consolas", 11.25F);
            lblGeneratedPrivateKey.ForeColor = Color.FromArgb(148, 84, 5);
            lblGeneratedPrivateKey.Location = new Point(96, 48);
            lblGeneratedPrivateKey.Margin = new Padding(0);
            lblGeneratedPrivateKey.Name = "lblGeneratedPrivateKey";
            lblGeneratedPrivateKey.Size = new Size(16, 18);
            lblGeneratedPrivateKey.TabIndex = 19;
            lblGeneratedPrivateKey.Text = "-";
            // 
            // lblGeneratedAddress
            // 
            lblGeneratedAddress.AutoSize = true;
            lblGeneratedAddress.Font = new Font("Consolas", 11.25F);
            lblGeneratedAddress.ForeColor = Color.FromArgb(148, 84, 5);
            lblGeneratedAddress.Location = new Point(85, 14);
            lblGeneratedAddress.Margin = new Padding(0);
            lblGeneratedAddress.Name = "lblGeneratedAddress";
            lblGeneratedAddress.Size = new Size(16, 18);
            lblGeneratedAddress.TabIndex = 18;
            lblGeneratedAddress.Text = "-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.FromArgb(127, 137, 163);
            label8.Location = new Point(14, 47);
            label8.Name = "label8";
            label8.Size = new Size(76, 19);
            label8.TabIndex = 12;
            label8.Text = "Private key";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.FromArgb(127, 137, 163);
            label7.Location = new Point(14, 13);
            label7.Name = "label7";
            label7.Size = new Size(58, 19);
            label7.TabIndex = 11;
            label7.Text = "Address";
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.FromArgb(13, 16, 24);
            panelStatus.Controls.Add(lblTimeElapsed);
            panelStatus.Controls.Add(label10);
            panelStatus.Controls.Add(label9);
            panelStatus.Controls.Add(lblAddressesPerSecond);
            panelStatus.Controls.Add(btnCancel);
            panelStatus.Controls.Add(lblAddressesGenerated);
            panelStatus.Controls.Add(label6);
            panelStatus.Location = new Point(12, 268);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(632, 79);
            panelStatus.TabIndex = 4;
            // 
            // lblTimeElapsed
            // 
            lblTimeElapsed.AutoSize = true;
            lblTimeElapsed.Font = new Font("Segoe UI", 10F);
            lblTimeElapsed.ForeColor = Color.FromArgb(148, 84, 5);
            lblTimeElapsed.Location = new Point(330, 13);
            lblTimeElapsed.Name = "lblTimeElapsed";
            lblTimeElapsed.Size = new Size(15, 19);
            lblTimeElapsed.TabIndex = 18;
            lblTimeElapsed.Text = "-";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.FromArgb(127, 137, 163);
            label10.Location = new Point(236, 13);
            label10.Name = "label10";
            label10.Size = new Size(88, 19);
            label10.TabIndex = 15;
            label10.Text = "Time elapsed";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.FromArgb(127, 137, 163);
            label9.Location = new Point(14, 47);
            label9.Name = "label9";
            label9.Size = new Size(184, 19);
            label9.TabIndex = 14;
            label9.Text = "Efficiency (addresses/second)";
            // 
            // lblAddressesPerSecond
            // 
            lblAddressesPerSecond.AutoSize = true;
            lblAddressesPerSecond.Font = new Font("Segoe UI", 10F);
            lblAddressesPerSecond.ForeColor = Color.FromArgb(148, 84, 5);
            lblAddressesPerSecond.Location = new Point(207, 47);
            lblAddressesPerSecond.Name = "lblAddressesPerSecond";
            lblAddressesPerSecond.Size = new Size(15, 19);
            lblAddressesPerSecond.TabIndex = 13;
            lblAddressesPerSecond.Text = "-";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(62, 72, 91);
            btnCancel.BackgroundColor = Color.FromArgb(62, 72, 91);
            btnCancel.BorderColor = Color.PaleVioletRed;
            btnCancel.BorderRadius = 12;
            btnCancel.BorderSize = 0;
            btnCancel.Enabled = false;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(555, 47);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(71, 24);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = Color.White;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // lblAddressesGenerated
            // 
            lblAddressesGenerated.AutoSize = true;
            lblAddressesGenerated.Font = new Font("Segoe UI", 10F);
            lblAddressesGenerated.ForeColor = Color.FromArgb(148, 84, 5);
            lblAddressesGenerated.Location = new Point(157, 13);
            lblAddressesGenerated.Name = "lblAddressesGenerated";
            lblAddressesGenerated.Size = new Size(15, 19);
            lblAddressesGenerated.TabIndex = 11;
            lblAddressesGenerated.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.FromArgb(127, 137, 163);
            label6.Location = new Point(14, 13);
            label6.Name = "label6";
            label6.Size = new Size(137, 19);
            label6.TabIndex = 10;
            label6.Text = "Addresses generated";
            // 
            // timerHideErrorMessage
            // 
            timerHideErrorMessage.Interval = 7000;
            timerHideErrorMessage.Tick += TimerHideErrorMessage_Tick;
            // 
            // btnMoveWindow
            // 
            btnMoveWindow.BackColor = Color.Transparent;
            btnMoveWindow.BackgroundColor = Color.Transparent;
            btnMoveWindow.BorderColor = Color.PaleVioletRed;
            btnMoveWindow.BorderRadius = 12;
            btnMoveWindow.BorderSize = 0;
            btnMoveWindow.FlatAppearance.BorderSize = 0;
            btnMoveWindow.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMoveWindow.FlatStyle = FlatStyle.Flat;
            btnMoveWindow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMoveWindow.ForeColor = Color.FromArgb(13, 16, 24);
            btnMoveWindow.Location = new Point(291, 2);
            btnMoveWindow.Name = "btnMoveWindow";
            btnMoveWindow.Padding = new Padding(2, 2, 0, 0);
            btnMoveWindow.Size = new Size(366, 105);
            btnMoveWindow.TabIndex = 10;
            btnMoveWindow.TabStop = false;
            btnMoveWindow.TextColor = Color.FromArgb(13, 16, 24);
            btnMoveWindow.UseVisualStyleBackColor = false;
            btnMoveWindow.Click += BtnMoveWindow_Click;
            btnMoveWindow.MouseDown += BtnMoveWindow_MouseDown;
            btnMoveWindow.MouseUp += BtnMoveWindow_MouseUp;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new Font("Segoe UI", 8F);
            lblErrorMessage.ForeColor = Color.FromArgb(148, 84, 5);
            lblErrorMessage.Location = new Point(12, 440);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(79, 13);
            lblErrorMessage.TabIndex = 5;
            lblErrorMessage.Text = "Error message";
            lblErrorMessage.Visible = false;
            // 
            // timerHideCopiedMessage
            // 
            timerHideCopiedMessage.Interval = 2000;
            timerHideCopiedMessage.Tick += timerHideCopiedMessage_Tick;
            // 
            // Bitvain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 31);
            CancelButton = btnExit;
            ClientSize = new Size(656, 456);
            Controls.Add(btnExit);
            Controls.Add(btnMoveWindow);
            Controls.Add(lblErrorMessage);
            Controls.Add(panelResults);
            Controls.Add(panelStatus);
            Controls.Add(panelInputs);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Bitvain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bitvain";
            Load += Bitvain_Load;
            Paint += Bitvain_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelInputs.ResumeLayout(false);
            panelInputs.PerformLayout();
            panel1.ResumeLayout(false);
            panelTargetPositionContainer.ResumeLayout(false);
            panelTargetPositionContainer.PerformLayout();
            panelCaseSensitiveContainer.ResumeLayout(false);
            panelInputStringContainer.ResumeLayout(false);
            panelInputStringContainer.PerformLayout();
            panelResults.ResumeLayout(false);
            panelResults.PerformLayout();
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJButton btnExit;
        private PictureBox pictureBox1;
        private Panel panelInputs;
        private Panel panelResults;
        private Panel panelStatus;
        private CustomControls.RJControls.RJButton btnGenerate;
        private Panel panelInputStringContainer;
        private TextBox textBoxTargetString;
        private Label label1;
        private Label label2;
        private Label lblDifficulty;
        private System.Windows.Forms.Timer timerHideErrorMessage;
        private Panel panelCaseSensitiveContainer;
        private Label label3;
        private CustomControls.RJControls.RJComboBox comboBoxCaseSensitive;
        private CustomControls.RJControls.RJButton btnMoveWindow;
        private Label label5;
        private Panel panelTargetPositionContainer;
        private CustomControls.RJControls.RJComboBox comboBoxTargetPosition;
        private Label lblDifficultyFormula;
        private Label lblExamplePrefix;
        private Label label4;
        private Label lblExampleAddressPart1;
        private Label lblExampleTarget;
        private Label lblExampleAddressPart2;
        private Label lblAddressesGenerated;
        private Label label6;
        private Label label7;
        private Label lblGeneratedPrivateKey;
        private Label lblGeneratedAddress;
        private Label label8;
        private Label lblErrorMessage;
        private CustomControls.RJControls.RJButton btnCancel;
        private Label label9;
        private Label lblAddressesPerSecond;
        private Label label10;
        private Label lblTimeElapsed;
        private CustomControls.RJControls.RJButton btnCopyAddress;
        private Label label11;
        private CustomControls.RJControls.RJButton btnCPUThreadsMore;
        private CustomControls.RJControls.RJButton btnCPUThreadsLess;
        private Label lblCPUThreads;
        private CustomControls.RJControls.RJButton btnCopyPrivateKey;
        private Panel panel1;
        private CustomControls.RJControls.RJComboBox comboBoxAddressType;
        private Label label12;
        private Label lblCopied;
        private System.Windows.Forms.Timer timerHideCopiedMessage;
    }
}
