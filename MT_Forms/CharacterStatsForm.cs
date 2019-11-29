using MT_Forms.Core;
using System;
using System.Windows.Forms;

namespace MT_Forms
{
    public partial class CharacterStatsForm : Form
    {
        internal Label HealLabel => healthLabel;
        internal Label StrangeLabel => strangeLabel;
        internal Label CriticalDamageLevel => criticalDamageLevel;
        internal Label ProtectionLabel => protectionLabel;
        internal Label BlackMagicProtectionLabel => blackMagicProtectionLabel;
        internal Label RegenerationLabel => regenerationLabel;
        internal Label AmuletLabel1 => amuletLabel1;
        internal Label AmuletLabel2 => amuletLabel2;
        internal Label AmuletLabel3 => amuletLabel3;
        internal Label AmuletLabel4 => amuletLabel4;
        internal Label AmuletLabel5 => amuletLabel5;
        internal Label AmuletLabel6 => amuletLabel6;
        internal Label AmuletLabel7 => amuletLabel7;
        internal Label AmuletLabel8 => amuletLabel8;

        public CharacterStatsForm()
        {
            InitializeComponent();
        }

        private void CharacterStatsForm_Load(object sender, EventArgs e)
        {

        }

        private void CharacterStatsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormsStorage.characterStatsForm = new CharacterStatsForm();
        }
    }
}
