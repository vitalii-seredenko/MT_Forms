using System;
using System.Windows.Forms;
using MT_Forms.Common;
using MT_Forms.LogicForForms;
using MT_Forms.Scripts;

namespace MT_Forms
{
    internal partial class Form1 : Form
    {
        internal Form1()
        {
            InitializeComponent();
        }

        internal CheckBox GoForTheCasketCheckBox => goForTheCasketCheckBox;
        internal CheckBox GoForTheCasketAndToEndCheckBox => goForTheCasketAndToEndCheckBox;
        internal RadioButton HardDifficultyRadioButton => hardDifficultyRadioButton;
        internal RadioButton ImpossibleDifficultyRadioButton => impossibleDifficultyRadioButton;
        internal ListBox LogBox => logBox;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            Login.loginName = loginTextBox.Text;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            Login.password = passwordTextBox.Text;
        }

        private void GoToMTButton_Click(object sender, EventArgs e)
        {
            new Login().GoToMt();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            new Core.Application().DisposeDriver();
        }

        private void VisokayaTemnitsaButton_Click(object sender, EventArgs e)
        {
            new VysokaiaTemnitsa().VysokaiaTemnitsaScript();
        }

        private void goForTheCasketCheckBox_Click(object sender, EventArgs e)
        {
            goForTheCasketCheckBox.Checked = goForTheCasketCheckBox.CheckState == CheckState.Checked;
            goForTheCasketAndToEndCheckBox.Checked = false;
        }

        private void goForTheCasketAndToEndCheckBox_Click(object sender, EventArgs e)
        {
            goForTheCasketAndToEndCheckBox.Checked = goForTheCasketAndToEndCheckBox.CheckState == CheckState.Checked;
            goForTheCasketCheckBox.Checked = false;
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            new ChangeSize().ChangeForm1Width();
        }
    }
}
