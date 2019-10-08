using System.Windows.Forms;
using PageObjects;
using CommonMethods;
using MT_Forms;
using MT_Forms.CommonMethods;
using DungeonUrl = MT_Forms.CommonMethods.CommonUrls.DungeonUrl;

namespace Scripts
{
    class VysokaiaTemnitsa
    {
        readonly DungeonButtons _dungeonButtons;
        readonly QuestsButtons _questsButtons;

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
