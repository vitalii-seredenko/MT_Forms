using System;
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
                    hero = new Magician(_characterPage.characterHealthTextBox.Text, _characterPage.characterStrangeTextBox.Text, _characterPage.characterProtectionTextBox.Text, _characterPage.characterCriticalDamageTextBox.Text, _characterPage.characterBlackMagicProtectionTextBox.Text, _characterPage.characterRegenerationTextBox.Text, _characterPage.vzryvEfiraLevelTextBox.Text, _characterPage.pritokSilyLevelTextBox.Text, _characterPage.sferyArcanyLevelTextBox.Text, _characterPage.gromMolniaLevelTextBox.Text, _characterPage.tenSmertiLevelTextBox.Text, _characterPage.nevidimostLevelTextBox.Text, _characterPage.prizyvLevelTextBox.Text, _characterPage.ledianoiUdarLevelTextBox.Text);
                    break;
                case "Воин":
                    hero = new Warrior(_characterPage.characterHealthTextBox.Text, _characterPage.characterStrangeTextBox.Text, _characterPage.characterProtectionTextBox.Text, _characterPage.characterCriticalDamageTextBox.Text, _characterPage.characterBlackMagicProtectionTextBox.Text, _characterPage.characterRegenerationTextBox.Text, _characterPage.zaschitaBogovLevelTextBox.Text, _characterPage.iarostBogovLevelTextBox.Text, _characterPage.ryvokZhizniLevelTextBox.Text, _characterPage.gromMolniaLevelTextBox.Text, _characterPage.talismanDoblestiLevelTextBox.Text, _characterPage.nevidimostLevelTextBox.Text, _characterPage.prizyvLevelTextBox.Text, _characterPage.ledianoiUdarLevelTextBox.Text);
                    break;
                case "Монах":
                    hero = new Monk(_characterPage.characterHealthTextBox.Text, _characterPage.characterStrangeTextBox.Text, _characterPage.characterProtectionTextBox.Text, _characterPage.characterCriticalDamageTextBox.Text, _characterPage.characterBlackMagicProtectionTextBox.Text, _characterPage.characterRegenerationTextBox.Text, _characterPage.listokLotosaLevelTextBox.Text, _characterPage.formaDemonaLevelTextBox.Text, _characterPage.procliatieGlaivaLevelTextBox.Text, _characterPage.gromMolniaLevelTextBox.Text, _characterPage.krovaviiTsvetokLevelTextBox.Text, _characterPage.nevidimostLevelTextBox.Text, _characterPage.prizyvLevelTextBox.Text, _characterPage.ledianoiUdarLevelTextBox.Text);
                    break;
            }
        }
    }
}
