using OpenQA.Selenium;
using Core;
using PageObjects;

namespace MT_Main
{
    public class MT_Main
    {
        IWebDriver driver;
        LoginPage loginPage;
        BaseTownPage baseTownPage;
        DungeonButtons dungeonButtons;
        QuestsButtons questsButtons;

        public void SetUp()
        {
            driver = DriverSingletone.Driver;
            driver.Manage().Window.Maximize();
            loginPage = new LoginPage(driver);
            baseTownPage = new BaseTownPage(driver);
            dungeonButtons = new DungeonButtons(driver);
            questsButtons = new QuestsButtons(driver);

            driver.Navigate().GoToUrl("https://m.vten.ru/");

            loginPage.startGameButton.Click();
            loginPage.inputLogin.SendKeys("Друг Инженера");
            loginPage.inputPassword.SendKeys("paleksanov4194");
            loginPage.submitButton.Click();
        }

        public void TearDown()
        {
            //driver.Dispose();
            //driver.Quit();
        }

        public void VisokaiaTemnitsa()
        {
            driver.Navigate().GoToUrl("https://m.vten.ru/quest/qHeroicHighDungeonDaily");
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

        public void AdskieRazvaliny()
        {
            driver.Navigate().GoToUrl("https://m.vten.ru/dungeon/description/dHellRuins");
            dungeonButtons.enterInDungeon.Click();
            dungeonButtons.startBattle.Click();

            while (true)
            {
                dungeonButtons.clickOnFirstAttackButton();
                if (dungeonButtons.checkStopWave())
                {
                    break;
                }
            }
        }
    }
}