using System;
using System.Windows.Forms;
using MT_Forms.Common;
using MT_Forms.Core;
using MT_Forms.Core.Logger;
using MT_Forms.LogicForForms;
using MT_Forms.Scripts;

namespace MT_Forms
{
    public partial class MainProgramForm : Form
    {
        public MainProgramForm()
        {
            InitializeComponent();
        }

        internal CheckBox GoForTheCasketCheckBox => goForTheCasketCheckBox;
        internal CheckBox GoForTheCasketAndToEndCheckBox => goForTheCasketAndToEndCheckBox;
        internal RadioButton HardDifficultyRadioButton => hardDifficultyRadioButton;
        internal RadioButton ImpossibleDifficultyRadioButton => impossibleDifficultyRadioButton;
        internal ListBox LogBox => logBox;

        private void VysokayaTemnitsaButton_Click(object sender, EventArgs e)
        {
            new VysokaiaTemnitsa().VysokaiaTemnitsaScript();
        }

        private void GoForTheCasketCheckBox_Click(object sender, EventArgs e)
        {
            goForTheCasketCheckBox.Checked = goForTheCasketCheckBox.CheckState == CheckState.Checked;
            goForTheCasketAndToEndCheckBox.Checked = false;
        }

        private void GoForTheCasketAndToEndCheckBox_Click(object sender, EventArgs e)
        {
            goForTheCasketAndToEndCheckBox.Checked = goForTheCasketAndToEndCheckBox.CheckState == CheckState.Checked;
            goForTheCasketCheckBox.Checked = false;
        }

        private void ShowOrHideCharacterStatsButton_Click(object sender, EventArgs e)
        {
            FormsStorage.characterStatsForm.Show();
            new UserCharacteristic().ShowUserCharacteristicInForm();
        }

        private void ShowOrHideLogButton_Click(object sender, EventArgs e)
        {
            new ChangeSize().ChangeMainFormWidthForShowLog();
        }

        private void ShowLogButton_Click(object sender, EventArgs e)
        {
            Logger.WriteAllLogInLogBox();
        }

        private void ShowInfoLogButton_Click(object sender, EventArgs e)
        {
            Logger.WriteInfoLogInLogBox();
        }

        private void ShowErrorLogButton_Click(object sender, EventArgs e)
        {
            Logger.WriteErrorLogInLogBox();
        }

        private void ShowFatalLogButton_Click(object sender, EventArgs e)
        {
            Logger.WriteFatalLogInLogBox();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            new MyApplication().DisposeDriver();
        }
    }
}
