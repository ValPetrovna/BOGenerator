using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using NUnitTestProject1.Services;
using NUnitTestProject1.BO;
using NUnitTestProject1.TestData;

namespace NUnitTestProject1
{
    

    public class TestMyMail
    {
        private IWebDriver driver = new ChromeDriver();

        [Test, Order(1)]
        public void EnterToLoginPageTest()
        {
            LoginServices s = new LoginServices(driver);
            s.goToLoginPage();
            Assert.IsTrue(s.singUpExists());
        }

        
        [Test, Order(2)]
        public void LoginTest()
        {
            LoginServices s = new LoginServices(driver);
            Login login = BOGenerator.generateSimpleLogin();

            s.setLoginAndClickNext(login);
            Assert.IsTrue(s.singInExists());
        }

        
        [Test, Order(3)]
        public void PasswordTest()
        {
            LoginServices s = new LoginServices(driver);
            Login login = BOGenerator.generateSimpleLogin();

            s.setPasswordAndClickSignIn(login);
            Assert.IsTrue(s.logoutExists());
        }

        [Test, Order(4)]
        public void EnterToMailLstPageTest()
        {
            LoginServices s = new LoginServices(driver);
            s.gotoMailList();
            Assert.IsTrue(s.signOutExists());
        }

        
        [Test, Order(5)]
        public void LogoutTest()
        {
            LoginServices s = new LoginServices(driver);
            s.logout();
            Assert.IsTrue(s.signInExists());
            
            s.closeBrowser();
        }

    }

}

