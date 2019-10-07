using System.Windows.Forms;
using PageObjects;
using CommonMethods;
using MT_Forms;
using NLog;

namespace Scripts
{
    class VisokaiaTemnitsa
    {
        readonly DungeonButtons _dungeonButtons;
        readonly QuestsButtons _questsButtons;
        private Logger _log = LogManager.GetCurrentClassLogger();

        public VisokaiaTemnitsa()
        {
            _dungeonButtons = new DungeonButtons();
            _questsButtons = new QuestsButtons();
        }

        public void VisokaiaTemnitsaScript()
        {
            new GoToUrl().NavigateToUrl("https://m.vten.ru/quest/qHeroicHighDungeonDaily");
            _questsButtons.findGangButton.Click();
            _dungeonButtons.enterInDungeon.Click();
            _dungeonButtons.startBattle.Click();

            if (new Form1().GoForTheCasketCheckBox.CheckState == CheckState.Unchecked)
            {
                GoInDungeonForTheCasketAndItems();
            }
            else if (new Form1().GoForTheCasketCheckBox.CheckState == CheckState.Checked)
            {
                GoInDungeonOnlyForTheCasket();
            }
        }

        private void GoInDungeonForTheCasketAndItems()
        {
            _log.Info("User go in Vysokaia Temnitsa for the casket and items");
            while (true)
            {
                if (!_dungeonButtons.checkWaveIsComplete() && !_dungeonButtons.CheckDungeonIsComplete() && !_dungeonButtons.checkGiveRewardLinkIsVisible())
                {
                    _dungeonButtons.clickOnFirstAttackButton();
                }
                else if (_dungeonButtons.checkWaveIsComplete())
                {
                    _dungeonButtons.continueBattle.Click();
                }
                else if (_dungeonButtons.CheckDungeonIsComplete())
                {
                    break;
                }
            }
            _dungeonButtons.giveRewardLink.Click();
            _questsButtons.continueAdventures.Click();
        }

        private void GoInDungeonOnlyForTheCasket()
        {
            _log.Info("User go in Vysokaia Temnitsa only for the casket");
            while (true)
            {
                if (!_dungeonButtons.checkWaveIsComplete() && !_dungeonButtons.CheckDungeonIsComplete() && !_dungeonButtons.checkGiveRewardLinkIsVisible())
                {
                    _dungeonButtons.clickOnFirstAttackButton();
                }
                else if (_dungeonButtons.checkWaveIsComplete())
                {
                    _dungeonButtons.continueBattle.Click();
                }
                else if (_dungeonButtons.checkGiveRewardLinkIsVisible())
                {
                    _dungeonButtons.giveRewardLink.Click();
                    _questsButtons.continueAdventures.Click();
                    break;
                }
            }
        }
    }
}
