using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumPOM
{
    //EA login page
    class EALoginPage
    {
        /// <summary>
        /// class constructor initializing Page elements
        /// </summary>
        public EALoginPage()
        {
            PageFactory.InitElements(CommonProperties.WebDriver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        /// <summary>
        /// performs login to the EA login page
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public EAUserPage Login(string userName, string password)
        {
            txtUserName.EnterText(userName);
            txtPassword.EnterText(password);
            btnLogin.ClickElement();

            return new EAUserPage();
        }

    }
}
