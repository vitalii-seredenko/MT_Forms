namespace MT_Forms.LogicForCharacters
{
    internal class Magician : Character
    {
        private (string vzryvEfira, int vzryvEfiraLevel) _vzryvEfira;
        private (string pritokSily, int pritokSilyLevel) _pritokSily;
        private (string sferyArcany, int sferyArcanyLevel) _sferyArcany;
        private (string gromMolnia, int gromMolniaLevel) _gromMolnia;
        private (string tenSmerti, int tenSmertiLevel) _tenSmerti;

        private (string nevidimost, int nevidimostLevel) _nevidimost;
        private (string prizyv, int prizyvLevel) _prizyv;
        private (string ledianoiUdar, int ledianoiUdarLevel) _ledianoiUdar;

        internal (string, int) VzryvEfira => _vzryvEfira;
        internal (string, int) PritokSily => _pritokSily;
        internal (string, int) SferyArcany => _sferyArcany;
        internal (string, int) GromMolnia => _gromMolnia;
        internal (string, int) TenSmerti => _tenSmerti;

        internal (string, int) Nevidimost => _nevidimost;
        internal (string, int) Prizyv => _prizyv;
        internal (string, int) LedianoiUdar => _ledianoiUdar;

        internal Magician(string health, string strange, string protection, string criticalDamage, string blackMagicProtection, string regeneration, string vzryvEfiraLevel, string pritokSilyLevel, string sferyArcanyLevel, string gromMolniaLevel, string tenSmertiLevel, string nevidimostLevel, string prizyvLevel, string ledianoiUdarLevel)
        {
            int.TryParse(health, out base.health);
            int.TryParse(strange, out strength);
            int.TryParse(protection, out base.protection);
            int.TryParse(criticalDamage, out base.criticalDamage);
            int.TryParse(blackMagicProtection, out base.blackMagicProtection);
            int.TryParse(regeneration, out base.regeneration);

            _vzryvEfira.vzryvEfira = "Взрыв Эфира";
            int.TryParse(vzryvEfiraLevel, out _vzryvEfira.vzryvEfiraLevel);
            _pritokSily.pritokSily = "Приток Силы";
            int.TryParse(pritokSilyLevel, out _pritokSily.pritokSilyLevel);
            _sferyArcany.sferyArcany = "Сферы Арканы";
            int.TryParse(sferyArcanyLevel, out _sferyArcany.sferyArcanyLevel);
            _gromMolnia.gromMolnia = "Гром и Молния";
            int.TryParse(gromMolniaLevel, out _gromMolnia.gromMolniaLevel);
            _tenSmerti.tenSmerti = "Тень Смерти";
            int.TryParse(tenSmertiLevel, out _tenSmerti.tenSmertiLevel);

            _nevidimost.nevidimost = "Невидимость";
            int.TryParse(nevidimostLevel, out _nevidimost.nevidimostLevel);
            _prizyv.prizyv = "Призыв";
            int.TryParse(prizyvLevel, out _prizyv.prizyvLevel);
            _ledianoiUdar.ledianoiUdar = "Ледяной Удар";
            int.TryParse(ledianoiUdarLevel, out _ledianoiUdar.ledianoiUdarLevel);
        }
    }
}
