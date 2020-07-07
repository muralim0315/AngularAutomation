using OpenQA.Selenium;
using AutomationFramework.Browser;
//using SeleniumExtras.PageObjects;
using Protractor;
using AutomationFramework.Extensions;

namespace Test.Application.PageObjects
{
    class HomePage:Page
    {
       
        public HomePage(NgWebDriver ngdriver)
        {
            ngDriver = ngdriver;
           // PageFactory.InitElements(_driver, this);
            
        }

        protected override string PageUrl => "https://www.istockphoto.com/au";
        protected override string PageTitle => "Stock Images, Royalty-Free Pictures, Illustrations & Videos - iStock";

        public NgWebElement txtSearch
        {
            //get { return this.ngDriver.FindElement(By.XPath("non-default phrase")); }
            get { return this.ngDriver.FindElement(By.XPath("//input[@class='non-default phrase']")); }
        }

        public IWebElement btnSearch
        {
            get { return this.ngDriver.FindElement(By.ClassName("search-bar__submit")); }
        }


        public void serachImages()
        {
            ngDriver.Highlight(txtSearch, 1000);
            txtSearch.SendKeys("Goal");
            ngDriver.Highlight(btnSearch, 1000);
            btnSearch.Click();
        }

        //div[@class='suggestions-inner-container full-width']


    }
    }
