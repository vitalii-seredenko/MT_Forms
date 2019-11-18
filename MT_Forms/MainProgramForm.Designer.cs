namespace MT_Forms
{
    partial class MainProgramForm
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
            this.showOrHideCharacterStatsButton = new System.Windows.Forms.Button();
            this.showOrHideLogButton = new System.Windows.Forms.Button();
            this.difficultyCheckBoxesGroupBox = new System.Windows.Forms.GroupBox();
            this.impossibleDifficultyRadioButton = new System.Windows.Forms.RadioButton();
            this.normalDifficultyRadioButton = new System.Windows.Forms.RadioButton();
            this.hardDifficultyRadioButton = new System.Windows.Forms.RadioButton();
            this.goForTheCasketAndToEndCheckBox = new System.Windows.Forms.CheckBox();
            this.goForTheCasketCheckBox = new System.Windows.Forms.CheckBox();
            this.VysokayaTemnitsaButton = new System.Windows.Forms.Button();
            this.showFatalLogButton = new System.Windows.Forms.Button();
            this.showErrorLogButton = new System.Windows.Forms.Button();
            this.showInfoLogButton = new System.Windows.Forms.Button();
            this.showLogButton = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.ListBox();
            this.difficultyCheckBoxesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // showOrHideCharacterStatsButton
            // 
            this.showOrHideCharacterStatsButton.Location = new System.Drawing.Point(13, 160);
            this.showOrHideCharacterStatsButton.Name = "showOrHideCharacterStatsButton";
            this.showOrHideCharacterStatsButton.Size = new System.Drawing.Size(239, 23);
            this.showOrHideCharacterStatsButton.TabIndex = 26;
            this.showOrHideCharacterStatsButton.Text = "Показать характеристики персонажа";
            this.showOrHideCharacterStatsButton.UseVisualStyleBackColor = true;
            this.showOrHideCharacterStatsButton.Click += new System.EventHandler(this.ShowOrHideCharacterStatsButton_Click);
            // 
            // showOrHideLogButton
            // 
            this.showOrHideLogButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.showOrHideLogButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.showOrHideLogButton.Location = new System.Drawing.Point(13, 189);
            this.showOrHideLogButton.Name = "showOrHideLogButton";
            this.showOrHideLogButton.Size = new System.Drawing.Size(240, 26);
            this.showOrHideLogButton.TabIndex = 25;
            this.showOrHideLogButton.Text = "Показать/Скрыть окно лога событий";
            this.showOrHideLogButton.UseVisualStyleBackColor = false;
            this.showOrHideLogButton.Click += new System.EventHandler(this.ShowOrHideLogButton_Click);
            // 
            // difficultyCheckBoxesGroupBox
            // 
            this.difficultyCheckBoxesGroupBox.Controls.Add(this.impossibleDifficultyRadioButton);
            this.difficultyCheckBoxesGroupBox.Controls.Add(this.normalDifficultyRadioButton);
            this.difficultyCheckBoxesGroupBox.Controls.Add(this.hardDifficultyRadioButton);
            this.difficultyCheckBoxesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.difficultyCheckBoxesGroupBox.Name = "difficultyCheckBoxesGroupBox";
            this.difficultyCheckBoxesGroupBox.Size = new System.Drawing.Size(241, 44);
            this.difficultyCheckBoxesGroupBox.TabIndex = 24;
            this.difficultyCheckBoxesGroupBox.TabStop = false;
            this.difficultyCheckBoxesGroupBox.Text = "Сложность подземелий";
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
            // goForTheCasketAndToEndCheckBox
            // 
            this.goForTheCasketAndToEndCheckBox.AutoSize = true;
            this.goForTheCasketAndToEndCheckBox.Location = new System.Drawing.Point(128, 103);
            this.goForTheCasketAndToEndCheckBox.Name = "goForTheCasketAndToEndCheckBox";
            this.goForTheCasketAndToEndCheckBox.Size = new System.Drawing.Size(129, 43);
            this.goForTheCasketAndToEndCheckBox.TabIndex = 23;
            this.goForTheCasketAndToEndCheckBox.Text = "Взять квест и\r\nпройти подземелье \r\nполностью";
            this.goForTheCasketAndToEndCheckBox.UseVisualStyleBackColor = true;
            this.goForTheCasketAndToEndCheckBox.Click += new System.EventHandler(this.GoForTheCasketAndToEndCheckBox_Click);
            // 
            // goForTheCasketCheckBox
            // 
            this.goForTheCasketCheckBox.AutoSize = true;
            this.goForTheCasketCheckBox.Location = new System.Drawing.Point(128, 70);
            this.goForTheCasketCheckBox.Name = "goForTheCasketCheckBox";
            this.goForTheCasketCheckBox.Size = new System.Drawing.Size(132, 30);
            this.goForTheCasketCheckBox.TabIndex = 22;
            this.goForTheCasketCheckBox.Text = "Взять квест и пойти \r\nза шкатулкой";
            this.goForTheCasketCheckBox.UseVisualStyleBackColor = true;
            this.goForTheCasketCheckBox.Click += new System.EventHandler(this.GoForTheCasketCheckBox_Click);
            // 
            // VysokayaTemnitsaButton
            // 
            this.VysokayaTemnitsaButton.Location = new System.Drawing.Point(12, 62);
            this.VysokayaTemnitsaButton.Name = "VysokayaTemnitsaButton";
            this.VysokayaTemnitsaButton.Size = new System.Drawing.Size(106, 84);
            this.VysokayaTemnitsaButton.TabIndex = 21;
            this.VysokayaTemnitsaButton.Text = "Пройти \"Высокая Темница\"";
            this.VysokayaTemnitsaButton.UseVisualStyleBackColor = true;
            this.VysokayaTemnitsaButton.Click += new System.EventHandler(this.VysokayaTemnitsaButton_Click);
            // 
            // showFatalLogButton
            // 
            this.showFatalLogButton.Location = new System.Drawing.Point(569, 295);
            this.showFatalLogButton.Name = "showFatalLogButton";
            this.showFatalLogButton.Size = new System.Drawing.Size(95, 23);
            this.showFatalLogButton.TabIndex = 31;
            this.showFatalLogButton.Text = "Только FATAL";
            this.showFatalLogButton.UseVisualStyleBackColor = true;
            this.showFatalLogButton.Click += new System.EventHandler(this.ShowFatalLogButton_Click);
            // 
            // showErrorLogButton
            // 
            this.showErrorLogButton.Location = new System.Drawing.Point(468, 295);
            this.showErrorLogButton.Name = "showErrorLogButton";
            this.showErrorLogButton.Size = new System.Drawing.Size(95, 23);
            this.showErrorLogButton.TabIndex = 30;
            this.showErrorLogButton.Text = "Только ERROR";
            this.showErrorLogButton.UseVisualStyleBackColor = true;
            this.showErrorLogButton.Click += new System.EventHandler(this.ShowErrorLogButton_Click);
            // 
            // showInfoLogButton
            // 
            this.showInfoLogButton.Location = new System.Drawing.Point(367, 295);
            this.showInfoLogButton.Name = "showInfoLogButton";
            this.showInfoLogButton.Size = new System.Drawing.Size(95, 23);
            this.showInfoLogButton.TabIndex = 29;
            this.showInfoLogButton.Text = "Только INFO";
            this.showInfoLogButton.UseVisualStyleBackColor = true;
            this.showInfoLogButton.Click += new System.EventHandler(this.ShowInfoLogButton_Click);
            // 
            // showLogButton
            // 
            this.showLogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.showLogButton.Location = new System.Drawing.Point(266, 295);
            this.showLogButton.Name = "showLogButton";
            this.showLogButton.Size = new System.Drawing.Size(95, 23);
            this.showLogButton.TabIndex = 28;
            this.showLogButton.Text = "Показать весь лог";
            this.showLogButton.UseVisualStyleBackColor = true;
            this.showLogButton.Click += new System.EventHandler(this.ShowLogButton_Click);
            // 
            // logBox
            // 
            this.logBox.FormattingEnabled = true;
            this.logBox.HorizontalScrollbar = true;
            this.logBox.Location = new System.Drawing.Point(266, 12);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(398, 277);
            this.logBox.TabIndex = 27;
            // 
            // MainProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 331);
            this.Controls.Add(this.showFatalLogButton);
            this.Controls.Add(this.showErrorLogButton);
            this.Controls.Add(this.showInfoLogButton);
            this.Controls.Add(this.showLogButton);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.showOrHideCharacterStatsButton);
            this.Controls.Add(this.showOrHideLogButton);
            this.Controls.Add(this.difficultyCheckBoxesGroupBox);
            this.Controls.Add(this.goForTheCasketAndToEndCheckBox);
            this.Controls.Add(this.goForTheCasketCheckBox);
            this.Controls.Add(this.VysokayaTemnitsaButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainProgramForm";
            this.ShowIcon = false;
            this.difficultyCheckBoxesGroupBox.ResumeLayout(false);
            this.difficultyCheckBoxesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showOrHideCharacterStatsButton;
        private System.Windows.Forms.Button showOrHideLogButton;
        private System.Windows.Forms.GroupBox difficultyCheckBoxesGroupBox;
        private System.Windows.Forms.RadioButton impossibleDifficultyRadioButton;
        private System.Windows.Forms.RadioButton normalDifficultyRadioButton;
        private System.Windows.Forms.RadioButton hardDifficultyRadioButton;
        private System.Windows.Forms.CheckBox goForTheCasketAndToEndCheckBox;
        private System.Windows.Forms.CheckBox goForTheCasketCheckBox;
        private System.Windows.Forms.Button VysokayaTemnitsaButton;
        private System.Windows.Forms.Button showFatalLogButton;
        private System.Windows.Forms.Button showErrorLogButton;
        private System.Windows.Forms.Button showInfoLogButton;
        private System.Windows.Forms.Button showLogButton;
        private System.Windows.Forms.ListBox logBox;
    }
}