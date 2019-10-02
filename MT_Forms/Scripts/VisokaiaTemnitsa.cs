using PageObjects;
using Core;
using OpenQA.Selenium;
using CommonMethods;

namespace Scripts
{
    class VisokaiaTemnitsa
    {
        readonly IWebDriver _driver = DriverSingletone.Driver;
        readonly DungeonButtons _dungeonButtons;
        readonly QuestsButtons _questsButtons;

        public VisokaiaTemnitsa()
        {
            _dungeonButtons = new DungeonButtons(_driver);
            _questsButtons = new QuestsButtons(_driver);
        }

        public void VisokaiaTemnitsaScript()
        {
            new GoToUrl().NavigateToUrl("https://m.vten.ru/quest/qHeroicHighDungeonDaily");
            _questsButtons.findGangButton.Click();
            _dungeonButtons.enterInDungeon.Click();
            _dungeonButtons.startBattle.Click();

            while (true)
            { 
                if (!_dungeonButtons.checkStopWave())
                {
                    _dungeonButtons.clickOnFirstAttackButton();
                }
                else if (_dungeonButtons.checkStopWave())
                {
                    _dungeonButtons.continueBattle.Click();
                }
                else if (_dungeonButtons.checkDungeonIsComplete())
                {
                    break;
                }
            }
            _dungeonButtons.giveReward.Click();
            _questsButtons.continueAdventures.Click();
        }
    }
}
