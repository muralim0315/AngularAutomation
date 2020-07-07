using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Protractor;

namespace AutomationFramework.Browser
{
    public class Page
    {
        
        protected NgWebDriver ngDriver;
        protected WebDriverWait ExplicitWait;
        protected virtual string PageUrl { get; }
        protected virtual string PageTitle { get; }

      
        public void NavigateTo()
        {
            ngDriver.Navigate().GoToUrl(PageUrl);
            EnsurePageLoaded();
        }

        /// <summary>
        /// Checks that the URL and page title are as expected
        /// </summary>
        /// <param name="onlyCheckUrlStartsWithExpectedText">Set to false to do an exact match of URL. Set to true to ignore fragments, query string, etc at end of browser URL</param>
        public void EnsurePageLoaded(bool onlyCheckUrlStartsWithExpectedText = true)
        {
            bool urlIsCorrect;

            if (onlyCheckUrlStartsWithExpectedText)
            {
                urlIsCorrect = ngDriver.Url.StartsWith(PageUrl);
            }
            else
            {
                urlIsCorrect = ngDriver.Url == PageUrl;
            }

            bool pageHasLoaded = urlIsCorrect && (ngDriver.Title == PageTitle);


            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page URL = '{ngDriver.Url}' Page Source: \r\n {ngDriver.PageSource}");
            }
        }
    }
}
