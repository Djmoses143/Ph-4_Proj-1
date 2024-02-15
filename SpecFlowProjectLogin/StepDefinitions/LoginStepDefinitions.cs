using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary13feb;

namespace SpecFlowProjectLogin.StepDefinitions
{
    public class LoginStepDefinitions
    {
        private string userName;
        private string password;
        private string loginResult;
        private readonly ScenarioContext scenarioContext;
        private readonly Login userLogin;
        

        public LoginStepDefinitions(ScenarioContext sc)
        {
            this.scenarioContext = sc;
            userLogin = new ClassLibrary13feb.Login();
        }
        [Given(@"a user with valid username ""([^""]*)"" and valid password ""([^""]*)""")]
        
        public void GivenAUserWithValidUsernameAndValidPassword(string p0, string p1)
        {
            userName = p0;
            password = p1;
        }
        [When(@"the LoginDetails method is called")]
        public void WhenTheLoginDetailsMethodIsCalled()
        {
            loginResult=userLogin.LoginDetails(userName, password);
        }
        [Then(@"the result should be Login Success")]
        public void ThenTheResultShouldBeLoginSuccess()
        {
            Assert.Equal("Login Success", loginResult);
        }

        [Given(@"a user with invalid username ""([^""]*)"" and invalid password ""([^""]*)""")]
        public void GivenAUserWithInvalidUsernameAndInvalidPassword(string p0, string invalid)
        {
            userName = p0;
            password = invalid;
        }
        //[When(@"the LoginDetails methods is called")]
        //public void WhenTheLoginDetailsMethodsIsCalled()
        //{
        //    loginResult = userLogin.LoginDetails(userName, password);
        //}
        [Then(@"the result should be Login Failed")]
        public void ThenTheResultShouldBeLoginFailed()
        {
            Assert.Equal("Login Failed", loginResult);
        }
    }
}