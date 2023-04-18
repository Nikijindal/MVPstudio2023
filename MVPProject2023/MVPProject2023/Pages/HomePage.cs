using MVPProject2023.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPProject2023.Pages
{
    public class HomePage : CommonDriver
    {
        IWebElement gotoProfilePage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
        public void GotoProfilePage(IWebDriver driver)
        {
            //Go to Profile Page 
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]")).Click();
        }
    }
}
