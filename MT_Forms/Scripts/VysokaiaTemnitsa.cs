using System.Windows.Forms;
using PageObjects;
using CommonMethods;
using MT_Forms;
using MT_Forms.CommonMethods;
using DungeonUrl = MT_Forms.CommonMethods.CommonUrls.DungeonUrl;
using MT_Forms.CommonMethods;
using MT_Forms.PageObjects;
using NLog;

namespace MT_Forms.Scripts
{
    class VysokaiaTemnitsa
    {
        private Logger _log = LogManager.GetCurrentClassLogger();
        private readonly DungeonButtons _dungeonButtons;
        private readonly QuestsButtons _questsButtons;

        public VysokaiaTemnitsa()
        {
            _dungeonButtons = new DungeonButtons();
            _questsButtons = new QuestsButtons();
        }

        public void VysokaiaTemnitsaScript()
        {
            
            if (new Form1().GoForTheCasketAndToEndCheckBox.CheckState == CheckState.Unchecked && new Form1().GoForTheCasketCheckBox.CheckState == CheckState.Checked)
            {
                new GoToUrl().NavigateToUrl(new CommonUrls().GetDungeonUrlAndChooseDifficulty(DungeonUrl.VysokaiaTemnitsa, "normal"));
                _dungeonButtons.enterInDungeon.Click();
                _dungeonButtons.startBattle.Click();
            }
            else if (new Form1().GoForTheCasketAndToEndCheckBox.CheckState == CheckState.Checked)
            {
                new GoToUrl().NavigateToUrl("https://m.vten.ru/quest/qHeroicHighDungeonDaily");
                _questsButtons.findGangButton.Click();
                _dungeonButtons.enterInDungeon.Click();
                _dungeonButtons.startBattle.Click();
                GoInDungeonForTheCasketAndItems();
            }
            else if (new Form1().GoForTheCasketCheckBox.CheckState == CheckState.Checked)
            {
                new GoToUrl().NavigateToUrl("https://m.vten.ru/quest/qHeroicHighDungeonDaily");
                _questsButtons.findGangButton.Click();
                _dungeonButtons.enterInDungeon.Click();
                _dungeonButtons.startBattle.Click();
                GoInDungeonOnlyForTheCasket();
            }
        }

        private void GoInDungeonForTheCasketAndItems()
        {
            _log.Info("User go in 'Vysokaia Temnitsa' for the casket and items");
            while (true)
            {
                if (!_dungeonButtons.CheckWaveIsComplete() && !_dungeonButtons.CheckDungeonIsComplete() && !_dungeonButtons.CheckGiveRewardLinkIsPresent())
                {
                    _dungeonButtons.ClickOnFirstAttackButton();
                }
                else if (_dungeonButtons.CheckWaveIsComplete())
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
            _log.Info("User go in 'Vysokaia Temnitsa' only for the casket");
            while (true)
            {
                if (!_dungeonButtons.CheckWaveIsComplete() && !_dungeonButtons.CheckDungeonIsComplete() && !_dungeonButtons.CheckGiveRewardLinkIsPresent())
                {
                    _dungeonButtons.ClickOnFirstAttackButton();
                }
                else if (_dungeonButtons.CheckWaveIsComplete())
                {
                    _dungeonButtons.continueBattle.Click();
                }
                else if (_dungeonButtons.CheckGiveRewardLinkIsPresent())
                {
                    _dungeonButtons.giveRewardLink.Click();
                    _questsButtons.continueAdventures.Click();
                    break;
                }
            }
        }
    }
}
