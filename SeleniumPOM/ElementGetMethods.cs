using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace SeleniumPOM
{
    /// <summary>
    /// Get methods for the page Web elements
    /// </summary>
    public static class ElementGetMethods
    {
        /// <summary>
        /// Gets the text Value of the textbox webelement
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static string GetText(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        /// <summary>
        /// Gets the Selected Value of the DropDown webelement 
        /// </summary>
        /// <param name="element"></param>
        /// <param name="elementType"></param>
        /// <returns></returns>
        public static string GetDropDownSelectedValue(this IWebElement element, PropertyType elementType)
        {
            return new SelectElement(element).AllSelectedOptions.FirstOrDefault().Text;
        }
    }
}
