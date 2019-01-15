using com.tbcbankgroup.PageObjects;
using NSelene;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace com.tbcbankgroup
{
    public class Class1
    {
        private readonly HomePage _homePage = new HomePage();
        private readonly SearchResultPage _searchResultPage = new SearchResultPage();


        [SetUp]
        public void InitDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            Selene.SetWebDriver(new ChromeDriver());
            Selene.GoToUrl("https://www.tbcbankgroup.com/");
        }

        [Test]
        public void FindByRequest()
        {
            var searchRequest = "TBC Bank CEO";

            _homePage.SearchByRequest(searchRequest);

            _searchResultPage.SearchResultItemByText(searchRequest)
                .Should(Have.Text(searchRequest));
        }

        [Test]
        public void FindByRequestOther()
        {
            var searchRequest = "PUBLIC OFFERING";

            _homePage.SearchByRequest(searchRequest);

            _searchResultPage.SearchResultItemByText(searchRequest)
                .Should(Have.Text(searchRequest));
        }

        [TearDown]
        public void TeardownDriver()
        {
            Selene.GetWebDriver().Quit();
        }
    }
}