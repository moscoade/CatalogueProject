using CatalogueProject.Hooks;
using OpenQA.Selenium;
using System.Diagnostics;
using System.Threading;

namespace CatalogueProject.PageObject
{
    class SearchPage
    {
        public IWebDriver driver;
        private By firstItem = By.XPath("//a[@aria-label='Add “Ninja Silhouette” to your cart']");
        private By secondItem = By.CssSelector(".button.product_type_simple.add_to_cart_button.ajax_add_to_cart[href='?add-to-cart=51']");
        private By thridItem = By.XPath("//a[@aria-label='Add “Woo Album #1” to your cart']");
        private By fourthItem = By.CssSelector("a[aria-label='Add “Ship Your Idea” to your cart']");
        private By vewCart = By.XPath("//a[normalize-space()='Cart']");
        private By lowPrice = By.XPath("//body[1]/div[1]/div[1]/div[2]/div[1]/main[1]/article[1]/div[1]/div[1]/form[1]/table[1]/tbody[1]/tr[3]/td[1]/a[1]");
        private By update = By.CssSelector("button[value='Update cart']");
        public SearchPage()
        {
            driver = BaseTest.driver;
        }

        public void ClickFourRandomItems()
        {
            driver.FindElement(firstItem).Click();
            driver.FindElement(secondItem).Click();
            driver.FindElement(thridItem).Click();
            driver.FindElement(fourthItem).Click();
        }

        public void VewMycart()
        {
            Thread.Sleep(2000);
            driver.FindElement(vewCart).Click();
        }


        

        
        public void LowestPriceItemRemoved()
        {
            driver.FindElement(lowPrice).Click();
        }
       


        public bool VerifyFouritemsinmycart()
        {
            return driver.Url.Contains("https://cms.demo.katalon.com/cart/");
        }
        
       

    }
}
