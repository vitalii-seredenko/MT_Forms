using System;
using System.Windows.Forms;
using CommonMethods;
using Scripts;

namespace MT_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new VisokaiaTemnitsa().VisokaiaTemnitsaScript();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new GoToUrl().LoginToMt();
        }
    }
}
