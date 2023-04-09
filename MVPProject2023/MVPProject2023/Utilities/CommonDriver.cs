using MVPProject2023.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPProject2023.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(driver);
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
