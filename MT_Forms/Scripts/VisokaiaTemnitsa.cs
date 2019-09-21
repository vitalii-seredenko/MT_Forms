using PageObjects;
using Core;
using OpenQA.Selenium;
using CommonMethods;

namespace Scripts
{
    class VisokaiaTemnitsa
    {
        IWebDriver driver = DriverSingletone.Driver;
        DungeonButtons dungeonButtons;
        QuestsButtons questsButtons;

        public VisokaiaTemnitsa()
        {
            dungeonButtons = new DungeonButtons(driver);
            questsButtons = new QuestsButtons(driver);
        }

        public void VisokaiaTemnitsaScript()
        {
            new GoToUrl().NavigateToUrl("https://m.vten.ru/quest/qHeroicHighDungeonDaily");
            questsButtons.findGangButton.Click();
            dungeonButtons.enterInDungeon.Click();
            dungeonButtons.startBattle.Click();

            while (true)
            {
                dungeonButtons.clickOnFirstAttackButton();
                if (dungeonButtons.checkStopWave())
                {
                    dungeonButtons.clickOnFirstAttackButton();
                }
                else if (dungeonButtons.checkDungeonIsComplete())
                {
                    break;
                }
            }

            dungeonButtons.giveReward.Click();
            questsButtons.continueAdventures.Click();
        }
    }
}
