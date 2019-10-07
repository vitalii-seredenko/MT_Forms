using System;
using System.Threading;
using MT_Forms.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MT_Forms.PageObjects
{
    internal class DungeonButtons
    {
        private readonly IWebDriver _driver;
        public DungeonButtons()
        {
            _driver = DriverSingleton.Driver;
            PageFactory.InitElements(_driver, this);
        }

        Random random = new Random();

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Войти')]")]
        public IWebElement enterInDungeon;
        [FindsBy(How = How.XPath, Using = "//a[contains(., 'Начать бой')]")]
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
        public IWebElement giveRewardLink;

        public void ClickOnFirstAttackButton()
        {
            Thread.Sleep(random.Next(1500, 2500));
            firstAttackButton.Click();
        }

        public bool CheckWaveIsComplete()
        {
            try
            {
                return waveIsCompleteTextBlock.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool CheckDungeonIsComplete()
        {
            try
            {
                return dungeonIsCompleteTextBlock.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool CheckGiveRewardLinkIsVisible()
        {
            try
            {
                return giveRewardLink.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
