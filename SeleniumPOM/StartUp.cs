using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using SeleniumPOM.Entities;
using SeleniumPOM.Utils;
using System;
using System.Collections.Generic;
using System.Data;

namespace SeleniumPOM
{
    [TestClass]
    public class StartUp
    {
        public StartUp()
        {
            //initialize Chrome driver 
            CommonProperties.WebDriver = new ChromeDriver();
        }

        [TestInitialize]
        public void Initialize()
        {
            //Navigate to the given URL
            CommonProperties.WebDriver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            //CommonProperties.WebDriver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");

            Console.WriteLine("Navigate to the given URL");
        }

        [TestMethod]
        public void ExecuteTest()
        {
            DataTable dt =  ExcelLib.ReadExcelFile();

            //Create instance of Login Page to login
            EALoginPage loginPage = new EALoginPage();
            List<EntityEA> lstEA = CommonFunctions.DataTabletoList(dt);
            EAUserPage userPage = loginPage.Login(lstEA[0].UserName, lstEA[0].Password);
                        
            userPage.FillUserForm("Mr.", lstEA[0].Initial, lstEA[0].FirstName, lstEA[0].MiddleName);
        }

        [TestCleanup]
        public void CleanUp()
        {
            //close chrome browser
            CommonProperties.WebDriver.Close();
            Console.WriteLine("Close chrome browser");
        }
    }
}
