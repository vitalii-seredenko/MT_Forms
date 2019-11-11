using MT_Forms.Core;
using MT_Forms.LogicForCharacters;
using MT_Forms.PageObjects;

namespace MT_Forms.Common
{
    internal class UserCharacteristic
    {
        internal static Character hero = new Character();
        private readonly BaseTownPage _baseTownPage;
        private readonly Character _character;
        private readonly CharacterPage _characterPage;

        internal UserCharacteristic()
        {
            _baseTownPage = new BaseTownPage();
            _character = new Character();
            _characterPage = new CharacterPage();
        }

        internal void GetUser()
        {
            _baseTownPage.characterButton.Click();
            switch (_character.CharacterClass = _characterPage.characterClassTextBox.Text)
            {
                case "Маг":
                    hero = new Magician(_characterPage.characterHealthTextBox.Text, _characterPage.characterStrangeTextBox.Text, _characterPage.characterProtectionTextBox.Text, _characterPage.characterCriticalDamageTextBox.Text, _characterPage.ReturnElementTextIfElementPresent(_characterPage.characterBlackMagicProtectionTextBox), _characterPage.characterRegenerationTextBox.Text, _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.vzryvEfiraLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.pritokSilyLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.sferyArcanyLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.gromMolniaLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.tenSmertiLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.nevidimostLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.prizyvLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.ledianoiUdarLevelTextBox));
                    break;
                case "Воин":
                    hero = new Warrior(_characterPage.characterHealthTextBox.Text, _characterPage.characterStrangeTextBox.Text, _characterPage.characterProtectionTextBox.Text, _characterPage.characterCriticalDamageTextBox.Text, _characterPage.ReturnElementTextIfElementPresent(_characterPage.characterBlackMagicProtectionTextBox), _characterPage.characterRegenerationTextBox.Text, _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.zaschitaBogovLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.iarostBogovLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.ryvokZhizniLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.gromMolniaLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.talismanDoblestiLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.nevidimostLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.prizyvLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.ledianoiUdarLevelTextBox));
                    break;
                case "Монах":
                    hero = new Monk(_characterPage.characterHealthTextBox.Text, _characterPage.characterStrangeTextBox.Text, _characterPage.characterProtectionTextBox.Text, _characterPage.characterCriticalDamageTextBox.Text, _characterPage.ReturnElementTextIfElementPresent(_characterPage.characterBlackMagicProtectionTextBox), _characterPage.characterRegenerationTextBox.Text, _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.listokLotosaLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.formaDemonaLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.procliatieGlaivaLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.gromMolniaLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.krovaviiTsvetokLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.nevidimostLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.prizyvLevelTextBox), _characterPage.CutLettersFromHeroLevelTextBox(_characterPage.ledianoiUdarLevelTextBox));
                    break;
            }
        }

        internal void ShowUserCharacteristicInForm()
        {
            FormsInitialization.characterStatsForm.HealLabel.Text = $@"Живучесть: {hero.Health}";
            FormsInitialization.characterStatsForm.StrangeLabel.Text = $@"Сила: {hero.Strange}";
            FormsInitialization.characterStatsForm.CriticalDamageLevel.Text = $@"Крит: {hero.CriticalDamage}";
            FormsInitialization.characterStatsForm.ProtectionLabel.Text = $@"Защита: {hero.Protection}";
            FormsInitialization.characterStatsForm.BlackMagicProtectionLabel.Text = $@"Защита от чёрной магии: {hero.BlackMagicProtection}";
            FormsInitialization.characterStatsForm.RegenerationLabel.Text = $@"Регенерация: {hero.Regeneration}";

            switch (_character.CharacterClass)
            {
                case "Маг":
                    FormsInitialization.characterStatsForm.AmuletLabel1.Text = $@"{((Magician)hero).VzryvEfira.Item1} ({((Magician)hero).VzryvEfira.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel2.Text = $@"{((Magician)hero).SferyArcany.Item1} ({((Magician)hero).SferyArcany.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel3.Text = $@"{((Magician)hero).PritokSily.Item1} ({((Magician)hero).PritokSily.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel4.Text = $@"{((Magician)hero).TenSmerti.Item1} ({((Magician)hero).TenSmerti.Item2} ур.)"; 
                    FormsInitialization.characterStatsForm.AmuletLabel5.Text = $@"{((Magician)hero).GromMolnia.Item1} ({((Magician)hero).GromMolnia.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel6.Text = $@"{((Magician)hero).Prizyv.Item1} ({((Magician)hero).Prizyv.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel7.Text = $@"{((Magician)hero).LedianoiUdar.Item1} ({((Magician)hero).LedianoiUdar.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel8.Text = $@"{((Magician)hero).Nevidimost.Item1} ({((Magician)hero).Nevidimost.Item2} ур.)";
                    break;
                case "Воин":
                    FormsInitialization.characterStatsForm.AmuletLabel1.Text = $@"{((Warrior)hero).ZaschitaBogov.Item1} ({((Warrior)hero).ZaschitaBogov.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel2.Text = $@"{((Warrior)hero).RyvokZhizni.Item1} ({((Warrior)hero).RyvokZhizni.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel3.Text = $@"{((Warrior)hero).IarostBogov.Item1} ({((Warrior)hero).IarostBogov.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel4.Text = $@"{((Warrior)hero).TalismanDoblesti.Item1} ({((Warrior)hero).TalismanDoblesti.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel5.Text = $@"{((Warrior)hero).GromMolnia.Item1} ({((Warrior)hero).GromMolnia.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel6.Text = $@"{((Warrior)hero).Prizyv.Item1} ({((Warrior)hero).Prizyv.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel7.Text = $@"{((Warrior)hero).LedianoiUdar.Item1} ({((Warrior)hero).LedianoiUdar.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel8.Text = $@"{((Warrior)hero).Nevidimost.Item1} ({((Warrior)hero).Nevidimost.Item2} ур.)";
                    break;
                case "Монах":
                    FormsInitialization.characterStatsForm.AmuletLabel1.Text = $@"{((Monk)hero).ListokLotosa.Item1} ({((Monk)hero).ListokLotosa.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel2.Text = $@"{((Monk)hero).ProcliatieGlaiva.Item1} ({((Monk)hero).ProcliatieGlaiva.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel3.Text = $@"{((Monk)hero).FormaDemona.Item1} ({((Monk)hero).FormaDemona.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel4.Text = $@"{((Monk)hero).KrovaviiTsvetok.Item1} ({((Monk)hero).KrovaviiTsvetok.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel5.Text = $@"{((Monk)hero).GromMolnia.Item1} ({((Monk)hero).GromMolnia.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel6.Text = $@"{((Monk)hero).Prizyv.Item1} ({((Monk)hero).Prizyv.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel7.Text = $@"{((Monk)hero).LedianoiUdar.Item1} ({((Monk)hero).LedianoiUdar.Item2} ур.)";
                    FormsInitialization.characterStatsForm.AmuletLabel8.Text = $@"{((Monk)hero).Nevidimost.Item1} ({((Monk)hero).Nevidimost.Item2} ур.)";
                    break;
            }
        }
    }
}
