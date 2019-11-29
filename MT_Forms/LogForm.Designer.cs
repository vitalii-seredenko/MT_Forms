namespace MT_Forms
{
    partial class LogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.showFatalLogButton = new System.Windows.Forms.Button();
            this.showErrorLogButton = new System.Windows.Forms.Button();
            this.showInfoLogButton = new System.Windows.Forms.Button();
            this.showLogButton = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // showFatalLogButton
            // 
            this.showFatalLogButton.Location = new System.Drawing.Point(331, 295);
            this.showFatalLogButton.Name = "showFatalLogButton";
            this.showFatalLogButton.Size = new System.Drawing.Size(95, 23);
            this.showFatalLogButton.TabIndex = 37;
            this.showFatalLogButton.Text = "Только FATAL";
            this.showFatalLogButton.UseVisualStyleBackColor = true;
            this.showFatalLogButton.Click += new System.EventHandler(this.ShowFatalLogButton_Click);
            // 
            // showErrorLogButton
            // 
            this.showErrorLogButton.Location = new System.Drawing.Point(230, 295);
            this.showErrorLogButton.Name = "showErrorLogButton";
            this.showErrorLogButton.Size = new System.Drawing.Size(95, 23);
            this.showErrorLogButton.TabIndex = 36;
            this.showErrorLogButton.Text = "Только ERROR";
            this.showErrorLogButton.UseVisualStyleBackColor = true;
            this.showErrorLogButton.Click += new System.EventHandler(this.ShowErrorLogButton_Click);
            // 
            // showInfoLogButton
            // 
            this.showInfoLogButton.Location = new System.Drawing.Point(129, 295);
            this.showInfoLogButton.Name = "showInfoLogButton";
            this.showInfoLogButton.Size = new System.Drawing.Size(95, 23);
            this.showInfoLogButton.TabIndex = 35;
            this.showInfoLogButton.Text = "Только INFO";
            this.showInfoLogButton.UseVisualStyleBackColor = true;
            this.showInfoLogButton.Click += new System.EventHandler(this.ShowInfoLogButton_Click);
            // 
            // showLogButton
            // 
            this.showLogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.showLogButton.Location = new System.Drawing.Point(12, 295);
            this.showLogButton.Name = "showLogButton";
            this.showLogButton.Size = new System.Drawing.Size(111, 23);
            this.showLogButton.TabIndex = 34;
            this.showLogButton.Text = "Показать весь лог";
            this.showLogButton.UseVisualStyleBackColor = true;
            this.showLogButton.Click += new System.EventHandler(this.ShowLogButton_Click);
            // 
            // logBox
            // 
            this.logBox.FormattingEnabled = true;
            this.logBox.HorizontalScrollbar = true;
            this.logBox.Location = new System.Drawing.Point(12, 12);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(414, 277);
            this.logBox.TabIndex = 33;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(439, 326);
            this.Controls.Add(this.showFatalLogButton);
            this.Controls.Add(this.showErrorLogButton);
            this.Controls.Add(this.showInfoLogButton);
            this.Controls.Add(this.showLogButton);
            this.Controls.Add(this.logBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Program log";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogForm_FormClosed);
            this.Load += new System.EventHandler(this.LogForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showFatalLogButton;
        private System.Windows.Forms.Button showErrorLogButton;
        private System.Windows.Forms.Button showInfoLogButton;
        private System.Windows.Forms.Button showLogButton;
        private System.Windows.Forms.ListBox logBox;
    }
}