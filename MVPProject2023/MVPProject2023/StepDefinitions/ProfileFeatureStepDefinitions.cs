using MVPProject2023.Pages;
using MVPProject2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MVPProject2023.StepDefinitions
{
    [Binding]
    public class ProfileFeatureStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        ProfilePage profilePageObj = new ProfilePage();

        [Given(@"I navigate to home page of Mars QA portal")]
        public void GivenINavigateToHomePageOfMarsQAPortal()
        {
            driver = new ChromeDriver();
            loginPageObj.Openportal(driver);
        }

        [When(@"I enter all fields on registration page")]
        public void WhenIEnterAllFieldsOnRegistrationPage()
        {
            loginPageObj.JoinAction(driver);
        }

        [Then(@"The user should be registered successfully")]
        public void ThenTheUserShouldBeRegisteredSuccessfully()
        {
            IWebElement Regpop = driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
            Assert.That(Regpop.Text == "Registration successful", "user is not registered successfully");
        }


        [Given(@"I logged into Mars QA portal successfully with valid credentials")]
        public void GivenILoggedIntoMarsQAPortalSuccessfullyWithValidCredentials()
        {
            driver = new ChromeDriver();
            loginPageObj.LoginActions(driver);
        }


        [When(@"I navigate to profile page")]
        public void WhenINavigateToProfilePage()
        {
            homePageObj.GotoProfilePage(driver);
        }

        [When(@"I create language,skills,education and certification record")]
        public void WhenICreateLanguageSkillsEducationAndCertificationRecord()
        {
            profilePageObj.createProfile(driver);
        }

        [When(@"select availability,hours and earn target")]
        public void WhenSelectAvailabilityHoursAndEarnTarget()
        {
            profilePageObj.createProfile1(driver);
        }

        
        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newlanguage = profilePageObj.Getlanguage(driver);

            Assert.That(newlanguage == "English", "Actual & expected language does not match");
            
        }
        

        [When(@"I update existing '([^']*)','([^']*)' on existing language record")]
        public void WhenIUpdateExistingOnExistingLanguageRecord(string language, string level)
        {
            profilePageObj.EditProfilelanguage(driver,language,level);
        }

        [Then(@"the record should have updated '([^']*)','([^']*)' successfully")]
        public void ThenTheRecordShouldHaveUpdatedSuccessfully(string language, string level)
        {
            string e1language = profilePageObj.editedlanguage(driver);
            string e1level = profilePageObj.editedlevel(driver);

            Assert.That(e1language == language, "Actual and edited language does not match");
            Assert.That(e1level == level,"Actual and edited level does not match");
        }

        [When(@"I delete existing record on existing language record page")]
        public void WhenIDeleteExistingRecordOnExistingLanguageRecordPage()
        {
            profilePageObj.DeleteProfilelanguage(driver);
            profilePageObj.DeleteProfileskills(driver);
            profilePageObj.DeleteProfileEducation(driver);
            profilePageObj.DeleteProfileCertifications(driver);
        }

        [Then(@"the record should be deleted successfully")]
        public void ThenTheRecordShouldBeDeletedSuccessfully()
        {
            IWebElement dlepopup = driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
            Assert.That(dlepopup.Text == "FirstAid & FireWarden has been deleted from your certification", "certification is not deleted successfully");
        }

        [AfterScenario]
        public void Teardown()
        {
            driver.Quit();  
        }

    }
}
