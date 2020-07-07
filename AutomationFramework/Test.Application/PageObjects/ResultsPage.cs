using AutomationFramework.Browser;
using AutomationFramework.Extensions;
using OpenQA.Selenium;
using Protractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.PageObjects
{
    class ResultsPage: Page
    {
        public ResultsPage(NgWebDriver ngdriver)
        {
            ngDriver = ngdriver;
            // PageFactory.InitElements(_driver, this);

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
            ngDriver.Highlight(btnNext, 4000);
            btnNext.Click();
        }
    }
}
