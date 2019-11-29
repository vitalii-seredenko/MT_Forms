namespace MT_Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.goToMTButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.heroNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.toolTipForLabelsAndTextBoxes = new System.Windows.Forms.ToolTip(this.components);
            this.showOrHideLogButton = new System.Windows.Forms.Button();
            this.toolTipForButtons = new System.Windows.Forms.ToolTip(this.components);
            this.loginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // goToMTButton
            // 
            this.goToMTButton.Location = new System.Drawing.Point(31, 68);
            this.goToMTButton.Name = "goToMTButton";
            this.goToMTButton.Size = new System.Drawing.Size(181, 23);
            this.goToMTButton.TabIndex = 1;
            this.goToMTButton.Text = "Войти в Мир Теней";
            this.goToMTButton.UseVisualStyleBackColor = true;
            this.goToMTButton.Click += new System.EventHandler(this.GoToMTButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(117, 16);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(113, 20);
            this.loginTextBox.TabIndex = 2;
            this.toolTipForLabelsAndTextBoxes.SetToolTip(this.loginTextBox, "Введите имя персонажа");
            this.loginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(117, 42);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(113, 20);
            this.passwordTextBox.TabIndex = 5;
            this.toolTipForLabelsAndTextBoxes.SetToolTip(this.passwordTextBox, "Введите пароль");
            this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.heroNameLabel);
            this.loginGroupBox.Controls.Add(this.passwordLabel);
            this.loginGroupBox.Controls.Add(this.exitButton);
            this.loginGroupBox.Controls.Add(this.passwordTextBox);
            this.loginGroupBox.Controls.Add(this.goToMTButton);
            this.loginGroupBox.Controls.Add(this.loginTextBox);
            this.loginGroupBox.Location = new System.Drawing.Point(12, 12);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(241, 128);
            this.loginGroupBox.TabIndex = 6;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Логин";
            // 
            // heroNameLabel
            // 
            this.heroNameLabel.AutoSize = true;
            this.heroNameLabel.Location = new System.Drawing.Point(15, 19);
            this.heroNameLabel.Name = "heroNameLabel";
            this.heroNameLabel.Size = new System.Drawing.Size(88, 13);
            this.heroNameLabel.TabIndex = 11;
            this.heroNameLabel.Text = "Имя персонажа";
            this.toolTipForLabelsAndTextBoxes.SetToolTip(this.heroNameLabel, "Введите имя персонажа");
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(28, 42);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(45, 13);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Пароль";
            this.toolTipForLabelsAndTextBoxes.SetToolTip(this.passwordLabel, "Введите пароль");
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(31, 97);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(181, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // showOrHideLogButton
            // 
            this.showOrHideLogButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.showOrHideLogButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.showOrHideLogButton.Location = new System.Drawing.Point(12, 146);
            this.showOrHideLogButton.Name = "showOrHideLogButton";
            this.showOrHideLogButton.Size = new System.Drawing.Size(240, 23);
            this.showOrHideLogButton.TabIndex = 26;
            this.showOrHideLogButton.Text = "Показать/Скрыть окно лога событий";
            this.showOrHideLogButton.UseVisualStyleBackColor = false;
            this.showOrHideLogButton.Click += new System.EventHandler(this.ShowOrHideLogButton_Click);
            // 
            // toolTipForButtons
            // 
            this.toolTipForButtons.Active = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(264, 176);
            this.Controls.Add(this.showOrHideLogButton);
            this.Controls.Add(this.loginGroupBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "MT_Forms";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.HelpButton_Click);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button goToMTButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label heroNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.ToolTip toolTipForLabelsAndTextBoxes;
        private System.Windows.Forms.Button showOrHideLogButton;
        private System.Windows.Forms.ToolTip toolTipForButtons;
    }
}

