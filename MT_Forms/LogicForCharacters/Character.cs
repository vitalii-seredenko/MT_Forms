﻿using System;
using System.Collections.Generic;
using MT_Forms.Core;

namespace MT_Forms.LogicForCharacters
{
    internal class Character
    {
        protected string _characterClass;
        protected int _health;
        protected int _strength;
        protected int _protection;
        protected int _criticalDamage;
        protected int _blackMagicProtection;
        protected int _regeneration;

        internal int Health => _health;
        internal int Strange => _strength;
        internal int Protection => _protection;
        internal int CriticalDamage => _criticalDamage;
        internal int BlackMagicProtection => _blackMagicProtection;
        internal int Regeneration => _regeneration;

        internal string CharacterClass
        {
            get => _characterClass;
            set
            {
                var classArray = new List<string>{ "Маг", "Воин", "Монах" };
                foreach (var className in classArray)
                {
                    if (value.Equals(className))
                    {
                        _characterClass = className;
                        break;
                    }
                }

                if (string.IsNullOrEmpty(_characterClass))
                {
                    new Logger().Error($"Value '{value}' does not a character class");
                    throw new ArgumentException($"Value '{0}' does not a character class", value);
                }
            }
        }

        internal int CharacterSumOfStats()
        {
            return _health + _strength + _protection;
        }
    }
}
