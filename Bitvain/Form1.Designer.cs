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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitvain));
            pictureBox1 = new PictureBox();
            btnExit = new CustomControls.RJControls.RJButton();
            panelInputs = new Panel();
            label1 = new Label();
            panelInputStringContainer = new Panel();
            textBoxTargetString = new TextBox();
            rjButton1 = new CustomControls.RJControls.RJButton();
            panelResults = new Panel();
            panelStatus = new Panel();
            lblErrorMessage = new Label();
            label2 = new Label();
            lblDifficulty = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelInputs.SuspendLayout();
            panelInputStringContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 91);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
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
            panelInputs.Controls.Add(lblDifficulty);
            panelInputs.Controls.Add(label2);
            panelInputs.Controls.Add(label1);
            panelInputs.Controls.Add(panelInputStringContainer);
            panelInputs.Controls.Add(rjButton1);
            panelInputs.Location = new Point(12, 110);
            panelInputs.Name = "panelInputs";
            panelInputs.Size = new Size(499, 114);
            panelInputs.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 17);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 6;
            label1.Text = "Target string";
            // 
            // panelInputStringContainer
            // 
            panelInputStringContainer.BackColor = Color.FromArgb(24, 27, 36);
            panelInputStringContainer.Controls.Add(textBoxTargetString);
            panelInputStringContainer.Location = new Point(92, 12);
            panelInputStringContainer.Name = "panelInputStringContainer";
            panelInputStringContainer.Size = new Size(120, 24);
            panelInputStringContainer.TabIndex = 5;
            // 
            // textBoxTargetString
            // 
            textBoxTargetString.BackColor = Color.FromArgb(24, 27, 36);
            textBoxTargetString.BorderStyle = BorderStyle.None;
            textBoxTargetString.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTargetString.ForeColor = Color.White;
            textBoxTargetString.Location = new Point(10, 1);
            textBoxTargetString.Name = "textBoxTargetString";
            textBoxTargetString.Size = new Size(100, 22);
            textBoxTargetString.TabIndex = 4;
            textBoxTargetString.KeyDown += textBoxTargetString_KeyDown;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(247, 147, 26);
            rjButton1.BackgroundColor = Color.FromArgb(247, 147, 26);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 12;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.FromArgb(13, 16, 24);
            rjButton1.Location = new Point(419, 78);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(67, 24);
            rjButton1.TabIndex = 3;
            rjButton1.Text = "Generate";
            rjButton1.TextColor = Color.FromArgb(13, 16, 24);
            rjButton1.UseVisualStyleBackColor = false;
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
            lblErrorMessage.ForeColor = Color.White;
            lblErrorMessage.Location = new Point(17, 542);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(38, 15);
            lblErrorMessage.TabIndex = 5;
            lblErrorMessage.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 50);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "Difficulty";
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.ForeColor = Color.FromArgb(247, 147, 26);
            lblDifficulty.Location = new Point(92, 50);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(13, 15);
            lblDifficulty.TabIndex = 8;
            lblDifficulty.Text = "1";
            // 
            // Bitvain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 31);
            CancelButton = btnExit;
            ClientSize = new Size(525, 574);
            Controls.Add(lblErrorMessage);
            Controls.Add(panelResults);
            Controls.Add(panelStatus);
            Controls.Add(panelInputs);
            Controls.Add(btnExit);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Bitvain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bitvain";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelInputs.ResumeLayout(false);
            panelInputs.PerformLayout();
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
        private CustomControls.RJControls.RJButton rjButton1;
        private Panel panelInputStringContainer;
        private TextBox textBoxTargetString;
        private Label label1;
        private Label label2;
        private Label lblDifficulty;
    }
}
