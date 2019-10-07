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
        private readonly Random _random;
        public DungeonButtons()
        {
            _driver = DriverSingleton.Driver;
            _random = new Random();
            PageFactory.InitElements(_driver, this);
        }

        #region WebElements

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

        #endregion

        public void ClickOnFirstAttackButton()
        {
            Thread.Sleep(_random.Next(1500, 2500));
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

        public bool CheckGiveRewardLinkIsPresent()
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
