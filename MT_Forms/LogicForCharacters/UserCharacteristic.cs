using System.Windows.Forms;
using MT_Forms.Core;
using MT_Forms.Extensions;
using MT_Forms.PageObjects.WebPages;

namespace MT_Forms.LogicForCharacters
{
    internal class UserCharacteristic
    {
        internal static Character hero = new Character();
        private readonly CharacterPage _characterPage;
        private readonly CharacterStatsForm _characterStatsForm;

        internal UserCharacteristic()
        {
            _characterPage = new CharacterPage();
            _characterStatsForm = FormsStorage.characterStatsForm;
        }

        internal void GetUser()
        {
            new BaseTownPage().characterButton.WaitElementAndClick();
            switch (hero.HeroClass = _characterPage.characterClassTextBox.WaitElement().Text)
            {
                case "Маг":
                    hero = new Magician(_characterPage.characterHealthTextBox.Text, _characterPage.characterStrangeTextBox.Text, _characterPage.characterProtectionTextBox.Text, _characterPage.characterCriticalDamageTextBox.Text, _characterPage.characterBlackMagicProtectionTextBox.ReturnElementTextIfElementPresent(), _characterPage.characterRegenerationTextBox.Text, _characterPage.vzryvEfiraLevelTextBox.CutLettersFromTextBox(), _characterPage.pritokSilyLevelTextBox.CutLettersFromTextBox(), _characterPage.sferyArcanyLevelTextBox.CutLettersFromTextBox(), _characterPage.gromMolniaLevelTextBox.CutLettersFromTextBox(), _characterPage.tenSmertiLevelTextBox.CutLettersFromTextBox(), _characterPage.nevidimostLevelTextBox.CutLettersFromTextBox(), _characterPage.prizyvLevelTextBox.CutLettersFromTextBox(), _characterPage.ledianoiUdarLevelTextBox.CutLettersFromTextBox());
                    break;
                case "Воин":
                    hero = new Warrior(_characterPage.characterHealthTextBox.Text, _characterPage.characterStrangeTextBox.Text, _characterPage.characterProtectionTextBox.Text, _characterPage.characterCriticalDamageTextBox.Text, _characterPage.characterBlackMagicProtectionTextBox.ReturnElementTextIfElementPresent(), _characterPage.characterRegenerationTextBox.Text, _characterPage.zaschitaBogovLevelTextBox.CutLettersFromTextBox(), _characterPage.iarostBogovLevelTextBox.CutLettersFromTextBox(), _characterPage.ryvokZhizniLevelTextBox.CutLettersFromTextBox(), _characterPage.gromMolniaLevelTextBox.CutLettersFromTextBox(), _characterPage.talismanDoblestiLevelTextBox.CutLettersFromTextBox(), _characterPage.nevidimostLevelTextBox.CutLettersFromTextBox(), _characterPage.prizyvLevelTextBox.CutLettersFromTextBox(), _characterPage.ledianoiUdarLevelTextBox.CutLettersFromTextBox());
                    break;
                case "Монах":
                    hero = new Monk(_characterPage.characterHealthTextBox.Text, _characterPage.characterStrangeTextBox.Text, _characterPage.characterProtectionTextBox.Text, _characterPage.characterCriticalDamageTextBox.Text, _characterPage.characterBlackMagicProtectionTextBox.ReturnElementTextIfElementPresent(), _characterPage.characterRegenerationTextBox.Text, _characterPage.listokLotosaLevelTextBox.CutLettersFromTextBox(), _characterPage.formaDemonaLevelTextBox.CutLettersFromTextBox(), _characterPage.procliatieGlaivaLevelTextBox.CutLettersFromTextBox(), _characterPage.gromMolniaLevelTextBox.CutLettersFromTextBox(), _characterPage.krovaviiTsvetokLevelTextBox.CutLettersFromTextBox(), _characterPage.nevidimostLevelTextBox.CutLettersFromTextBox(), _characterPage.prizyvLevelTextBox.CutLettersFromTextBox(), _characterPage.ledianoiUdarLevelTextBox.CutLettersFromTextBox());
                    break;
            }
        }

