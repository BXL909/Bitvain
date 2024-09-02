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
            lblTargetStringInputError = new Label();
            panelResults = new Panel();
            panelStatus = new Panel();
            lblErrorMessage = new Label();
            timerTargetStringMessage = new System.Windows.Forms.Timer(components);
            btnMoveWindow = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelInputs.SuspendLayout();
            panelTargetPositionContainer.SuspendLayout();
            panelCaseSensitiveContainer.SuspendLayout();
            panelInputStringContainer.SuspendLayout();
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
            btnExit.BackColor = Color.FromArgb(247, 147, 26);
            btnExit.BackgroundColor = Color.FromArgb(247, 147, 26);
            btnExit.BorderColor = Color.PaleVioletRed;
            btnExit.BorderRadius = 12;
            btnExit.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(13, 16, 24);
            btnExit.Location = new Point(487, 12);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(2, 2, 0, 0);
            btnExit.Size = new Size(24, 24);
            btnExit.TabIndex = 2;
            btnExit.Text = "X";
            btnExit.TextColor = Color.FromArgb(13, 16, 24);
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += BtnExit_Click;
            // 
            // panelInputs
            // 
            panelInputs.BackColor = Color.FromArgb(13, 16, 24);
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
            panelInputs.Size = new Size(499, 114);
            panelInputs.TabIndex = 3;
            // 
            // lblExampleAddressPart2
            // 
            lblExampleAddressPart2.AutoSize = true;
            lblExampleAddressPart2.Font = new Font("Consolas", 11.25F);
            lblExampleAddressPart2.ForeColor = Color.FromArgb(79, 82, 91);
            lblExampleAddressPart2.Location = new Point(383, 83);
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
            lblExampleTarget.Location = new Point(56, 83);
            lblExampleTarget.Margin = new Padding(0);
            lblExampleTarget.Name = "lblExampleTarget";
            lblExampleTarget.Size = new Size(48, 18);
            lblExampleTarget.TabIndex = 16;
            lblExampleTarget.Text = "xMple";
            // 
            // lblExampleAddressPart1
            // 
            lblExampleAddressPart1.AutoSize = true;
            lblExampleAddressPart1.Font = new Font("Consolas", 11.25F);
            lblExampleAddressPart1.ForeColor = Color.FromArgb(79, 82, 91);
            lblExampleAddressPart1.Location = new Point(106, 83);
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
            panelTargetPositionContainer.Location = new Point(349, 12);
            panelTargetPositionContainer.Name = "panelTargetPositionContainer";
            panelTargetPositionContainer.Size = new Size(120, 24);
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
            comboBoxTargetPosition.MaximumSize = new Size(100, 22);
            comboBoxTargetPosition.MinimumSize = new Size(100, 22);
            comboBoxTargetPosition.Name = "comboBoxTargetPosition";
            comboBoxTargetPosition.Size = new Size(100, 22);
            comboBoxTargetPosition.TabIndex = 10;
            comboBoxTargetPosition.Texts = "after prefix";
            comboBoxTargetPosition.OnSelectedIndexChanged += comboBoxTargetPosition_OnSelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.FromArgb(127, 137, 163);
            label5.Location = new Point(286, 14);
            label5.Name = "label5";
            label5.Size = new Size(57, 19);
            label5.TabIndex = 10;
            label5.Text = "Position";
            // 
            // lblExamplePrefix
            // 
            lblExamplePrefix.AutoSize = true;
            lblExamplePrefix.Font = new Font("Consolas", 11.25F);
            lblExamplePrefix.ForeColor = Color.FromArgb(79, 82, 91);
            lblExamplePrefix.Location = new Point(47, 83);
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
            label4.Location = new Point(14, 81);
            label4.Name = "label4";
            label4.Size = new Size(27, 19);
            label4.TabIndex = 13;
            label4.Text = "e.g";
            // 
            // lblDifficultyFormula
            // 
            lblDifficultyFormula.AutoSize = true;
            lblDifficultyFormula.Font = new Font("Segoe UI", 10F);
            lblDifficultyFormula.ForeColor = Color.FromArgb(79, 82, 91);
            lblDifficultyFormula.Location = new Point(259, 47);
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
            panelCaseSensitiveContainer.Location = new Point(113, 46);
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
            comboBoxCaseSensitive.OnSelectedIndexChanged += comboBoxCaseSensitive_OnSelectedIndexChanged;
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Font = new Font("Segoe UI", 10F);
            lblDifficulty.ForeColor = Color.FromArgb(247, 147, 26);
            lblDifficulty.Location = new Point(236, 47);
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
            label2.Location = new Point(176, 47);
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
            panelInputStringContainer.Size = new Size(170, 24);
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
            textBoxTargetString.Size = new Size(150, 18);
            textBoxTargetString.TabIndex = 4;
            textBoxTargetString.TextChanged += textBoxTargetString_TextChanged;
            textBoxTargetString.KeyPress += textBoxTargetString_KeyPress;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(247, 147, 26);
            btnGenerate.BackgroundColor = Color.FromArgb(247, 147, 26);
            btnGenerate.BorderColor = Color.PaleVioletRed;
            btnGenerate.BorderRadius = 12;
            btnGenerate.BorderSize = 0;
            btnGenerate.Enabled = false;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(420, 80);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(71, 24);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Generate";
            btnGenerate.TextColor = Color.White;
            btnGenerate.UseVisualStyleBackColor = false;
            // 
            // lblTargetStringInputError
            // 
            lblTargetStringInputError.AutoSize = true;
            lblTargetStringInputError.Font = new Font("Segoe UI", 10F);
            lblTargetStringInputError.ForeColor = Color.IndianRed;
            lblTargetStringInputError.Location = new Point(223, 542);
            lblTargetStringInputError.Name = "lblTargetStringInputError";
            lblTargetStringInputError.Size = new Size(290, 19);
            lblTargetStringInputError.TabIndex = 9;
            lblTargetStringInputError.Text = "O , I && l (capital o, capital i, lower L) are invalid";
            lblTargetStringInputError.Visible = false;
            // 
            // panelResults
            // 
            panelResults.BackColor = Color.FromArgb(13, 16, 24);
            panelResults.Location = new Point(12, 401);
            panelResults.Name = "panelResults";
            panelResults.Size = new Size(499, 131);
            panelResults.TabIndex = 4;
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.FromArgb(13, 16, 24);
            panelStatus.Location = new Point(12, 239);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(499, 146);
            panelStatus.TabIndex = 4;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new Font("Segoe UI", 10F);
            lblErrorMessage.ForeColor = Color.LightGray;
            lblErrorMessage.Location = new Point(17, 542);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(45, 19);
            lblErrorMessage.TabIndex = 5;
            lblErrorMessage.Text = "label1";
            // 
            // timerTargetStringMessage
            // 
            timerTargetStringMessage.Interval = 5000;
            timerTargetStringMessage.Tick += timerTargetStringMessage_Tick;
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
            btnMoveWindow.Size = new Size(232, 102);
            btnMoveWindow.TabIndex = 10;
            btnMoveWindow.TabStop = false;
            btnMoveWindow.TextColor = Color.FromArgb(13, 16, 24);
            btnMoveWindow.UseVisualStyleBackColor = false;
            btnMoveWindow.Click += BtnMoveWindow_Click;
            btnMoveWindow.MouseDown += BtnMoveWindow_MouseDown;
            btnMoveWindow.MouseUp += BtnMoveWindow_MouseUp;
            // 
            // Bitvain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 31);
            CancelButton = btnExit;
            ClientSize = new Size(525, 574);
            Controls.Add(btnExit);
            Controls.Add(btnMoveWindow);
            Controls.Add(lblTargetStringInputError);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelInputs.ResumeLayout(false);
            panelInputs.PerformLayout();
            panelTargetPositionContainer.ResumeLayout(false);
            panelTargetPositionContainer.PerformLayout();
            panelCaseSensitiveContainer.ResumeLayout(false);
            panelInputStringContainer.ResumeLayout(false);
            panelInputStringContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJButton btnExit;
        private PictureBox pictureBox1;
        private Panel panelInputs;
        private Panel panelResults;
        private Panel panelStatus;
        private Label lblErrorMessage;
        private CustomControls.RJControls.RJButton btnGenerate;
        private Panel panelInputStringContainer;
        private TextBox textBoxTargetString;
        private Label label1;
        private Label label2;
        private Label lblDifficulty;
        private System.Windows.Forms.Timer timerTargetStringMessage;
        private Label lblTargetStringInputError;
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
    }
}
