using System;

namespace MT_Forms.CommonMethods
{
    class CommonUrls
    {
        public enum DungeonUrl
        {
            MonastyrPokoia,
            VysokaiaTemnitsa,
            KrepostHolding,
            VladeniaBarona,
            PorogiShedowGarda
        }

        public string GetDungeonUrlAndChooseDifficulty(DungeonUrl commonDungeonUrl, string normalOrHardOrImpossible)
        {
            string dungeonUrl = GetDungeonUrl(commonDungeonUrl);
            dungeonUrl = normalOrHardOrImpossible.Equals("normal") ? dungeonUrl + "/normal" :
                        normalOrHardOrImpossible.Equals("hard") ? dungeonUrl + "/hard" :
                        normalOrHardOrImpossible.Equals("impossible") ? dungeonUrl + "/hard" :
                        throw new ArgumentException($"Указанная сложность ({normalOrHardOrImpossible}) " +
                                                    $"не совпадает ни с одной из существующих: 'normal', 'hard', 'impossible'");
            return dungeonUrl;
        }

        private string GetDungeonUrl(DungeonUrl commonDungeonUrl)
        {
            string dungeonUrl = "";
            switch (commonDungeonUrl)
            {
                case DungeonUrl.MonastyrPokoia:
                    dungeonUrl = "https://m.vten.ru/dungeon/landing/RestMonastery";
                    break;
                case DungeonUrl.VysokaiaTemnitsa:
                    dungeonUrl = "https://m.vten.ru/dungeon/landing/HighDungeon";
                    break;
                case DungeonUrl.KrepostHolding:
                    dungeonUrl = "https://m.vten.ru/dungeon/landing/CitadelHolding";
                    break;
                case DungeonUrl.VladeniaBarona:
                    dungeonUrl = "https://m.vten.ru/dungeon/landing/Barony";
                    break;
                case DungeonUrl.PorogiShedowGarda:
                    dungeonUrl = "https://m.vten.ru/dungeon/landing/ShadowGuard";
                    break;
            }
            return dungeonUrl;
        }
    }
}
