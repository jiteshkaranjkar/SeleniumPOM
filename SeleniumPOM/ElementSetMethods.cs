using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumPOM
{
    /// <summary>
    /// Set values of the page Web elements
    /// </summary>
    public static class ElementSetMethods
    {
        /// <summary>
        /// Extension method for entering text in the webElement control
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        /// <summary>
        /// Extension method to click the webElement control
        /// </summary>
        /// <param name="element"></param>
        public static void ClickElement(this IWebElement element)
        {
            element.Submit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
