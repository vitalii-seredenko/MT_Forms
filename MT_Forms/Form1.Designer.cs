namespace MT_Forms
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.goForTheCasketCheckBox = new System.Windows.Forms.CheckBox();
            this.goForTheCasketAndToEndCheckBox = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.LoginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Пройти \"Высокая Темница\"";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.VisokayaTemnitsaButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Войти в Мир Теней";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GoToMTButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(117, 16);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(113, 20);
            this.loginTextBox.TabIndex = 2;
            this.loginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Имя персонажа ";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(6, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox3.Size = new System.Drawing.Size(100, 13);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Пароль";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // LoginGroupBox
            // 
            this.LoginGroupBox.Controls.Add(this.button3);
            this.LoginGroupBox.Controls.Add(this.textBox2);
            this.LoginGroupBox.Controls.Add(this.passwordTextBox);
            this.LoginGroupBox.Controls.Add(this.button2);
            this.LoginGroupBox.Controls.Add(this.textBox3);
            this.LoginGroupBox.Controls.Add(this.loginTextBox);
            this.LoginGroupBox.Location = new System.Drawing.Point(12, 12);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(234, 128);
            this.LoginGroupBox.TabIndex = 6;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "Логин";
            // 
            // goForTheCasketCheckBox
            // 
            this.goForTheCasketCheckBox.AutoSize = true;
            this.goForTheCasketCheckBox.Location = new System.Drawing.Point(129, 151);
            this.goForTheCasketCheckBox.Name = "goForTheCasketCheckBox";
            this.goForTheCasketCheckBox.Size = new System.Drawing.Size(132, 30);
            this.goForTheCasketCheckBox.TabIndex = 7;
            this.goForTheCasketCheckBox.Text = "Взять квест и пойти \r\nза шкатулкой";
            this.goForTheCasketCheckBox.UseVisualStyleBackColor = true;
            this.goForTheCasketCheckBox.Click += new System.EventHandler(this.goForTheCasketCheckBox_Click);
            // 
            // goForTheCasketAndToEndCheckBox
            // 
            this.goForTheCasketAndToEndCheckBox.AutoSize = true;
            this.goForTheCasketAndToEndCheckBox.Location = new System.Drawing.Point(129, 162);
            this.goForTheCasketAndToEndCheckBox.Name = "goForTheCasketAndToEndCheckBox";
            this.goForTheCasketAndToEndCheckBox.Size = new System.Drawing.Size(129, 43);
            this.goForTheCasketAndToEndCheckBox.TabIndex = 8;
            this.goForTheCasketAndToEndCheckBox.Text = "Взять квест и\r\nпройти подземелье \r\nполностью";
            this.goForTheCasketAndToEndCheckBox.UseVisualStyleBackColor = true;
            this.goForTheCasketAndToEndCheckBox.Click += new System.EventHandler(this.goForTheCasketAndToEndCheckBox_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 229);
            this.Controls.Add(this.goForTheCasketAndToEndCheckBox);
            this.Controls.Add(this.goForTheCasketCheckBox);
            this.Controls.Add(this.LoginGroupBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.CheckBox goForTheCasketCheckBox;
        private System.Windows.Forms.CheckBox goForTheCasketAndToEndCheckBox;
        private System.Windows.Forms.Button button3;
    }
}