        internal void ShowUserCharacteristicInForm()
        {
            _characterStatsForm.HealLabel.Text = $@"Живучесть: {hero.Health}";
            _characterStatsForm.StrangeLabel.Text = $@"Сила: {hero.Strange}";
            _characterStatsForm.CriticalDamageLevel.Text = $@"Крит: {hero.CriticalDamage}";
            _characterStatsForm.ProtectionLabel.Text = $@"Защита: {hero.Protection}";
            _characterStatsForm.BlackMagicProtectionLabel.Text = $@"Защита от чёрной магии: {hero.BlackMagicProtection}";
            _characterStatsForm.RegenerationLabel.Text = $@"Регенерация: {hero.Regeneration}";

            switch (hero.HeroClass)
            {
                case "Маг":
                    _characterStatsForm.AmuletLabel1.Text = $@"{((Magician)hero).VzryvEfira.Item1} ({((Magician)hero).VzryvEfira.Item2} ур.)";
                    _characterStatsForm.AmuletLabel2.Text = $@"{((Magician)hero).SferyArcany.Item1} ({((Magician)hero).SferyArcany.Item2} ур.)";
                    _characterStatsForm.AmuletLabel3.Text = $@"{((Magician)hero).PritokSily.Item1} ({((Magician)hero).PritokSily.Item2} ур.)";
                    _characterStatsForm.AmuletLabel4.Text = $@"{((Magician)hero).TenSmerti.Item1} ({((Magician)hero).TenSmerti.Item2} ур.)";
                    _characterStatsForm.AmuletLabel5.Text = $@"{((Magician)hero).GromMolnia.Item1} ({((Magician)hero).GromMolnia.Item2} ур.)";
                    _characterStatsForm.AmuletLabel6.Text = $@"{((Magician)hero).Prizyv.Item1} ({((Magician)hero).Prizyv.Item2} ур.)";
                    _characterStatsForm.AmuletLabel7.Text = $@"{((Magician)hero).LedianoiUdar.Item1} ({((Magician)hero).LedianoiUdar.Item2} ур.)";
                    _characterStatsForm.AmuletLabel8.Text = $@"{((Magician)hero).Nevidimost.Item1} ({((Magician)hero).Nevidimost.Item2} ур.)";
                    break;
                case "Воин":
                    _characterStatsForm.AmuletLabel1.Text = $@"{((Warrior)hero).ZaschitaBogov.Item1} ({((Warrior)hero).ZaschitaBogov.Item2} ур.)";
                    _characterStatsForm.AmuletLabel2.Text = $@"{((Warrior)hero).RyvokZhizni.Item1} ({((Warrior)hero).RyvokZhizni.Item2} ур.)";
                    _characterStatsForm.AmuletLabel3.Text = $@"{((Warrior)hero).IarostBogov.Item1} ({((Warrior)hero).IarostBogov.Item2} ур.)";
                    _characterStatsForm.AmuletLabel4.Text = $@"{((Warrior)hero).TalismanDoblesti.Item1} ({((Warrior)hero).TalismanDoblesti.Item2} ур.)";
                    _characterStatsForm.AmuletLabel5.Text = $@"{((Warrior)hero).GromMolnia.Item1} ({((Warrior)hero).GromMolnia.Item2} ур.)";
                    _characterStatsForm.AmuletLabel6.Text = $@"{((Warrior)hero).Prizyv.Item1} ({((Warrior)hero).Prizyv.Item2} ур.)";
                    _characterStatsForm.AmuletLabel7.Text = $@"{((Warrior)hero).LedianoiUdar.Item1} ({((Warrior)hero).LedianoiUdar.Item2} ур.)";
                    _characterStatsForm.AmuletLabel8.Text = $@"{((Warrior)hero).Nevidimost.Item1} ({((Warrior)hero).Nevidimost.Item2} ур.)";
                    break;
                case "Монах":
                    _characterStatsForm.AmuletLabel1.Text = $@"{((Monk)hero).ListokLotosa.Item1} ({((Monk)hero).ListokLotosa.Item2} ур.)";
                    _characterStatsForm.AmuletLabel2.Text = $@"{((Monk)hero).ProcliatieGlaiva.Item1} ({((Monk)hero).ProcliatieGlaiva.Item2} ур.)";
                    _characterStatsForm.AmuletLabel3.Text = $@"{((Monk)hero).FormaDemona.Item1} ({((Monk)hero).FormaDemona.Item2} ур.)";
                    _characterStatsForm.AmuletLabel4.Text = $@"{((Monk)hero).KrovaviiTsvetok.Item1} ({((Monk)hero).KrovaviiTsvetok.Item2} ур.)";
                    _characterStatsForm.AmuletLabel5.Text = $@"{((Monk)hero).GromMolnia.Item1} ({((Monk)hero).GromMolnia.Item2} ур.)";
                    _characterStatsForm.AmuletLabel6.Text = $@"{((Monk)hero).Prizyv.Item1} ({((Monk)hero).Prizyv.Item2} ур.)";
                    _characterStatsForm.AmuletLabel7.Text = $@"{((Monk)hero).LedianoiUdar.Item1} ({((Monk)hero).LedianoiUdar.Item2} ур.)";
                    _characterStatsForm.AmuletLabel8.Text = $@"{((Monk)hero).Nevidimost.Item1} ({((Monk)hero).Nevidimost.Item2} ур.)";
                    break;
            }
        }
    }
}
