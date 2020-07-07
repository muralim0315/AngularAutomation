using OpenQA.Selenium;
using Protractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationFramework.Extensions
{
   public static class Extensions
    {
        public static void Highlight(this NgWebDriver driver, IWebElement element, int highlight_timeout = 100, int px = 3, string color = "yellow")
        {
            IWebDriver context = driver.WrappedDriver;
            ((IJavaScriptExecutor)context).ExecuteScript("arguments[0].style.border='" + px + "px solid " + color + "'", element);
            Thread.Sleep(highlight_timeout);
            ((IJavaScriptExecutor)context).ExecuteScript("arguments[0].style.border=''", element);
        }
    }
}
