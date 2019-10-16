using MT_Forms.ApplicationData;
using MT_Forms.Common;
using MT_Forms.Core;
using MT_Forms.PageObjects;

namespace MT_Forms.Scripts
{
    internal class VysokaiaTemnitsa
    {
        private readonly Logger _logger;
        private readonly DungeonButtons _dungeonButtons;
        private readonly QuestsButtons _questsButtons;
        private const string DungeonName = "VysokaiaTemnitsa";
        private const string DailyQuestName = "Спокойствие Высокой Темницы";

        internal VysokaiaTemnitsa()
        {
            _logger = new Logger();
            _dungeonButtons = new DungeonButtons();
            _questsButtons = new QuestsButtons();
        }

        internal void VysokaiaTemnitsaScript()
        {
            var application = new Application();
            var commonUrls = new CommonUrls();
            var difficulty = new Difficulty();
            if (!FormsInitialization.loginForm.GoForTheCasketAndToEndCheckBox.Checked && !FormsInitialization.loginForm.GoForTheCasketCheckBox.Checked)
            {
                application.NavigateToUrl(difficulty.ChooseDungeonDifficulty(DungeonName, difficulty.GetDungeonDifficulty()));
                _dungeonButtons.enterInDungeon.Click();
                _dungeonButtons.startBattle.Click();
                GoInDungeonForTheItems();
            }
            else if (FormsInitialization.loginForm.GoForTheCasketAndToEndCheckBox.Checked == false)
            {
                application.NavigateToUrl(commonUrls.GetQuestUrl(DailyQuestName));
                _questsButtons.findGangButton.Click();
                _dungeonButtons.enterInDungeon.Click();
                _dungeonButtons.startBattle.Click();
                GoInDungeonForTheCasketAndItems();
            }
            else if (FormsInitialization.loginForm.GoForTheCasketCheckBox.Checked == false)
            {
                application.NavigateToUrl(commonUrls.GetQuestUrl(DailyQuestName));
                _questsButtons.findGangButton.Click();
                _dungeonButtons.enterInDungeon.Click();
                _dungeonButtons.startBattle.Click();
                GoInDungeonOnlyForTheCasket();
            }
        }

        private void GoInDungeonForTheItems()
        {
            _logger.Info("User go in 'Vysokaia Temnitsa' for the items");
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
            _logger.Info("User go in 'Vysokaia Temnitsa' for the casket and items");
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
            _logger.Info("User go in 'Vysokaia Temnitsa' only for the casket");
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
