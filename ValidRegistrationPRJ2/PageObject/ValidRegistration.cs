using ValidRegistrationPRJ2.PageObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ValidRegistrationPRJ2.PageObject
{
    class ValidRegistration
    {

        public ValidRegistration() 
        {

            testrun = HooksRegistration.driver;

        }

        IWebDriver testrun;


        IWebElement Firstname => testrun.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(2) > input"));
        IWebElement Lastname => testrun.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(3) > input"));

        IWebElement Address => testrun.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(2) > div > textarea"));

        IWebElement Emailaddress => testrun.FindElement(By.CssSelector("#eid > input"));

        IWebElement Phonenumber => testrun.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(4) > div > input"));

        IWebElement Password => testrun.FindElement(By.CssSelector("#firstpassword"));

        IWebElement Confirmpassword => testrun.FindElement(By.CssSelector("#secondpassword"));

        IWebElement Hobbies => testrun.FindElement(By.CssSelector("#checkbox1"));

        IWebElement Gender => testrun.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(5) > div > label:nth-child(1) > input"));



        public void NavigateToWebsite()
        {
            testrun.Navigate().GoToUrl("https://demo.automationtesting.in/Register.html");
        }
        public void EnterFirstName()
        {
            Firstname.SendKeys("Ajibola");
        }
        public void EnterLastName()
        {
            Lastname.SendKeys("Michael");
        }
        public void EnterAddress()
        {
            Address.SendKeys("1 chorley st., Salord, UK");
        }
        public void EnterEmailAddress()
        {
            Emailaddress.SendKeys("ajibolamichael@gmail.com");
        }
        public void EnterPhoneNumber()
        {
            Phonenumber.SendKeys("07469563454");
        }
        public void ClickOnHbbies()
        {
            Hobbies.Click();
        }
        public void ClickOnGender()
        {
            Gender.Click();
        }
        public void EnterPassword()
        {
            Password.SendKeys("AjiMike22");
        }
        public void EnterConfirmPassword()
        {
            Confirmpassword.SendKeys("AjiMike22");
        }


    }
}
