using CatalogueProject.Hooks;
using CatalogueProject.PageObject;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace CatalogueProject.StepDefinitions
{
    [Binding]
    public class SearchStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        SearchPage searchPage = new SearchPage();

        [Given(@"I navigate to the website ""([^""]*)""")]
        public void GivenINavigateToTheWebsite(string Url)
        {
            driver.Navigate().GoToUrl(Url);
        }

        [When(@"I add four random items to my cart")]
        public void WhenIAddFourRandomItemsToMyCart()
        {
            searchPage.ClickFourRandomItems();
        }

        [When(@"I view my cart")]
        public void WhenIViewMyCart()
        {
            searchPage.VewMycart(); 
        }

        [When(@"I search for lowest price items")]
        public void WhenISearchForLowestPriceItems()
        {
            
        }


        [When(@"I am able to remove the lowest price item from my cart")]
        public void WhenIAmAbleToRemoveTheLowestPriceItemFromMyCart()
        {
            searchPage.LowestPriceItemRemoved();
        }

        [Then(@"I am able to verify three items in my cart")]
        public void ThenIAmAbleToVerifyThreeItemsInMyCart()
        {
            searchPage.VerifyFouritemsinmycart();
        }
    }
}
