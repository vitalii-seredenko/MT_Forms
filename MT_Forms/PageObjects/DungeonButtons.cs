using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace PageObjects
{
    class DungeonButtons
    {
        private IWebDriver _driver;
        public DungeonButtons(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        WebDriverWait explicitWait;
        Random random = new Random();

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Войти')]")]
        public IWebElement enterInDungeon;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Начать бой')]")]
        public IWebElement startBattle;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Добивать') or contains(text(),'Бить')]")]
        public IWebElement firstAttackButton;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Этап подземелья ') or contains(text(), 'Подземелье ')]")]
        public IWebElement dungeonOrWaveIsCompleteTextBlock;
        [FindsBy(How = How.XPath, Using = "//span[contains(contains(text(), 'Подземелье ')]")]
        public IWebElement dungeonIsCompleteTextBlock;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Этап подземелья ')]")]
        public IWebElement waveIsCompleteTextBlock;
        [FindsBy(How = How.XPath, Using = "//a[contains(., 'Продолжить бой')]")]
        public IWebElement continueBattle;
        [FindsBy(How = How.XPath, Using = "//a[contains(., 'Получить награду')]")]
        public IWebElement giveReward;

        public void clickOnFirstAttackButton()
        {
            Thread.Sleep(random.Next(1500, 2500));
            firstAttackButton.Click();
        }

        public bool checkStopWave()
        {
            try
            {
                bool a = waveIsCompleteTextBlock.Displayed;
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool checkDungeonIsComplete()
        {
            try
            {
                bool a = dungeonIsCompleteTextBlock.Displayed;
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
