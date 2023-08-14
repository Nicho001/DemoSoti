using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.StepDefinitions
{
    [Binding]
    internal class Login
    {
        [Given(@"entered valid username and password")]
        public void GivenEnteredValidUsernameAndPassword()
        {
            Console.WriteLine("Valid username n password");
        }

        [When(@"pressed submit button")]
        public void WhenPressedSubmitButton()
        {
            Console.WriteLine("Pressed submit button");
        }

        [Then(@"login successfull")]
        public void ThenLoginSuccessfull()
        {
            Console.WriteLine("Login is successfull");
        }

    }
}
