using System.Text.RegularExpressions;

namespace MT_Forms.LogicForCharacters
{
    internal class Hero
    {
        private protected int _health;
        private protected int _strange;
        private protected int _protection;
        private protected int _criticalDamage;
        private protected int _blackMagicProtection;
        private protected int _regeneration;

        internal int GetSumOfStats()
        {
            return _health + _strange + _protection;
        }

        internal string CutLettersFromHeroLevel(string heroLevelTextBox)
        {
            var regex = new Regex("\\d+");
            var levelMatch = regex.Match(heroLevelTextBox);
            return levelMatch.Value;
        }
    }
}
