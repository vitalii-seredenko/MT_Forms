using System;
using System.Collections.Generic;
using MT_Forms.Core.Logger;

namespace MT_Forms.LogicForCharacters
{
    internal class Character
    {
        private protected string heroClass;
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

        internal string HeroClass
        {
            get => heroClass;
            set
            {
                var classArray = new List<string>{ "Маг", "Воин", "Монах" };
                foreach (var className in classArray)
                {
                    if (value.Equals(className))
                    {
                        heroClass = className;
                        break;
                    }
                }

                if (string.IsNullOrEmpty(heroClass))
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
