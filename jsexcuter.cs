using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntY.Cascade.ManagementPortal.UiTests.Tests
{
    [TestClass]
    public class Dummy
    {
        [TestMethod]
        public void Products_AddMultipleSKUPage()
        {
            IWebDriver driver = new ChromeDriver();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.Navigate().GoToUrl("https://cascadetest-productmanagement.azurewebsites.net/");
            Thread.Sleep(9000);

            IWebElement userName = driver.FindElement(By.Name("username"));
            IWebElement Password = driver.FindElement(By.Name("password"));
            IWebElement login = driver.FindElement(By.CssSelector(".btn.btn-primary"));


            userName.SendKeys("preethy.ramamoorthy@systemowner.net");
            Thread.Sleep(5000);
            Password.SendKeys("PASSword#1");
            Thread.Sleep(5000);
            driver.FindElement(By.CssSelector(".btn.btn-primary")).Click();
            Thread.Sleep(5000);

            //driver.FindElement(By.CssSelector("#shared-product-details > div > div.shared-product-details-fields > div:nth-child(2) > input")).Click();
            IWebElement name = driver.FindElement(By.CssSelector("#shared-product-details > div > div.shared-product-details-fields > div:nth-child(2) > input"));
            name.SendKeys("abc");
            Thread.Sleep(9000);

            driver.Close();
        }
    }
}
