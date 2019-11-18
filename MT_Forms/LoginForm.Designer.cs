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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.button1 = new System.Windows.Forms.Button();
            this.goToMTButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.goForTheCasketCheckBox = new System.Windows.Forms.CheckBox();
            this.goForTheCasketAndToEndCheckBox = new System.Windows.Forms.CheckBox();
            this.normalDifficultyRadioButton = new System.Windows.Forms.RadioButton();
            this.hardDifficultyRadioButton = new System.Windows.Forms.RadioButton();
            this.impossibleDifficultyRadioButton = new System.Windows.Forms.RadioButton();
            this.difficultyCheckBoxesGroupBox = new System.Windows.Forms.GroupBox();
            this.logBox = new System.Windows.Forms.ListBox();
            this.showOrHideLogButton = new System.Windows.Forms.Button();
            this.showLogButton = new System.Windows.Forms.Button();
            this.showInfoLogButton = new System.Windows.Forms.Button();
            this.showErrorLogButton = new System.Windows.Forms.Button();
            this.showFatalLogButton = new System.Windows.Forms.Button();
            this.showOrHideCharacterStatsButton = new System.Windows.Forms.Button();
            this.loginGroupBox.SuspendLayout();
            this.difficultyCheckBoxesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Пройти \"Высокая Темница\"";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.VysokayaTemnitsaButton_Click);
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
            this.loginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(117, 42);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(113, 20);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.label3);
            this.loginGroupBox.Controls.Add(this.label2);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Имя персонажа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пароль";
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
            // goForTheCasketCheckBox
            // 
            this.goForTheCasketCheckBox.AutoSize = true;
            this.goForTheCasketCheckBox.Location = new System.Drawing.Point(128, 204);
            this.goForTheCasketCheckBox.Name = "goForTheCasketCheckBox";
            this.goForTheCasketCheckBox.Size = new System.Drawing.Size(132, 30);
            this.goForTheCasketCheckBox.TabIndex = 7;
            this.goForTheCasketCheckBox.Text = "Взять квест и пойти \r\nза шкатулкой";
            this.goForTheCasketCheckBox.UseVisualStyleBackColor = true;
            this.goForTheCasketCheckBox.Click += new System.EventHandler(this.GoForTheCasketCheckBox_Click);
            // 
            // goForTheCasketAndToEndCheckBox
            // 
            this.goForTheCasketAndToEndCheckBox.AutoSize = true;
            this.goForTheCasketAndToEndCheckBox.Location = new System.Drawing.Point(128, 237);
            this.goForTheCasketAndToEndCheckBox.Name = "goForTheCasketAndToEndCheckBox";
            this.goForTheCasketAndToEndCheckBox.Size = new System.Drawing.Size(129, 43);
            this.goForTheCasketAndToEndCheckBox.TabIndex = 8;
            this.goForTheCasketAndToEndCheckBox.Text = "Взять квест и\r\nпройти подземелье \r\nполностью";
            this.goForTheCasketAndToEndCheckBox.UseVisualStyleBackColor = true;
            this.goForTheCasketAndToEndCheckBox.Click += new System.EventHandler(this.GoForTheCasketAndToEndCheckBox_Click);
            // 
            // normalDifficultyRadioButton
            // 
            this.normalDifficultyRadioButton.AutoSize = true;
            this.normalDifficultyRadioButton.Checked = true;
            this.normalDifficultyRadioButton.Location = new System.Drawing.Point(6, 19);
            this.normalDifficultyRadioButton.Name = "normalDifficultyRadioButton";
            this.normalDifficultyRadioButton.Size = new System.Drawing.Size(59, 17);
            this.normalDifficultyRadioButton.TabIndex = 10;
            this.normalDifficultyRadioButton.TabStop = true;
            this.normalDifficultyRadioButton.Text = "Норма";
            this.normalDifficultyRadioButton.UseVisualStyleBackColor = true;
            // 
            // hardDifficultyRadioButton
            // 
            this.hardDifficultyRadioButton.AutoSize = true;
            this.hardDifficultyRadioButton.Location = new System.Drawing.Point(95, 19);
            this.hardDifficultyRadioButton.Name = "hardDifficultyRadioButton";
            this.hardDifficultyRadioButton.Size = new System.Drawing.Size(55, 17);
            this.hardDifficultyRadioButton.TabIndex = 11;
            this.hardDifficultyRadioButton.TabStop = true;
            this.hardDifficultyRadioButton.Text = "Герой";
            this.hardDifficultyRadioButton.UseVisualStyleBackColor = true;
            // 
            // impossibleDifficultyRadioButton
            // 
            this.impossibleDifficultyRadioButton.AutoSize = true;
            this.impossibleDifficultyRadioButton.Location = new System.Drawing.Point(175, 19);
            this.impossibleDifficultyRadioButton.Name = "impossibleDifficultyRadioButton";
            this.impossibleDifficultyRadioButton.Size = new System.Drawing.Size(60, 17);
            this.impossibleDifficultyRadioButton.TabIndex = 12;
            this.impossibleDifficultyRadioButton.TabStop = true;
            this.impossibleDifficultyRadioButton.Text = "Брутал";
            this.impossibleDifficultyRadioButton.UseVisualStyleBackColor = true;
            // 
            // difficultyCheckBoxesGroupBox
            // 
            this.difficultyCheckBoxesGroupBox.Controls.Add(this.impossibleDifficultyRadioButton);
            this.difficultyCheckBoxesGroupBox.Controls.Add(this.normalDifficultyRadioButton);
            this.difficultyCheckBoxesGroupBox.Controls.Add(this.hardDifficultyRadioButton);
            this.difficultyCheckBoxesGroupBox.Location = new System.Drawing.Point(12, 146);
            this.difficultyCheckBoxesGroupBox.Name = "difficultyCheckBoxesGroupBox";
            this.difficultyCheckBoxesGroupBox.Size = new System.Drawing.Size(241, 44);
            this.difficultyCheckBoxesGroupBox.TabIndex = 13;
            this.difficultyCheckBoxesGroupBox.TabStop = false;
            this.difficultyCheckBoxesGroupBox.Text = "Сложность подземелий";
            // 
            // logBox
            // 
            this.logBox.FormattingEnabled = true;
            this.logBox.HorizontalScrollbar = true;
            this.logBox.Location = new System.Drawing.Point(275, 12);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(398, 277);
            this.logBox.TabIndex = 14;
            // 
            // showOrHideLogButton
            // 
            this.showOrHideLogButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.showOrHideLogButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.showOrHideLogButton.Location = new System.Drawing.Point(13, 323);
            this.showOrHideLogButton.Name = "showOrHideLogButton";
            this.showOrHideLogButton.Size = new System.Drawing.Size(240, 26);
            this.showOrHideLogButton.TabIndex = 15;
            this.showOrHideLogButton.Text = "Показать/Скрыть окно лога событий";
            this.showOrHideLogButton.UseVisualStyleBackColor = false;
            this.showOrHideLogButton.Click += new System.EventHandler(this.ShowOrHideLogButton_Click);
            // 
            // showLogButton
            // 
            this.showLogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.showLogButton.Location = new System.Drawing.Point(275, 295);
            this.showLogButton.Name = "showLogButton";
            this.showLogButton.Size = new System.Drawing.Size(95, 23);
            this.showLogButton.TabIndex = 16;
            this.showLogButton.Text = "Показать весь лог";
            this.showLogButton.UseVisualStyleBackColor = true;
            this.showLogButton.Click += new System.EventHandler(this.ShowLogButton_Click);
            // 
            // showInfoLogButton
            // 
            this.showInfoLogButton.Location = new System.Drawing.Point(376, 295);
            this.showInfoLogButton.Name = "showInfoLogButton";
            this.showInfoLogButton.Size = new System.Drawing.Size(95, 23);
            this.showInfoLogButton.TabIndex = 17;
            this.showInfoLogButton.Text = "Только INFO";
            this.showInfoLogButton.UseVisualStyleBackColor = true;
            this.showInfoLogButton.Click += new System.EventHandler(this.ShowInfoLogButton_Click);
            // 
            // showErrorLogButton
            // 
            this.showErrorLogButton.Location = new System.Drawing.Point(477, 295);
            this.showErrorLogButton.Name = "showErrorLogButton";
            this.showErrorLogButton.Size = new System.Drawing.Size(95, 23);
            this.showErrorLogButton.TabIndex = 18;
            this.showErrorLogButton.Text = "Только ERROR";
            this.showErrorLogButton.UseVisualStyleBackColor = true;
            this.showErrorLogButton.Click += new System.EventHandler(this.ShowErrorLogButton_Click);
            // 
            // showFatalLogButton
            // 
            this.showFatalLogButton.Location = new System.Drawing.Point(578, 295);
            this.showFatalLogButton.Name = "showFatalLogButton";
            this.showFatalLogButton.Size = new System.Drawing.Size(95, 23);
            this.showFatalLogButton.TabIndex = 19;
            this.showFatalLogButton.Text = "Только FATAL";
            this.showFatalLogButton.UseVisualStyleBackColor = true;
            this.showFatalLogButton.Click += new System.EventHandler(this.ShowFatalLogButton_Click);
            // 
            // showOrHideCharacterStatsButton
            // 
            this.showOrHideCharacterStatsButton.Location = new System.Drawing.Point(13, 294);
            this.showOrHideCharacterStatsButton.Name = "showOrHideCharacterStatsButton";
            this.showOrHideCharacterStatsButton.Size = new System.Drawing.Size(239, 23);
            this.showOrHideCharacterStatsButton.TabIndex = 20;
            this.showOrHideCharacterStatsButton.Text = "Показать характеристики персонажа";
            this.showOrHideCharacterStatsButton.UseVisualStyleBackColor = true;
            this.showOrHideCharacterStatsButton.Click += new System.EventHandler(this.ShowOrHideCharacterStatsButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(713, 356);
            this.Controls.Add(this.showOrHideCharacterStatsButton);
            this.Controls.Add(this.showFatalLogButton);
            this.Controls.Add(this.showErrorLogButton);
            this.Controls.Add(this.showInfoLogButton);
            this.Controls.Add(this.showLogButton);
            this.Controls.Add(this.showOrHideLogButton);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.difficultyCheckBoxesGroupBox);
            this.Controls.Add(this.goForTheCasketAndToEndCheckBox);
            this.Controls.Add(this.goForTheCasketCheckBox);
            this.Controls.Add(this.loginGroupBox);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.difficultyCheckBoxesGroupBox.ResumeLayout(false);
            this.difficultyCheckBoxesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button goToMTButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.CheckBox goForTheCasketCheckBox;
        private System.Windows.Forms.CheckBox goForTheCasketAndToEndCheckBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton normalDifficultyRadioButton;
        private System.Windows.Forms.RadioButton hardDifficultyRadioButton;
        private System.Windows.Forms.RadioButton impossibleDifficultyRadioButton;
        private System.Windows.Forms.GroupBox difficultyCheckBoxesGroupBox;
        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.Button showOrHideLogButton;
        private System.Windows.Forms.Button showLogButton;
        private System.Windows.Forms.Button showInfoLogButton;
        private System.Windows.Forms.Button showErrorLogButton;
        private System.Windows.Forms.Button showFatalLogButton;
        private System.Windows.Forms.Button showOrHideCharacterStatsButton;
    }
}

