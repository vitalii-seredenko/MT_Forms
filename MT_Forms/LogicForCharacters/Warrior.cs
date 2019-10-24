namespace MT_Forms.LogicForCharacters
{
    internal class Warrior : Character
    {
        private (string zaschitaBogov, int zaschitaBogovLevel) _zaschitaBogov;
        private (string iarostBogov, int iarostBogovLevel) _iarostBogov;
        private (string ryvokZhizni, int ryvokZhizniLevel) _ryvokZhizni;
        private (string gromMolnia, int gromMolniaLevel) _gromMolnia;
        private (string talismanDoblesti, int talismanDoblestiLevel) _talismanDoblesti;

        private (string nevidimost, int nevidimostLevel) _nevidimost;
        private (string prizyv, int prizyvLevel) _prizyv;
        private (string ledianoiUdar, int ledianoiUdarLevel) _ledianoiUdar;

        internal Warrior(string health, string strange, string protection, string criticalDamage, string blackMagicProtection, string regeneration, string zaschitaBogovLevel, string iarostBogovLevel, string ryvokZhizniLevel, string gromMolniaLevel, string talismanDoblestiLevel, string nevidimostLevel, string prizyvLevel, string ledianoiUdarLevel)
        {
            int.TryParse(health, out _health);
            int.TryParse(strange, out _strange);
            int.TryParse(protection, out _protection);
            int.TryParse(criticalDamage, out _criticalDamage);
            int.TryParse(blackMagicProtection, out _blackMagicProtection);
            int.TryParse(regeneration, out _regeneration);

            _zaschitaBogov.zaschitaBogov = "Защита Богов";
            int.TryParse(zaschitaBogovLevel, out _zaschitaBogov.zaschitaBogovLevel);
            _iarostBogov.iarostBogov = "Ярость Богов";
            int.TryParse(iarostBogovLevel, out _iarostBogov.iarostBogovLevel);
            _ryvokZhizni.ryvokZhizni = "Рывок Жизни";
            int.TryParse(ryvokZhizniLevel, out _ryvokZhizni.ryvokZhizniLevel);
            _gromMolnia.gromMolnia = "Гром и Молния";
            int.TryParse(gromMolniaLevel, out _gromMolnia.gromMolniaLevel);
            _talismanDoblesti.talismanDoblesti = "Талисман Доблести";
            int.TryParse(talismanDoblestiLevel, out _talismanDoblesti.talismanDoblestiLevel);

            _nevidimost.nevidimost = "Невидимость";
            int.TryParse(nevidimostLevel, out _nevidimost.nevidimostLevel);
            _prizyv.prizyv = "Призыв";
            int.TryParse(prizyvLevel, out _prizyv.prizyvLevel);
            _ledianoiUdar.ledianoiUdar = "Ледяной Удар";
            int.TryParse(ledianoiUdarLevel, out _ledianoiUdar.ledianoiUdarLevel);
        }
    }
}
