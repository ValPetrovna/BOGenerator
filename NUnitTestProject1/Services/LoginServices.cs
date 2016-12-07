using NUnitTestProject1.BO;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject1.Services
{
    class LoginServices
    {
        private IWebDriver driver;

        public LoginServices(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void goToLoginPage()
        {
            LoginPage page = new LoginPage(driver);
            page.EnterToLoginPage();
        }

        public Boolean singUpExists()
        {
            LoginPage page = new LoginPage(driver);
            return page.SignUpExists();
        }

        public void setLoginAndClickNext(Login login)
        {
            LoginPage page = new LoginPage(driver);
            page.SetLogin(login.getLogin()).ClickNext();
        }

        public Boolean singInExists()
        {
            LoginPage page = new LoginPage(driver);
            return page.SignInExists();
        }

        public void setPasswordAndClickSignIn(Login login)
        {
            LoginPage page = new LoginPage(driver);
            page.SetPassword(login.getPassword()).SigInClick();
        }

        public Boolean logoutExists()
        {
            LoginPage page = new LoginPage(driver);
            return page.LogotipExists();
        }

        public void gotoMailList()
        {
            MailListPage page = new MailListPage(driver);
            page.GoToMailPage();
        }

        public Boolean signOutExists()
        {
            MailListPage page = new MailListPage(driver);
            return page.SignOutExists();
        }

        public void logout()
        {
            LogoutPage page = new LogoutPage(driver);
            page.Logout();
        }

        public Boolean signInExists()
        {
            LogoutPage page = new LogoutPage(driver);
            return page.SignInExists();
        }

        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
