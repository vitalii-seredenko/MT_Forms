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
    }
}
