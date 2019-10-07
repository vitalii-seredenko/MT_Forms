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
        internal DungeonButtons()
        {
            _driver = DriverSingleton.Driver;
            _random = new Random();
            PageFactory.InitElements(_driver, this);
        }

        #region WebElements

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Войти')]")]
        internal IWebElement enterInDungeon;
        [FindsBy(How = How.XPath, Using = "//a[contains(., 'Начать бой')]")]
        internal IWebElement startBattle;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Добивать') or contains(text(),'Бить')]")]
        internal IWebElement firstAttackButton;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Этап подземелья ') or contains(text(), 'Подземелье ')]")]
        internal IWebElement dungeonOrWaveIsCompleteTextBlock;
        [FindsBy(How = How.XPath, Using = "//span[contains(contains(text(), 'Подземелье ')]")]
        internal IWebElement dungeonIsCompleteTextBlock;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Этап подземелья ')]")]
        internal IWebElement waveIsCompleteTextBlock;
        [FindsBy(How = How.XPath, Using = "//a[contains(., 'Продолжить бой')]")]
        internal IWebElement continueBattle;
        [FindsBy(How = How.XPath, Using = "//a[contains(., 'Получить награду')]")]
        internal IWebElement giveRewardLink;

        #endregion

        internal void ClickOnFirstAttackButton()
        {
            Thread.Sleep(_random.Next(1500, 2500));
            firstAttackButton.Click();
        }

        internal bool CheckWaveIsComplete()
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

        internal bool CheckDungeonIsComplete()
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

        internal bool CheckGiveRewardLinkIsPresent()
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
