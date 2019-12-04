using MT_Forms.Core;
using MT_Forms.Scripts;
using System;
using System.Threading;
using System.Windows.Forms;
using MT_Forms.LogicForCharacters;

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

        private void MainProgramForm_Load(object sender, EventArgs e)
        {

        }

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
            if (!FormsStorage.logForm.Visible)
            {
                var workerThread = new Thread(() => Application.Run(FormsStorage.logForm));
                workerThread.Start();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            new MyApplication().DisposeDriver();
            FormsStorage.mainProgramForm.Dispose();
        }
    }
}