using System;
using System.Windows.Forms;
using MT_Forms.Common;

namespace MT_Forms
{
    internal partial class Form2 : Form
    {
        internal Form2()
        {
            InitializeComponent();
        }

        private void CaptchaTextBox_TextChanged(object sender, EventArgs e)
        {
            CaptchaProcessing.captcha = captchaTextBox.Text;
        }

        private void EnterCaptchaButton_Click(object sender, EventArgs e)
        {
            new CaptchaProcessing().ProcessingCaptcha();
        }
    }
}
