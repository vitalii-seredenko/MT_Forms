namespace MT_Forms.LogicForCharacters
{
    internal class Monk : Character
    {
        private (string listokLotosa, int listokLotosaLevel) _listokLotosa;
        private (string formaDemona, int formaDemonaLevel) _formaDemona;
        private (string procliatieGlaiva, int procliatieGlaivaLevel) _procliatieGlaiva;
        private (string gromMolnia, int gromMolniaLevel) _gromMolnia;
        private (string krovaviiTsvetok, int krovaviiTsvetokLevel) _krovaviiTsvetok;

        private (string nevidimost, int nevidimostLevel) _nevidimost;
        private (string prizyv, int prizyvLevel) _prizyv;
        private (string ledianoiUdar, int ledianoiUdarLevel) _ledianoiUdar;

        internal (string, int) ListokLotosa => _listokLotosa;
        internal (string, int) FormaDemona => _formaDemona;
        internal (string, int) ProcliatieGlaiva => _procliatieGlaiva;
        internal (string, int) GromMolnia => _gromMolnia;
        internal (string, int) KrovaviiTsvetok => _krovaviiTsvetok;

        internal (string, int) Nevidimost => _nevidimost;
        internal (string, int) Prizyv => _prizyv;
        internal (string, int) LedianoiUdar => _ledianoiUdar;

        internal Monk(string health, string strange, string protection, string criticalDamage, string blackMagicProtection, string regeneration, string listokLotosaLevel, string formaDemonaLevel, string procliatieGlaivaLevel, string gromMolniaLevel, string krovaviiTsvetokLevel, string nevidimostLevel, string prizyvLevel, string ledianoiUdarLevel)
        {
            int.TryParse(health, out _health);
            int.TryParse(strange, out _strange);
            int.TryParse(protection, out _protection);
            int.TryParse(criticalDamage, out _criticalDamage);
            int.TryParse(blackMagicProtection, out _blackMagicProtection);
            int.TryParse(regeneration, out _regeneration);

            _listokLotosa.listokLotosa = "Листок Лотоса";
            int.TryParse(listokLotosaLevel, out _listokLotosa.listokLotosaLevel);
            _formaDemona.formaDemona = "Форма Демона";
            int.TryParse(formaDemonaLevel, out _formaDemona.formaDemonaLevel);
            _procliatieGlaiva.procliatieGlaiva = "Проклятие Глайва";
            int.TryParse(procliatieGlaivaLevel, out _procliatieGlaiva.procliatieGlaivaLevel);
            _gromMolnia.gromMolnia = "Гром и Молния";
            int.TryParse(gromMolniaLevel, out _gromMolnia.gromMolniaLevel);
            _krovaviiTsvetok.krovaviiTsvetok = "Кровавый Цветок";
            int.TryParse(krovaviiTsvetokLevel, out _krovaviiTsvetok.krovaviiTsvetokLevel);

            _nevidimost.nevidimost = "Невидимость";
            int.TryParse(nevidimostLevel, out _nevidimost.nevidimostLevel);
            _prizyv.prizyv = "Призыв";
            int.TryParse(prizyvLevel, out _prizyv.prizyvLevel);
            _ledianoiUdar.ledianoiUdar = "Ледяной Удар";
            int.TryParse(ledianoiUdarLevel, out _ledianoiUdar.ledianoiUdarLevel);
        }
    }
}
