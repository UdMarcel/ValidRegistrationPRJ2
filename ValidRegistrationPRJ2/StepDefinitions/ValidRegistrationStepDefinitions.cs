using ValidRegistrationPRJ2.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PJTValidRegistration.StepDefinitions
{
    [Binding]
    public class ValidRegistrationStepDefinitions
    {
        ValidRegistration registration;

        public ValidRegistrationStepDefinitions()

        {
            registration = new ValidRegistration();

        }
        [Given(@"I naviagte to the website")]
        public void GivenINaviagteToTheWebsite()
        {
            registration.NavigateToWebsite();
        }

        [Given(@"I enter my firstname")]
        public void GivenIEnterMyFirstname()
        {
            registration.EnterFirstName();
        }

        [Given(@"I enter last name")]
        public void GivenIEnterLastName()
        {
            registration.EnterLastName();
        }

        [Given(@"I enter my address")]
        public void GivenIEnterMyAddress()
        {
            registration.EnterAddress();
        }

        [Given(@"I enter my email address")]
        public void GivenIEnterMyEmailAddress()
        {
            registration.EnterEmailAddress();
        }

        [Given(@"I enter my phone number")]
        public void GivenIEnterMyPhoneNumber()
        {
            registration.EnterPhoneNumber();
        }

        [Given(@"I choose my gender")]
        public void GivenIChooseMyGender()
        {
            registration.ClickOnGender();
        }

        [Given(@"I choose my hobbies")]
        public void GivenIChooseMyHobbies()
        {
            registration.ClickOnHbbies();
        }

        [Given(@"I select my language")]
        public void GivenISelectMyLanguage()
        {
            throw new PendingStepException();
        }

        [Given(@"I select my skills")]
        public void GivenISelectMySkills()
        {
            throw new PendingStepException();
        }

        [Given(@"I select my country")]
        public void GivenISelectMyCountry()
        {
            throw new PendingStepException();
        }

        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            registration.EnterPassword();
        }
        [Given(@"I confirm my password")]
        public void GivenIConfirmMyPassword()
        {
            registration.EnterConfirmPassword();
        }

        [When(@"I click submit")]
        public void WhenIClickSubmit()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
