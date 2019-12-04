using MT_Forms.ApplicationData;
using MT_Forms.Common;
using MT_Forms.Core;
using MT_Forms.Core.Logger;
using MT_Forms.Extensions;
using MT_Forms.PageObjects.Buttons;

namespace MT_Forms.Scripts
{
    internal class VysokaiaTemnitsa
    {
        private readonly Logger _logger = new Logger();
        private readonly DungeonButtons _dungeonButtons = new DungeonButtons();
        private readonly QuestsButtons _questsButtons = new QuestsButtons();
        private const string DungeonName = "VysokaiaTemnitsa";
        private const string DailyQuestName = "Спокойствие Высокой Темницы";

        internal void VysokaiaTemnitsaScript()
        {
            var application = new MyApplication();
            var commonUrls = new CommonUrls();
            var difficulty = new Difficulty();
            if (!FormsStorage.mainProgramForm.GoForTheCasketAndToEndCheckBox.Checked && !FormsStorage.mainProgramForm.GoForTheCasketCheckBox.Checked)
            {
                application.NavigateToUrl(difficulty.ChooseDungeonDifficulty(DungeonName, difficulty.GetDungeonDifficulty()));
                _dungeonButtons.enterInDungeon.WaitElementAndClick();
                _dungeonButtons.startBattle.WaitElementAndClick();
                GoInDungeonForTheItems();
            }
            else if (FormsStorage.mainProgramForm.GoForTheCasketAndToEndCheckBox.Checked == false)
            {
                application.NavigateToUrl(commonUrls.GetQuestUrl(DailyQuestName));
                _questsButtons.findGangButton.WaitElementAndClick();
                _dungeonButtons.enterInDungeon.WaitElementAndClick();
                _dungeonButtons.startBattle.WaitElementAndClick();
                GoInDungeonForTheCasketAndItems();
            }
            else if (FormsStorage.mainProgramForm.GoForTheCasketCheckBox.Checked == false)
            {
                application.NavigateToUrl(commonUrls.GetQuestUrl(DailyQuestName));
                _questsButtons.findGangButton.WaitElementAndClick();
                _dungeonButtons.enterInDungeon.WaitElementAndClick();
                _dungeonButtons.startBattle.WaitElementAndClick();
                GoInDungeonOnlyForTheCasket();
            }
        }

        private void GoInDungeonForTheItems()
        {
            _logger.Info("User go in 'Vysokaia Temnitsa' for the items");
            while (true)
            {
                if (!_dungeonButtons.WaveIsComplete() && !_dungeonButtons.DungeonIsComplete() && !_dungeonButtons.GiveRewardLinkIsPresent())
                {
                    _dungeonButtons.firstAttackButton.ClickOnElementWithRandomInterval();
                }
                else if (_dungeonButtons.WaveIsComplete())
                {
                    _dungeonButtons.continueBattle.WaitElementAndClick();
                }
                else if (_dungeonButtons.DungeonIsComplete())
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
                if (!_dungeonButtons.WaveIsComplete() && !_dungeonButtons.DungeonIsComplete() && !_dungeonButtons.GiveRewardLinkIsPresent())
                {
                    _dungeonButtons.firstAttackButton.ClickOnElementWithRandomInterval();
                }
                else if (_dungeonButtons.WaveIsComplete())
                {
                    _dungeonButtons.continueBattle.WaitElementAndClick();
                }
                else if (_dungeonButtons.DungeonIsComplete())
                {
                    break;
                }
            }
            _dungeonButtons.giveRewardLink.WaitElementAndClick();
            _questsButtons.continueAdventures.WaitElementAndClick();
        }

        private void GoInDungeonOnlyForTheCasket()
        {
            _logger.Info("User go in 'Vysokaia Temnitsa' only for the casket");
            while (true)
            {
                if (!_dungeonButtons.WaveIsComplete() && !_dungeonButtons.DungeonIsComplete() && !_dungeonButtons.GiveRewardLinkIsPresent())
                {
                    _dungeonButtons.firstAttackButton.ClickOnElementWithRandomInterval();
                }
                else if (_dungeonButtons.WaveIsComplete())
                {
                    _dungeonButtons.continueBattle.WaitElementAndClick();
                }
                else if (_dungeonButtons.GiveRewardLinkIsPresent())
                {
                    _dungeonButtons.giveRewardLink.WaitElementAndClick();
                    _questsButtons.continueAdventures.WaitElementAndClick();
                    break;
                }
            }
        }
    }
}
