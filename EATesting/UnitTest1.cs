using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace EATesting
{
    [TestClass]
    public class UnitTest1
    {
        string url = "http://eaapp.somee.com/";
        private IWebDriver _driver;


        [TestMethod]
        public void TestMethod1()
        {
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl(url);
            Login();

        }


        public void Login()
        {
            _driver.FindElement(By.Id("loginLink")).Click();
            //username
            _driver.FindElement(By.Id("UserName")).SendKeys("admin");
            _driver.FindElement(By.Id("Password")).SendKeys("password");
            //click btn
            _driver.FindElement(By.CssSelector("input.btn")).Submit();
        }
    }
}
