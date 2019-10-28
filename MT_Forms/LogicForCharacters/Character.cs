using System;

namespace MT_Forms.LogicForCharacters
{
    internal class Character
    {
        private protected string _characterClass;
        private protected int _health;
        private protected int _strange;
        private protected int _protection;
        private protected int _criticalDamage;
        private protected int _blackMagicProtection;
        private protected int _regeneration;

        internal int Health => _health;
        internal int Strange => _strange;
        internal int Protection => _protection;
        internal int CriticalDamage => _criticalDamage;
        internal int BlackMagicProtection => _blackMagicProtection;
        internal int Regeneration => _regeneration;

        internal string CharacterClass
        {
            get => _characterClass;
            set
            {
                switch (value)
                {
                    case "Маг":
                        _characterClass = "Маг";
                        break;
                    case "Воин":
                        _characterClass = "Воин";
                        break;
                    case "Монах":
                        _characterClass = "Монах";
                        break;
                    default: throw new ArgumentException($"Value '{0}' does not a character class", value);
                }
            }
        }

        internal int CharacterSumOfStats()
        {
            return _health + _strange + _protection;
        }
    }
}
