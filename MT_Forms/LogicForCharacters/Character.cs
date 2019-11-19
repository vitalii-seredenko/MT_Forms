using System;
using System.Collections.Generic;
using MT_Forms.Core.Logger;

namespace MT_Forms.LogicForCharacters
{
    internal class Character
    {
        private protected string characterClass;
        private protected int health;
        private protected int strength;
        private protected int protection;
        private protected int criticalDamage;
        private protected int blackMagicProtection;
        private protected int regeneration;

        internal int Health => health;
        internal int Strange => strength;
        internal int Protection => protection;
        internal int CriticalDamage => criticalDamage;
        internal int BlackMagicProtection => blackMagicProtection;
        internal int Regeneration => regeneration;

        internal string CharacterClass
        {
            get => characterClass;
            set
            {
                var classArray = new List<string>{ "Маг", "Воин", "Монах" };
                foreach (var className in classArray)
                {
                    if (value.Equals(className))
                    {
                        characterClass = className;
                        break;
                    }
                }

                if (string.IsNullOrEmpty(characterClass))
                {
                    var exception = new ArgumentException($"Value '{0}' does not a character class", value);
                    new Logger().Error(exception.Message);
                    throw exception;
                }
            }
        }

        internal int CharacterSumOfStats()
        {
            return health + strength + protection;
        }
    }
}
