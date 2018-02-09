using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary2
{

    public class Class1
    {
        [Test]
        public void Run()
        {
            IWebDriver driver = new FirefoxDriver(@"C:\");
            driver.Navigate().GoToUrl("http://javaguru.lv");
            Thread.Sleep(5000);
            driver.Close();
        }

    }
}
