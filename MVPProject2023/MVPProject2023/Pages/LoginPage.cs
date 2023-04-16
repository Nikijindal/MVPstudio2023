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
    public class LoginPage : CommonDriver
    {
        IWebElement joinbutton => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/button"));
        IWebElement firstnametextbox => driver.FindElement(By.Name("firstName"));
        IWebElement lastnametextbox => driver.FindElement(By.Name("lastName"));
        IWebElement emailtextbox => driver.FindElement(By.Name("email"));
        IWebElement joinPwdtextbox => driver.FindElement(By.Name("email"));
        IWebElement confirmpwdtextbox => driver.FindElement(By.Name("confirmPassword"));
        IWebElement tncChkbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/div/input"));
        IWebElement joinbtn => driver.FindElement(By.XPath("//*[@id=\"submit-btn\"]"));
        IWebElement signinbtn => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        IWebElement signinemailtxtbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        IWebElement signinPwdtxtbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        IWebElement loginbtn => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        public void Openportal(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
        }

        public void JoinAction(IWebDriver driver)
        {
           
            joinbutton.Click();
            firstnametextbox.SendKeys("NJ");
            lastnametextbox.SendKeys("JN");
            emailtextbox.SendKeys("nj.jn@gmail.com");
            joinPwdtextbox.SendKeys("passwords10");
            confirmpwdtextbox.SendKeys("passwords10");
            tncChkbox.Click();
            joinbtn.Click();
            Wait.WaitToBeVisible(driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 8);
        }
        public void LoginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            //Hit Url - Launch Mars QA portal
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            signinbtn.Click();
            signinemailtxtbox.SendKeys("nik.j@gmail.com");
            signinPwdtxtbox.SendKeys("password10");
            loginbtn.Click();
            Thread.Sleep(3000);
        }
       
    }
}
