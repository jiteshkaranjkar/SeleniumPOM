using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumPOM
{
    //EA User page
    class EAUserPage
    {
        /// <summary>
        /// constructor initializing Page elements
        /// </summary>
        public EAUserPage()
        {
            PageFactory.InitElements(CommonProperties.WebDriver, this);
        }

        /// <summary>
        /// 
        /// </summary>
        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement ddlTitleID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="titleId"></param>
        /// <param name="initial"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        public void FillUserForm(string titleId, string initial, string firstName, string middleName)
        {
            //enter username, password and then click login button
            //ddlTitleID.SendKeys(titleId);
            txtInitial.EnterText(initial);
            txtFirstName.EnterText(firstName);
            txtMiddleName.EnterText(middleName);
            btnSave.ClickElement();

        }
    }
}
