using MVPProject2023.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPProject2023.Pages
{
    public class LoginPage
    {
        public void Openportal(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
        }

        public void JoinAction(IWebDriver driver)
        {
           
            driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/button")).Click();
            driver.FindElement(By.Name("firstName")).SendKeys("NJ");
            driver.FindElement(By.Name("lastName")).SendKeys("JN");
            driver.FindElement(By.Name("email")).SendKeys("nj.jn@gmail.com");
            driver.FindElement(By.Name("password")).SendKeys("passwords10");
            driver.FindElement(By.Name("confirmPassword")).SendKeys("passwords10");
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/div/input")).Click();
            driver.FindElement(By.XPath("//*[@id=\"submit-btn\"]")).Click();
            Wait.WaitToBeVisible(driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 8);
        }
        public void LoginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            //Hit Url - Launch Mars QA portal
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys("nik.j@gmail.com");
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys("password10");
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();
            Thread.Sleep(3000);
        }
       
    }
}
