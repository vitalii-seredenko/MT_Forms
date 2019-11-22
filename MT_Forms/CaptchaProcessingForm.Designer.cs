namespace MT_Forms
{
    partial class CaptchaProcessingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptchaProcessingForm));
            this.captchaTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.enterCaptchaLabel = new System.Windows.Forms.Label();
            this.toolTipForLabelsAndTextBoxes = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipForButtons = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // captchaTextBox
            // 
            this.captchaTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.captchaTextBox.Location = new System.Drawing.Point(98, 12);
            this.captchaTextBox.Name = "captchaTextBox";
            this.captchaTextBox.Size = new System.Drawing.Size(143, 20);
            this.captchaTextBox.TabIndex = 0;
            this.toolTipForLabelsAndTextBoxes.SetToolTip(this.captchaTextBox, "Введите капчу");
            this.captchaTextBox.TextChanged += new System.EventHandler(this.CaptchaTextBox_TextChanged);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(12, 38);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(229, 22);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Войти";
            this.enterButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.EnterCaptchaButton_Click);
            // 
            // enterCaptchaLabel
            // 
            this.enterCaptchaLabel.AutoSize = true;
            this.enterCaptchaLabel.Location = new System.Drawing.Point(12, 15);
            this.enterCaptchaLabel.Name = "enterCaptchaLabel";
            this.enterCaptchaLabel.Size = new System.Drawing.Size(80, 13);
            this.enterCaptchaLabel.TabIndex = 7;
            this.enterCaptchaLabel.Text = "Введите капчу";
            // 
            // toolTipForButtons
            // 
            this.toolTipForButtons.Active = false;
            // 
            // CaptchaProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 69);
            this.Controls.Add(this.enterCaptchaLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.captchaTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaptchaProcessingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MT_Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox captchaTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label enterCaptchaLabel;
        private System.Windows.Forms.ToolTip toolTipForLabelsAndTextBoxes;
        private System.Windows.Forms.ToolTip toolTipForButtons;
    }
}