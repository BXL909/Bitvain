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
            btnExit = new CustomControls.RJControls.RJButton();
            panelInputs = new Panel();
            panelErrorMessage = new Panel();
            panel1 = new Panel();
            lblErrorMessage = new Label();
            label13 = new Label();
            panelAddressTypeContainer = new Panel();
            comboBoxAddressType = new CustomControls.RJControls.RJComboBox();
            btnCPUThreadsMore = new CustomControls.RJControls.RJButton();
            btnCPUThreadsLess = new CustomControls.RJControls.RJButton();
            label12 = new Label();
            lblCPUThreads = new Label();
            label11 = new Label();
            lblExampleAddressPart2 = new Label();
            panelTargetPositionContainer = new Panel();
            comboBoxTargetPosition = new CustomControls.RJControls.RJComboBox();
            label5 = new Label();
            lblExampleTarget = new Label();
            lblDifficultyFormula = new Label();
            label4 = new Label();
            lblExampleAddressPart1 = new Label();
            label3 = new Label();
            lblExamplePrefix = new Label();
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
            timerHideCopiedMessage = new System.Windows.Forms.Timer(components);
            timerCompletedMessage = new System.Windows.Forms.Timer(components);
            lblCompleted = new Label();
            timerRepaintStuff = new System.Windows.Forms.Timer(components);
            btnMinimise = new CustomControls.RJControls.RJButton();
            btnAbout = new CustomControls.RJControls.RJButton();
            panelHelp = new Panel();
            btnCloseInfo = new CustomControls.RJControls.RJButton();
            label14 = new Label();
            btnHelp = new CustomControls.RJControls.RJButton();
            panelInputs.SuspendLayout();
            panelErrorMessage.SuspendLayout();
            panel1.SuspendLayout();
            panelAddressTypeContainer.SuspendLayout();
            panelTargetPositionContainer.SuspendLayout();
            panelCaseSensitiveContainer.SuspendLayout();
            panelInputStringContainer.SuspendLayout();
            panelResults.SuspendLayout();
            panelStatus.SuspendLayout();
            panelHelp.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(62, 72, 91);
            btnExit.BackgroundColor = Color.FromArgb(62, 72, 91);
            btnExit.BorderColor = Color.FromArgb(19, 22, 31);
            btnExit.BorderRadius = 12;
            btnExit.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(623, 12);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(2, 2, 0, 0);
            btnExit.Size = new Size(24, 24);
            btnExit.TabIndex = 4;
            btnExit.Text = "X";
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += BtnExit_Click;
            // 
            // panelInputs
            // 
            panelInputs.BackColor = Color.FromArgb(13, 16, 24);
            panelInputs.Controls.Add(panelErrorMessage);
            panelInputs.Controls.Add(panelAddressTypeContainer);
            panelInputs.Controls.Add(btnCPUThreadsMore);
            panelInputs.Controls.Add(btnCPUThreadsLess);
            panelInputs.Controls.Add(label12);
            panelInputs.Controls.Add(lblCPUThreads);
            panelInputs.Controls.Add(label11);
            panelInputs.Controls.Add(lblExampleAddressPart2);
            panelInputs.Controls.Add(panelTargetPositionContainer);
            panelInputs.Controls.Add(label5);
            panelInputs.Controls.Add(lblExampleTarget);
            panelInputs.Controls.Add(lblDifficultyFormula);
            panelInputs.Controls.Add(label4);
            panelInputs.Controls.Add(lblExampleAddressPart1);
            panelInputs.Controls.Add(label3);
            panelInputs.Controls.Add(lblExamplePrefix);
            panelInputs.Controls.Add(panelCaseSensitiveContainer);
            panelInputs.Controls.Add(lblDifficulty);
            panelInputs.Controls.Add(label2);
            panelInputs.Controls.Add(label1);
            panelInputs.Controls.Add(panelInputStringContainer);
            panelInputs.Controls.Add(btnGenerate);
            panelInputs.Location = new Point(12, 110);
            panelInputs.Name = "panelInputs";
            panelInputs.Size = new Size(635, 182);
            panelInputs.TabIndex = 3;
            // 
            // panelErrorMessage
            // 
            panelErrorMessage.BackColor = Color.FromArgb(52, 62, 81);
            panelErrorMessage.Controls.Add(panel1);
            panelErrorMessage.Location = new Point(14, 148);
            panelErrorMessage.Name = "panelErrorMessage";
            panelErrorMessage.Size = new Size(510, 24);
            panelErrorMessage.TabIndex = 24;
            panelErrorMessage.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(8, 11, 19);
            panel1.Controls.Add(lblErrorMessage);
            panel1.Controls.Add(label13);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 22);
            panel1.TabIndex = 10;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorMessage.ForeColor = Color.FromArgb(127, 137, 163);
            lblErrorMessage.Location = new Point(35, 0);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(96, 19);
            lblErrorMessage.TabIndex = 5;
            lblErrorMessage.Text = "Error message";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.IndianRed;
            label13.Location = new Point(5, 0);
            label13.Name = "label13";
            label13.Size = new Size(28, 19);
            label13.TabIndex = 9;
            label13.Text = "⚠️";
            // 
            // panelAddressTypeContainer
            // 
            panelAddressTypeContainer.BackColor = Color.FromArgb(24, 27, 36);
            panelAddressTypeContainer.Controls.Add(comboBoxAddressType);
            panelAddressTypeContainer.Location = new Point(380, 12);
            panelAddressTypeContainer.Name = "panelAddressTypeContainer";
            panelAddressTypeContainer.Size = new Size(217, 24);
            panelAddressTypeContainer.TabIndex = 23;
            // 
            // comboBoxAddressType
            // 
            comboBoxAddressType.BackColor = Color.Transparent;
            comboBoxAddressType.BackgroundImage = Resources.dropdownAddressType1;
            comboBoxAddressType.BackgroundImageLayout = ImageLayout.Stretch;
            comboBoxAddressType.BorderColor = Color.FromArgb(24, 27, 36);
            comboBoxAddressType.BorderSize = 0;
            comboBoxAddressType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAddressType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxAddressType.ForeColor = Color.LightGray;
            comboBoxAddressType.IconColor = Color.White;
            comboBoxAddressType.Items.AddRange(new object[] { "Legacy P2PKH (prefix 1)", "SegwitP2SH (prefix 3)", "Native segwit (prefix bc1q)", "Taproot P2TR (prefix bc1p)" });
            comboBoxAddressType.ListBackColor = Color.FromArgb(24, 27, 36);
            comboBoxAddressType.ListTextColor = Color.White;
            comboBoxAddressType.Location = new Point(10, 1);
            comboBoxAddressType.MaximumSize = new Size(197, 22);
            comboBoxAddressType.MinimumSize = new Size(197, 22);
            comboBoxAddressType.Name = "comboBoxAddressType";
            comboBoxAddressType.Size = new Size(197, 22);
            comboBoxAddressType.TabIndex = 6;
            comboBoxAddressType.Texts = "Legacy P2PKH (prefix 1)";
            comboBoxAddressType.OnSelectedIndexChanged += ComboBoxAddressType_OnSelectedIndexChanged;
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
            btnCPUThreadsMore.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnCPUThreadsMore.ForeColor = Color.FromArgb(62, 72, 91);
            btnCPUThreadsMore.Location = new Point(260, 112);
            btnCPUThreadsMore.Name = "btnCPUThreadsMore";
            btnCPUThreadsMore.Padding = new Padding(2, 2, 0, 0);
            btnCPUThreadsMore.Size = new Size(24, 24);
            btnCPUThreadsMore.TabIndex = 21;
            btnCPUThreadsMore.TabStop = false;
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
            btnCPUThreadsLess.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnCPUThreadsLess.ForeColor = Color.FromArgb(62, 72, 91);
            btnCPUThreadsLess.Location = new Point(222, 112);
            btnCPUThreadsLess.Name = "btnCPUThreadsLess";
            btnCPUThreadsLess.Padding = new Padding(2, 2, 0, 0);
            btnCPUThreadsLess.Size = new Size(24, 24);
            btnCPUThreadsLess.TabIndex = 20;
            btnCPUThreadsLess.TabStop = false;
            btnCPUThreadsLess.Text = "◀";
            btnCPUThreadsLess.TextColor = Color.FromArgb(62, 72, 91);
            btnCPUThreadsLess.UseVisualStyleBackColor = false;
            btnCPUThreadsLess.Click += BtnCPUThreadsLess_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(127, 137, 163);
            label12.Location = new Point(281, 13);
            label12.Name = "label12";
            label12.Size = new Size(89, 19);
            label12.TabIndex = 22;
            label12.Text = "Address type";
            // 
            // lblCPUThreads
            // 
            lblCPUThreads.AutoSize = true;
            lblCPUThreads.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCPUThreads.ForeColor = Color.FromArgb(148, 84, 5);
            lblCPUThreads.Location = new Point(241, 115);
            lblCPUThreads.Name = "lblCPUThreads";
            lblCPUThreads.Size = new Size(25, 19);
            lblCPUThreads.TabIndex = 19;
            lblCPUThreads.Text = "00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(127, 137, 163);
            label11.Location = new Point(14, 115);
            label11.Name = "label11";
            label11.Size = new Size(206, 19);
            label11.TabIndex = 18;
            label11.Text = "CPU threads (00 recommended)";
            // 
            // lblExampleAddressPart2
            // 
            lblExampleAddressPart2.AutoSize = true;
            lblExampleAddressPart2.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblExampleAddressPart2.ForeColor = Color.FromArgb(148, 84, 5);
            lblExampleAddressPart2.Location = new Point(420, 82);
            lblExampleAddressPart2.Margin = new Padding(0);
            lblExampleAddressPart2.Name = "lblExampleAddressPart2";
            lblExampleAddressPart2.Size = new Size(16, 18);
            lblExampleAddressPart2.TabIndex = 17;
            lblExampleAddressPart2.Text = "X";
            lblExampleAddressPart2.Visible = false;
            // 
            // panelTargetPositionContainer
            // 
            panelTargetPositionContainer.BackColor = Color.FromArgb(24, 27, 36);
            panelTargetPositionContainer.Controls.Add(comboBoxTargetPosition);
            panelTargetPositionContainer.Location = new Point(264, 46);
            panelTargetPositionContainer.Name = "panelTargetPositionContainer";
            panelTargetPositionContainer.Size = new Size(130, 24);
            panelTargetPositionContainer.TabIndex = 11;
            // 
            // comboBoxTargetPosition
            // 
            comboBoxTargetPosition.AutoSize = true;
            comboBoxTargetPosition.BackColor = Color.Transparent;
            comboBoxTargetPosition.BackgroundImage = Resources.dropdownPosition;
            comboBoxTargetPosition.BackgroundImageLayout = ImageLayout.Stretch;
            comboBoxTargetPosition.BorderColor = Color.FromArgb(24, 27, 36);
            comboBoxTargetPosition.BorderSize = 0;
            comboBoxTargetPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTargetPosition.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTargetPosition.ForeColor = Color.LightGray;
            comboBoxTargetPosition.IconColor = Color.White;
            comboBoxTargetPosition.Items.AddRange(new object[] { "after prefix", "anywhere", "suffix" });
            comboBoxTargetPosition.ListBackColor = Color.FromArgb(24, 27, 36);
            comboBoxTargetPosition.ListTextColor = Color.White;
            comboBoxTargetPosition.Location = new Point(10, 1);
            comboBoxTargetPosition.MaximumSize = new Size(110, 22);
            comboBoxTargetPosition.MinimumSize = new Size(110, 22);
            comboBoxTargetPosition.Name = "comboBoxTargetPosition";
            comboBoxTargetPosition.Size = new Size(110, 22);
            comboBoxTargetPosition.TabIndex = 8;
            comboBoxTargetPosition.Texts = "after prefix";
            comboBoxTargetPosition.OnSelectedIndexChanged += ComboBoxTargetPosition_OnSelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(127, 137, 163);
            label5.Location = new Point(201, 47);
            label5.Name = "label5";
            label5.Size = new Size(57, 19);
            label5.TabIndex = 10;
            label5.Text = "Position";
            // 
            // lblExampleTarget
            // 
            lblExampleTarget.AutoSize = true;
            lblExampleTarget.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblExampleTarget.ForeColor = Color.FromArgb(247, 147, 26);
            lblExampleTarget.Location = new Point(93, 82);
            lblExampleTarget.Margin = new Padding(0);
            lblExampleTarget.Name = "lblExampleTarget";
            lblExampleTarget.Size = new Size(56, 18);
            lblExampleTarget.TabIndex = 16;
            lblExampleTarget.Text = "vAniTy";
            // 
            // lblDifficultyFormula
            // 
            lblDifficultyFormula.AutoSize = true;
            lblDifficultyFormula.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDifficultyFormula.ForeColor = Color.FromArgb(148, 84, 5);
            lblDifficultyFormula.Location = new Point(438, 114);
            lblDifficultyFormula.Name = "lblDifficultyFormula";
            lblDifficultyFormula.Size = new Size(21, 19);
            lblDifficultyFormula.TabIndex = 12;
            lblDifficultyFormula.Text = "( )";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(127, 137, 163);
            label4.Location = new Point(14, 81);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 13;
            label4.Text = "Example";
            // 
            // lblExampleAddressPart1
            // 
            lblExampleAddressPart1.AutoSize = true;
            lblExampleAddressPart1.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblExampleAddressPart1.ForeColor = Color.FromArgb(148, 84, 5);
            lblExampleAddressPart1.Location = new Point(143, 82);
            lblExampleAddressPart1.Margin = new Padding(0);
            lblExampleAddressPart1.Name = "lblExampleAddressPart1";
            lblExampleAddressPart1.Size = new Size(272, 18);
            lblExampleAddressPart1.TabIndex = 15;
            lblExampleAddressPart1.Text = "Gxp4vRoCGJym3xR7yCVPFHoCNxv4Twseo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(127, 137, 163);
            label3.Location = new Point(14, 47);
            label3.Name = "label3";
            label3.Size = new Size(94, 19);
            label3.TabIndex = 9;
            label3.Text = "Case sensitive";
            // 
            // lblExamplePrefix
            // 
            lblExamplePrefix.AutoSize = true;
            lblExamplePrefix.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblExamplePrefix.ForeColor = Color.FromArgb(148, 84, 5);
            lblExamplePrefix.Location = new Point(84, 82);
            lblExamplePrefix.Margin = new Padding(0);
            lblExamplePrefix.Name = "lblExamplePrefix";
            lblExamplePrefix.Size = new Size(16, 18);
            lblExamplePrefix.TabIndex = 14;
            lblExamplePrefix.Text = "1";
            // 
            // panelCaseSensitiveContainer
            // 
            panelCaseSensitiveContainer.BackColor = Color.FromArgb(24, 27, 36);
            panelCaseSensitiveContainer.Controls.Add(comboBoxCaseSensitive);
            panelCaseSensitiveContainer.Location = new Point(114, 46);
            panelCaseSensitiveContainer.Name = "panelCaseSensitiveContainer";
            panelCaseSensitiveContainer.Size = new Size(69, 24);
            panelCaseSensitiveContainer.TabIndex = 6;
            // 
            // comboBoxCaseSensitive
            // 
            comboBoxCaseSensitive.BackColor = Color.Transparent;
            comboBoxCaseSensitive.BackgroundImage = Resources.dropdownCaseSensitive;
            comboBoxCaseSensitive.BackgroundImageLayout = ImageLayout.Stretch;
            comboBoxCaseSensitive.BorderColor = Color.FromArgb(24, 27, 36);
            comboBoxCaseSensitive.BorderSize = 0;
            comboBoxCaseSensitive.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCaseSensitive.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCaseSensitive.ForeColor = Color.LightGray;
            comboBoxCaseSensitive.IconColor = Color.White;
            comboBoxCaseSensitive.Items.AddRange(new object[] { "N", "Y" });
            comboBoxCaseSensitive.ListBackColor = Color.FromArgb(24, 27, 36);
            comboBoxCaseSensitive.ListTextColor = Color.White;
            comboBoxCaseSensitive.Location = new Point(10, 1);
            comboBoxCaseSensitive.MaximumSize = new Size(49, 22);
            comboBoxCaseSensitive.MinimumSize = new Size(49, 22);
            comboBoxCaseSensitive.Name = "comboBoxCaseSensitive";
            comboBoxCaseSensitive.Size = new Size(49, 22);
            comboBoxCaseSensitive.TabIndex = 7;
            comboBoxCaseSensitive.Texts = "N";
            comboBoxCaseSensitive.OnSelectedIndexChanged += ComboBoxCaseSensitive_OnSelectedIndexChanged;
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDifficulty.ForeColor = Color.FromArgb(148, 84, 5);
            lblDifficulty.Location = new Point(415, 114);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(17, 19);
            lblDifficulty.TabIndex = 8;
            lblDifficulty.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(127, 137, 163);
            label2.Location = new Point(355, 114);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 7;
            label2.Text = "Difficulty";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(127, 137, 163);
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 6;
            label1.Text = "Vanity string";
            // 
            // panelInputStringContainer
            // 
            panelInputStringContainer.BackColor = Color.FromArgb(24, 27, 36);
            panelInputStringContainer.Controls.Add(textBoxTargetString);
            panelInputStringContainer.Location = new Point(103, 12);
            panelInputStringContainer.Name = "panelInputStringContainer";
            panelInputStringContainer.Size = new Size(130, 24);
            panelInputStringContainer.TabIndex = 5;
            // 
            // textBoxTargetString
            // 
            textBoxTargetString.BackColor = Color.FromArgb(24, 27, 36);
            textBoxTargetString.BorderStyle = BorderStyle.None;
            textBoxTargetString.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTargetString.ForeColor = Color.LightGray;
            textBoxTargetString.Location = new Point(10, 1);
            textBoxTargetString.MaxLength = 12;
            textBoxTargetString.Name = "textBoxTargetString";
            textBoxTargetString.Size = new Size(110, 18);
            textBoxTargetString.TabIndex = 5;
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
            btnGenerate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(538, 148);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(91, 24);
            btnGenerate.TabIndex = 9;
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
            panelResults.Location = new Point(12, 391);
            panelResults.Name = "panelResults";
            panelResults.Size = new Size(635, 84);
            panelResults.TabIndex = 4;
            // 
            // lblCopied
            // 
            lblCopied.AutoSize = true;
            lblCopied.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
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
            btnCopyPrivateKey.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopyPrivateKey.ForeColor = Color.White;
            btnCopyPrivateKey.Location = new Point(555, 50);
            btnCopyPrivateKey.Name = "btnCopyPrivateKey";
            btnCopyPrivateKey.Size = new Size(14, 16);
            btnCopyPrivateKey.TabIndex = 22;
            btnCopyPrivateKey.TabStop = false;
            btnCopyPrivateKey.TextColor = Color.White;
            btnCopyPrivateKey.UseVisualStyleBackColor = false;
            btnCopyPrivateKey.Visible = false;
            btnCopyPrivateKey.Click += BtnCopyPrivateKey_Click;
            btnCopyPrivateKey.MouseUp += Copy_MouseUp;
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
            btnCopyAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopyAddress.ForeColor = Color.White;
            btnCopyAddress.Location = new Point(555, 16);
            btnCopyAddress.Name = "btnCopyAddress";
            btnCopyAddress.Size = new Size(14, 16);
            btnCopyAddress.TabIndex = 21;
            btnCopyAddress.TabStop = false;
            btnCopyAddress.TextColor = Color.White;
            btnCopyAddress.UseVisualStyleBackColor = false;
            btnCopyAddress.Visible = false;
            btnCopyAddress.Click += BtnCopyAddress_Click;
            btnCopyAddress.MouseUp += Copy_MouseUp;
            // 
            // lblGeneratedPrivateKey
            // 
            lblGeneratedPrivateKey.AutoSize = true;
            lblGeneratedPrivateKey.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
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
            lblGeneratedAddress.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
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
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
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
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
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
            panelStatus.Location = new Point(12, 302);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(635, 79);
            panelStatus.TabIndex = 4;
            // 
            // lblTimeElapsed
            // 
            lblTimeElapsed.AutoSize = true;
            lblTimeElapsed.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimeElapsed.ForeColor = Color.FromArgb(148, 84, 5);
            lblTimeElapsed.Location = new Point(421, 13);
            lblTimeElapsed.Name = "lblTimeElapsed";
            lblTimeElapsed.Size = new Size(96, 19);
            lblTimeElapsed.TabIndex = 18;
            lblTimeElapsed.Text = "0d, 0h, 0m, 0s";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(127, 137, 163);
            label10.Location = new Point(327, 13);
            label10.Name = "label10";
            label10.Size = new Size(88, 19);
            label10.TabIndex = 15;
            label10.Text = "Time elapsed";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
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
            lblAddressesPerSecond.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddressesPerSecond.ForeColor = Color.FromArgb(148, 84, 5);
            lblAddressesPerSecond.Location = new Point(207, 47);
            lblAddressesPerSecond.Name = "lblAddressesPerSecond";
            lblAddressesPerSecond.Size = new Size(17, 19);
            lblAddressesPerSecond.TabIndex = 13;
            lblAddressesPerSecond.Text = "0";
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
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(538, 47);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(91, 24);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = Color.White;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // lblAddressesGenerated
            // 
            lblAddressesGenerated.AutoSize = true;
            lblAddressesGenerated.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddressesGenerated.ForeColor = Color.FromArgb(148, 84, 5);
            lblAddressesGenerated.Location = new Point(157, 13);
            lblAddressesGenerated.Name = "lblAddressesGenerated";
            lblAddressesGenerated.Size = new Size(17, 19);
            lblAddressesGenerated.TabIndex = 11;
            lblAddressesGenerated.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
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
            btnMoveWindow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMoveWindow.ForeColor = Color.FromArgb(13, 16, 24);
            btnMoveWindow.Location = new Point(-5, -16);
            btnMoveWindow.Name = "btnMoveWindow";
            btnMoveWindow.Padding = new Padding(2, 2, 0, 0);
            btnMoveWindow.Size = new Size(674, 518);
            btnMoveWindow.TabIndex = 10;
            btnMoveWindow.TabStop = false;
            btnMoveWindow.TextColor = Color.FromArgb(13, 16, 24);
            btnMoveWindow.UseVisualStyleBackColor = false;
            btnMoveWindow.Click += BtnMoveWindow_Click;
            btnMoveWindow.MouseDown += BtnMoveWindow_MouseDown;
            btnMoveWindow.MouseUp += BtnMoveWindow_MouseUp;
            // 
            // timerHideCopiedMessage
            // 
            timerHideCopiedMessage.Interval = 2000;
            timerHideCopiedMessage.Tick += TimerHideCopiedMessage_Tick;
            // 
            // timerCompletedMessage
            // 
            timerCompletedMessage.Interval = 1000;
            timerCompletedMessage.Tick += TimerCompletedMessage_Tick;
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompleted.ForeColor = Color.FromArgb(247, 147, 26);
            lblCompleted.Location = new Point(562, 90);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(85, 17);
            lblCompleted.TabIndex = 25;
            lblCompleted.Text = "COMPLETED";
            lblCompleted.Visible = false;
            // 
            // timerRepaintStuff
            // 
            timerRepaintStuff.Tick += TimerRepaintStuff_Tick;
            // 
            // btnMinimise
            // 
            btnMinimise.BackColor = Color.FromArgb(62, 72, 91);
            btnMinimise.BackgroundColor = Color.FromArgb(62, 72, 91);
            btnMinimise.BorderColor = Color.FromArgb(19, 22, 31);
            btnMinimise.BorderRadius = 12;
            btnMinimise.BorderSize = 0;
            btnMinimise.FlatAppearance.BorderSize = 0;
            btnMinimise.FlatStyle = FlatStyle.Flat;
            btnMinimise.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimise.ForeColor = Color.White;
            btnMinimise.Location = new Point(593, 12);
            btnMinimise.Name = "btnMinimise";
            btnMinimise.Padding = new Padding(0, 2, 0, 0);
            btnMinimise.Size = new Size(24, 24);
            btnMinimise.TabIndex = 3;
            btnMinimise.Text = "⎯";
            btnMinimise.TextColor = Color.White;
            btnMinimise.UseVisualStyleBackColor = false;
            btnMinimise.Click += BtnMinimise_Click;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.FromArgb(62, 72, 91);
            btnAbout.BackgroundColor = Color.FromArgb(62, 72, 91);
            btnAbout.BorderColor = Color.FromArgb(19, 22, 31);
            btnAbout.BorderRadius = 12;
            btnAbout.BorderSize = 0;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Book Antiqua", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAbout.ForeColor = Color.White;
            btnAbout.Location = new Point(533, 12);
            btnAbout.Name = "btnAbout";
            btnAbout.Padding = new Padding(2, 0, 0, 0);
            btnAbout.Size = new Size(24, 24);
            btnAbout.TabIndex = 2;
            btnAbout.Text = "i";
            btnAbout.TextColor = Color.White;
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += BtnAbout_Click;
            // 
            // panelHelp
            // 
            panelHelp.BackColor = Color.FromArgb(13, 16, 24);
            panelHelp.Controls.Add(btnCloseInfo);
            panelHelp.Controls.Add(label14);
            panelHelp.Location = new Point(12, 110);
            panelHelp.Name = "panelHelp";
            panelHelp.Size = new Size(635, 365);
            panelHelp.TabIndex = 19;
            panelHelp.Visible = false;
            // 
            // btnCloseInfo
            // 
            btnCloseInfo.BackColor = Color.FromArgb(62, 72, 91);
            btnCloseInfo.BackgroundColor = Color.FromArgb(62, 72, 91);
            btnCloseInfo.BorderColor = Color.PaleVioletRed;
            btnCloseInfo.BorderRadius = 12;
            btnCloseInfo.BorderSize = 0;
            btnCloseInfo.FlatAppearance.BorderSize = 0;
            btnCloseInfo.FlatStyle = FlatStyle.Flat;
            btnCloseInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCloseInfo.ForeColor = Color.White;
            btnCloseInfo.Location = new Point(558, 331);
            btnCloseInfo.Name = "btnCloseInfo";
            btnCloseInfo.Size = new Size(71, 24);
            btnCloseInfo.TabIndex = 4;
            btnCloseInfo.Text = "Close";
            btnCloseInfo.TextColor = Color.White;
            btnCloseInfo.UseVisualStyleBackColor = false;
            btnCloseInfo.Click += BtnCloseInfo_Click;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(127, 137, 163);
            label14.Location = new Point(15, 15);
            label14.Name = "label14";
            label14.Size = new Size(602, 328);
            label14.TabIndex = 0;
            label14.Text = resources.GetString("label14.Text");
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.FromArgb(62, 72, 91);
            btnHelp.BackgroundColor = Color.FromArgb(62, 72, 91);
            btnHelp.BorderColor = Color.FromArgb(19, 22, 31);
            btnHelp.BorderRadius = 12;
            btnHelp.BorderSize = 0;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHelp.ForeColor = Color.White;
            btnHelp.Location = new Point(563, 12);
            btnHelp.Name = "btnHelp";
            btnHelp.Padding = new Padding(2, 0, 0, 0);
            btnHelp.Size = new Size(24, 24);
            btnHelp.TabIndex = 1;
            btnHelp.Text = "?";
            btnHelp.TextColor = Color.White;
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += BtnHelp_Click;
            // 
            // Bitvain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 31);
            BackgroundImage = Resources.AppBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = btnExit;
            ClientSize = new Size(662, 490);
            Controls.Add(btnHelp);
            Controls.Add(btnAbout);
            Controls.Add(btnMinimise);
            Controls.Add(lblCompleted);
            Controls.Add(panelInputs);
            Controls.Add(btnExit);
            Controls.Add(panelResults);
            Controls.Add(panelStatus);
            Controls.Add(btnMoveWindow);
            Controls.Add(panelHelp);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Bitvain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bitvain";
            Load += Bitvain_Load;
            Paint += Bitvain_Paint;
            panelInputs.ResumeLayout(false);
            panelInputs.PerformLayout();
            panelErrorMessage.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelAddressTypeContainer.ResumeLayout(false);
            panelTargetPositionContainer.ResumeLayout(false);
            panelTargetPositionContainer.PerformLayout();
            panelCaseSensitiveContainer.ResumeLayout(false);
            panelInputStringContainer.ResumeLayout(false);
            panelInputStringContainer.PerformLayout();
            panelResults.ResumeLayout(false);
            panelResults.PerformLayout();
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            panelHelp.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJButton btnExit;
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
        private Panel panelAddressTypeContainer;
        private CustomControls.RJControls.RJComboBox comboBoxAddressType;
        private Label label12;
        private Label lblCopied;
        private System.Windows.Forms.Timer timerHideCopiedMessage;
        private Panel panelErrorMessage;
        private Label label13;
        private Panel panel1;
        private System.Windows.Forms.Timer timerCompletedMessage;
        private Label lblCompleted;
        private System.Windows.Forms.Timer timerRepaintStuff;
        private CustomControls.RJControls.RJButton btnMinimise;
        private CustomControls.RJControls.RJButton btnAbout;
        private Panel panelHelp;
        private Label label14;
        private CustomControls.RJControls.RJButton btnCloseInfo;
        private CustomControls.RJControls.RJButton btnHelp;
    }
}
