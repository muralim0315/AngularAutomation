using OpenQA.Selenium;
using AutomationFramework.Browser;
using SeleniumExtras.PageObjects;
using AutomationFramework.Base;
using NUnit.Framework;
using AutomationFramework.DriverFactory;
using Protractor;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using Test.Application.PageObjects;

namespace Test.Application.Tests
{

    class AppTest
    {
        NgWebDriver _ngDriver;
        private WebDriverWait wait;
        private Actions actions;

        [SetUp]
        public void BeforeScenario()
        {
            BrowserFactory.InitBrowser("Chrome");
            _ngDriver = BrowserFactory.NGDriver;
            _ngDriver.Manage().Cookies.DeleteAllCookies();
            wait = new WebDriverWait(_ngDriver, TimeSpan.FromSeconds(10));
            actions = new Actions(_ngDriver);
            _ngDriver.Manage().Window.Maximize();
           // _ngDriver.Navigate().GoToUrl("about:blank");
        }

        [TearDown]
        public void AfterScenario()
        {
            BrowserFactory.CloseAllDrivers();
        }

        [Test]
        public void SomeTest()
        {
            var homePage = new HomePage(_ngDriver);
            homePage.NavigateTo();
            homePage.serachImages();

        }
        [Test]
        public void DeleteBooking()
        {
   

        }

    }
}
