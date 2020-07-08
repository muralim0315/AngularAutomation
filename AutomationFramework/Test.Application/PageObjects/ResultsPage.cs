using AutomationFramework.Browser;
using AutomationFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

using Protractor;

namespace Test.Application.PageObjects
{
    class ResultsPage: Page
    {
        Actions _actions;
        IJavaScriptExecutor js;
        public ResultsPage(NgWebDriver ngdriver)
        {
            ngDriver = ngdriver;
            // PageFactory.InitElements(_driver, this);
             _actions = new Actions(ngDriver.WrappedDriver);
            js = (IJavaScriptExecutor)ngdriver;

        }

        //protected override string PageUrl => "https://www.istockphoto.com/au";
        protected override string PageTitle => "Goal Stock Photos, Pictures & Royalty-Free Images1";

        public NgWebElement btnStrategy
        {
            get { return this.ngDriver.FindElement(By.XPath("//h5[text()='strategy']")); }
        }

        public IWebElement btnNext
        {
            get { return this.ngDriver.FindElement(By.XPath("//div[text()='Next']")); }
        }

        public void FindStrategy()
        {
            ngDriver.Highlight(btnStrategy, 1000);
            btnStrategy.Click();
         
            _actions.MoveToElement(btnNext).Build().Perform();
            //ngDriver.ExecuteScript("arguments[0].scrollIntoView();", btnNext);
            ngDriver.Highlight(btnNext, 5000);
            btnNext.Click();
           
        }
    }
}
