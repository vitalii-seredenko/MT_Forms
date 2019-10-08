namespace MT_Forms.Common
{
    internal class Difficulty
    {
        private Form1 _form1 = new Form1();

        internal enum DungeonDifficulty
        {
            Normal = 1,
            Hard,
            Impossible
        }

        internal DungeonDifficulty GetDungeonDifficulty()
        {
            var dungeonDifficulty = DungeonDifficulty.Normal;
                if (_form1.HardDifficultyRadioButton.Checked)
                    dungeonDifficulty = DungeonDifficulty.Hard;
                if (_form1.ImpossibleDifficultyRadioButton.Checked)
                    dungeonDifficulty = DungeonDifficulty.Impossible;
            return dungeonDifficulty;
        }
    }
}
