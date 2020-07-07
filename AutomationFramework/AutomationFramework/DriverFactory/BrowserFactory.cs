using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Protractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.DriverFactory
{
   public class BrowserFactory
    {
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        private static IWebDriver driver;
        private static NgWebDriver ngdriver;

        public static IWebDriver Driver
        {
            get
            {
                //if (driver == null)
                //    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return driver;
            }
            private set
            {
                driver = value;
            }
        }
        public static NgWebDriver NGDriver
        {
            get
            {
                if (ngdriver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return ngdriver;
            }
            private set
            {
                ngdriver = value;
            }
        }


        public static void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    if (Driver == null)
                    {
                        driver = new FirefoxDriver();
                        ngdriver = new NgWebDriver(driver);
                        Drivers.Add("Firefox", Driver);
                    }
                    break;

                case "IE":
                    if (Driver == null)
                    {
                        //driver = new InternetExplorerDriver(@"C:\PathTo\IEDriverServer");
                        //Drivers.Add("IE", Driver);
                    }
                    break;

                case "Chrome":
                    if (Driver == null)
                    {
                        driver = new ChromeDriver();
                        Drivers.Add("Chrome", Driver);
                        ngdriver = new NgWebDriver(driver);
                    }
                    break;
            }
        }

        public static void LoadApplication(string url)
        {
            Driver.Url = url;
        }

        public static void CloseAllDrivers()
        {
            foreach (var key in Drivers.Keys)
            {
                Drivers[key].Close();
                Drivers[key].Quit();
            }
        }
    }
}
