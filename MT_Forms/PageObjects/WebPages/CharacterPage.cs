using System.Text.RegularExpressions;
using MT_Forms.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MT_Forms.PageObjects.WebPages
{
    internal class CharacterPage : GeneralBasePage
    {
        internal CharacterPage()
        {
            PageFactory.InitElements(driver, this);
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

        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Гром и Молния']]/span[@class='info' | @class='minor']")]
        internal IWebElement gromMolniaLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Невидимость']]/span[@class='info' | @class='minor']")]
        internal IWebElement nevidimostLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Призыв']]/span[@class='info' | @class='minor']")]
        internal IWebElement prizyvLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Ледяной Удар']]/span[@class='info' | @class='minor']")]
        internal IWebElement ledianoiUdarLevelTextBox;

        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Взрыв Эфира']]/span[@class='info' | @class='minor']")]
        internal IWebElement vzryvEfiraLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Приток Силы']]/span[@class='info' | @class='minor']")]
        internal IWebElement pritokSilyLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Сферы Арканы']]/span[@class='info' | @class='minor']")]
        internal IWebElement sferyArcanyLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Тень Смерти']]/span[@class='info' | @class='minor']")]
        internal IWebElement tenSmertiLevelTextBox;

        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Защита Богов']]/span[@class='info' | @class='minor']")]
        internal IWebElement zaschitaBogovLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Ярость Богов']]/span[@class='info' | @class='minor']")]
        internal IWebElement iarostBogovLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Рывок Жизни']]/span[@class='info' | @class='minor']")]
        internal IWebElement ryvokZhizniLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Талисман Доблести']]/span[@class='info' | @class='minor']")]
        internal IWebElement talismanDoblestiLevelTextBox;

        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Листок Лотоса']]/span[@class='info' | @class='minor']")]
        internal IWebElement listokLotosaLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Форма Демона']]/span[@class='info' | @class='minor']")]
        internal IWebElement formaDemonaLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Проклятье Глайва']]/span[@class='info' | @class='minor']")]
        internal IWebElement procliatieGlaivaLevelTextBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='mt3']/div[./a[.='Кровавый Цветок']]/span[@class='info' | @class='minor']")]
        internal IWebElement krovaviiTsvetokLevelTextBox;

        #endregion

        #region Methods

        internal string CutLettersFromHeroLevelTextBox(IWebElement heroAmuletLevelTextBox)
        {
            var regex = new Regex("\\d+");
            var levelMatch = regex.Match(heroAmuletLevelTextBox.ReturnElementTextIfElementPresent());
            return levelMatch.Value;
        }

        #endregion
    }
}