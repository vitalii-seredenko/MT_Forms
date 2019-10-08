using System;
using System.Collections.Generic;
using DungeonDifficulty = MT_Forms.Common.Difficulty.DungeonDifficulty;

namespace MT_Forms.Common
{
    internal class CommonUrls
    {
        private readonly Dictionary<string, string> _dungeonUrls = new Dictionary<string, string>
        {
            {"MonastyrPokoia", "https://m.vten.ru/dungeon/landing/RestMonastery"},
            {"VysokaiaTemnitsa", "https://m.vten.ru/dungeon/landing/HighDungeon"},
            {"KrepostHolding", "https://m.vten.ru/dungeon/landing/CitadelHolding"},
            {"VladeniaBarona", "https://m.vten.ru/dungeon/landing/Barony"},
            {"PorogiShedowGarda", "https://m.vten.ru/dungeon/landing/ShadowGuard"}
        };

        private readonly Dictionary<string,string> _questUrls = new Dictionary<string, string>
        {
            {"Спокойствие Высокой Темницы", "https://m.vten.ru/quest/qHeroicHighDungeonDaily"},
        };
        
        internal string GetDungeonUrlAndChooseDifficulty(string dungeonName, DungeonDifficulty difficulty)
        {
            var dungeonUrl = GetDungeonUrl(dungeonName);
            dungeonUrl = difficulty.Equals(DungeonDifficulty.Normal) ? dungeonUrl + "/normal" :
                            difficulty.Equals(DungeonDifficulty.Hard) ? dungeonUrl + "/hard" :
                            difficulty.Equals(DungeonDifficulty.Impossible) ? dungeonUrl + "/impossible" :
                            throw new ArgumentException($"Specified complexity ({difficulty}) " +
                                                    "does not match any of the existing ones: 'normal', 'hard', 'impossible'");
            return dungeonUrl;
        }

        internal string GetDungeonUrl(string dungeonName)
        {
            return _dungeonUrls[dungeonName];
        }

        internal string GetQuestUrl(string questName)
        {
            return _questUrls[questName];
        }
    }
}
