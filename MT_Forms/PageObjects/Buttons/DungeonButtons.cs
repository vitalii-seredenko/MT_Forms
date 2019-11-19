using System;
using MT_Forms.Core.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MT_Forms.PageObjects.Buttons
{
    internal class DungeonButtons
    {
        private readonly IWebDriver _driver;

        internal DungeonButtons()
        {
            _driver = DriverSingleton.Driver;
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

        internal bool WaveIsComplete()
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

        internal bool DungeonIsComplete()
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

        internal bool GiveRewardLinkIsPresent()
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
