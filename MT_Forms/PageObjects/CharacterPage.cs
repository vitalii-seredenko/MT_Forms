using System.Text.RegularExpressions;
using MT_Forms.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MT_Forms.PageObjects
{
    internal class CharacterPage
    {
        private readonly IWebDriver _driver;

        internal CharacterPage()
        {
            _driver = DriverSingleton.Driver;
            PageFactory.InitElements(_driver, this);
        }

        #region WebElements

        [FindsBy(How = How.XPath, Using = "//div[@class='small' and ./span]/span[2]")]
        internal IWebElement characterClassTextBox;

        [FindsBy(How = How.XPath, Using = "//ol[@class='mt3']/li[./span[contains(., 'Живучесть')]]/span[2]")]
        internal IWebElement characterHealthTextBox;
        [FindsBy(How = How.XPath, Using = "//ol[@class='mt3']/li[./span[contains(., 'Сила')]]/span[2]")]
        internal IWebElement characterStrangeTextBox;
        [FindsBy(How = How.XPath, Using = "//ol[@class='mt3']/li[./span[contains(., 'Защита')]]/span[2]")]
        internal IWebElement characterProtectionTextBox;
        [FindsBy(How = How.XPath, Using = "//ol[@class='mt3']/li[./span[contains(., 'Крит')]]/span[3]")]
        internal IWebElement characterCriticalDamageTextBox;
        [FindsBy(How = How.XPath, Using = "//ol[@class='mt3']/li[./span[contains(., 'Защита от чёрной магии')]]/span[2]")]
        internal IWebElement characterBlackMagicProtectionTextBox;
        [FindsBy(How = How.XPath, Using = "//ol[@class='mt3']/li[./span[contains(., 'Регенерация')]]/span[2]")]
        internal IWebElement characterRegenerationTextBox;

        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Гром и Молния']]/span[@class='info']")]
        internal IWebElement gromMolniaLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Невидимость']]/span[@class='info']")]
        internal IWebElement nevidimostLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Призыв']]/span[@class='info']")]
        internal IWebElement prizyvLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Ледяной Удар']]/span[@class='info']")]
        internal IWebElement ledianoiUdarLevelTextBox;

        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Взрыв Эфира']]/span[@class='info']")]
        internal IWebElement vzryvEfiraLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Приток Силы']]/span[@class='info']")]
        internal IWebElement pritokSilyLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Сферы Арканы']]/span[@class='info']")]
        internal IWebElement sferyArcanyLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Тень Смерти']]/span[@class='info']")]
        internal IWebElement tenSmertiLevelTextBox;

        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Защита Богов']]/span[@class='info']")]
        internal IWebElement zaschitaBogovLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Ярость Богов']]/span[@class='info']")]
        internal IWebElement iarostBogovLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Рывок Жизни']]/span[@class='info']")]
        internal IWebElement ryvokZhizniLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Талисман Доблести']]/span[@class='info']")]
        internal IWebElement talismanDoblestiLevelTextBox;

        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Листок Лотоса']]/span[@class='info']")]
        internal IWebElement listokLotosaLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Форма Демона']]/span[@class='info']")]
        internal IWebElement formaDemonaLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Проклятье Глайва']]/span[@class='info']")]
        internal IWebElement procliatieGlaivaLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Кровавый Цветок']]/span[@class='info']")]
        internal IWebElement krovaviiTsvetokLevelTextBox;

        #endregion

        internal string CutLettersFromHeroLevelTextBox(IWebElement heroAmuletLevelTextBox)
        {
            var regex = new Regex("\\d+");
            var levelMatch = regex.Match(heroAmuletLevelTextBox.Text);
            return levelMatch.Value;
        }

        internal string ReturnBlackMagicProtectionTextBoxTextIfElementPresent()
        {
            try
            {
                return characterBlackMagicProtectionTextBox.Displayed ? characterBlackMagicProtectionTextBox.Text : "0";
            }
            catch (NoSuchElementException)
            {
                return "0";
            }
        }
    }
}