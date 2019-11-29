using MT_Forms.Common;
using System;
using System.Windows.Forms;

namespace MT_Forms
{
    internal partial class CaptchaProcessingForm : Form
    {
        internal CaptchaProcessingForm()
        {
            InitializeComponent();
        }

        private void CaptchaProcessingForm_Load(object sender, EventArgs e)
        {

        }

        private void CaptchaTextBox_TextChanged(object sender, EventArgs e)
        {
            CaptchaProcessing.captcha = captchaTextBox.Text;
        }

        private void EnterCaptchaButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CaptchaProcessing.captcha))
            {
                new CaptchaProcessing().ProcessingCaptcha();
            }
            else
            {
                toolTipForButtons.SetToolTip(enterButton, "Поле капчи не должно быть пустым!");
            }
        }
    }
}
