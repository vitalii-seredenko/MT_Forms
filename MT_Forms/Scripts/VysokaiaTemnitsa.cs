using MT_Forms.Common;
using MT_Forms.PageObjects;
using NLog;

namespace MT_Forms.Scripts
{
    internal class VysokaiaTemnitsa
    {
        private Logger _log = LogManager.GetCurrentClassLogger();
        private Form1 _form1 = new Form1();
        private readonly DungeonButtons _dungeonButtons;
        private readonly QuestsButtons _questsButtons;
        private const string DungeonName = "VysokaiaTemnitsa";
        private const string DailyQuestName = "Спокойствие Высокой Темницы";

        internal VysokaiaTemnitsa()
        {
            _dungeonButtons = new DungeonButtons();
            _questsButtons = new QuestsButtons();
        }

        public void VysokaiaTemnitsaScript()
        {
            var goToUrl = new GoToUrl();
            var commonUrls = new CommonUrls();
            var difficulty = new Difficulty();
            if (_form1.GoForTheCasketAndToEndCheckBox.Checked == false && _form1.GoForTheCasketCheckBox.Checked == false)
            {
                goToUrl.NavigateToUrl(commonUrls.GetDungeonUrlAndChooseDifficulty(DungeonName, difficulty.GetDungeonDifficulty()));
                _dungeonButtons.enterInDungeon.Click();
                _dungeonButtons.startBattle.Click();
                GoInDungeonForTheItems();
            }
            else if (_form1.GoForTheCasketAndToEndCheckBox.Checked)
            {
                goToUrl.NavigateToUrl(commonUrls.GetQuestUrl(DailyQuestName));
                _questsButtons.findGangButton.Click();
                _dungeonButtons.enterInDungeon.Click();
                _dungeonButtons.startBattle.Click();
                GoInDungeonForTheCasketAndItems();
            }
            else if (_form1.GoForTheCasketCheckBox.Checked)
            {
                goToUrl.NavigateToUrl(commonUrls.GetQuestUrl(DailyQuestName));
                _questsButtons.findGangButton.Click();
                _dungeonButtons.enterInDungeon.Click();
                _dungeonButtons.startBattle.Click();
                GoInDungeonOnlyForTheCasket();
            }
        }

        private void GoInDungeonForTheItems()
        {
            _log.Info("User go in 'Vysokaia Temnitsa' for the items");
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
            //Дописать
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
