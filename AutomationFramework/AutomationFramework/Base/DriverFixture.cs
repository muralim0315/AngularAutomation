using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using Protractor;

namespace AutomationFramework.Base
{
    public class DriverFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }
        public NgWebDriver ngDriver { get; private set; } 

        public DriverFixture(string browserType)
        {
            //Driver = new ChromeDriver();
            switch (browserType)
            {
                case "InternetExplorer":
                    Driver = new InternetExplorerDriver();
                    ngDriver = new NgWebDriver(Driver);
                    break;
                case "FireFox":
                    Driver = new FirefoxDriver();
                    ngDriver = new NgWebDriver(Driver);
                    break;
                case "Chrome":
                    Driver = new ChromeDriver();
                    ngDriver = new NgWebDriver(Driver);
                    break;
            }
        }

        public void Dispose()
        {
            Driver.Dispose();
        }


    }
 
}
