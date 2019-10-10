using System;
using MT_Forms.ApplicationData;
using MT_Forms.Core;

namespace MT_Forms.Common
{
    internal class Difficulty
    {
        internal enum DungeonDifficulty
        {
            Normal = 1,
            Hard,
            Impossible
        }

        internal DungeonDifficulty GetDungeonDifficulty()
        {
            var dungeonDifficulty = DungeonDifficulty.Normal;
                if (FormsInitialization.form1.HardDifficultyRadioButton.Checked)
                    dungeonDifficulty = DungeonDifficulty.Hard;
                if (FormsInitialization.form1.ImpossibleDifficultyRadioButton.Checked)
                    dungeonDifficulty = DungeonDifficulty.Impossible;
            return dungeonDifficulty;
        }

        internal string ChooseDungeonDifficulty(string dungeonName, DungeonDifficulty difficulty)
        {
            var dungeonUrl = new CommonUrls().GetDungeonUrl(dungeonName);
            dungeonUrl = difficulty.Equals(DungeonDifficulty.Normal) ? dungeonUrl + "/normal" :
                difficulty.Equals(DungeonDifficulty.Hard) ? dungeonUrl + "/hard" :
                difficulty.Equals(DungeonDifficulty.Impossible) ? dungeonUrl + "/impossible" :
                throw new ArgumentException($"Specified complexity ({difficulty}) " +
                                            "does not match any of the existing ones: 'normal', 'hard', 'impossible'");
            return dungeonUrl;
        }
    }
}
