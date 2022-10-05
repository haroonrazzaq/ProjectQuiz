using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.DevTools.V104.Browser;

namespace ProjectQuiz

{
    [TestClass]
    public class Automation
    {

        [TestMethod]
        public void sign_in()
        {

            IWebDriver driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Url = "https://automationexercise.com/";

            IWebElement singin = driver.FindElement(By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[4]/a"));
            singin.Click();

            IWebElement name = driver.FindElement(By.XPath("//input[@name='name']"));
            name.SendKeys("haroon");

            IWebElement email = driver.FindElement(By.XPath("//*[@id=\'form\']/div/div/div[3]/div/form/input[3]"));
            email.SendKeys("ilaijasam123@gmail.com");

            IWebElement btn = driver.FindElement(By.XPath("//button[text()=\"Signup\"]"));
            btn.Click();

            Thread.Sleep(5000);

            IWebElement radio = driver.FindElement(By.XPath("//*[@id=\'id_gender2\']"));

            radio.Click();

            IWebElement pass = driver.FindElement(By.XPath("//input[@id='password']"));

            pass.SendKeys("bhattiboy@");

            //dropdown

            var locationdrpdown = driver.FindElement(By.XPath("//select[@id=\'days\']"));
            var selectdrpdown = new SelectElement(locationdrpdown);
            selectdrpdown.SelectByIndex(0);

            //month
            var month = driver.FindElement(By.XPath("//select[@id=\'months\']"));
            var selectdrpdown2 = new SelectElement(month);
            selectdrpdown2.SelectByIndex(3);

            //year
            var year = driver.FindElement(By.XPath("//select[@id=\'months\']"));
            var selectdrpdown3 = new SelectElement(year);
            selectdrpdown3.SelectByIndex(13);


            IWebElement checkbox = driver.FindElement(By.XPath("//input[@id=\'newsletter\']"));

            checkbox.Click();





            IWebElement firstname = driver.FindElement(By.XPath("//input[@id=\'first_name\']"));
            firstname.SendKeys("Muhammad");


            IWebElement lastname = driver.FindElement(By.XPath("//input[@id=\'last_name\']"));
            lastname.SendKeys("haroon");

            IWebElement comp = driver.FindElement(By.XPath("//input[@id=\'company\']"));
            comp.SendKeys("contoursoftware");



            IWebElement address = driver.FindElement(By.XPath("//input[@id=\'address1\']"));
            address.SendKeys("saddat street micload Lahore");





            //country
            var country = driver.FindElement(By.XPath("//select[@id=\'country\']"));
            var drpdown2 = new SelectElement(country);
            drpdown2.SelectByIndex(3);

            //state
            IWebElement state = driver.FindElement(By.XPath("//input[@id=\'state\']"));
            state.SendKeys("usa");

            IWebElement city = driver.FindElement(By.XPath("//input[@id=\'city\']"));
            city.SendKeys("newyork");


            IWebElement postcode = driver.FindElement(By.XPath("//input[@id=\'zipcode\']"));
            postcode.SendKeys("5400");


            IWebElement num = driver.FindElement(By.XPath("//input[@id=\'mobile_number\']"));
            num.SendKeys("03034340191");



            IWebElement btn1 = driver.FindElement(By.XPath("//button[text()=\'Create Account\']"));
            btn1.Click();

        }


        [TestMethod]
        public void loginwith_valid()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Url = "https://automationexercise.com/";

            IWebElement singin = driver.FindElement(By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[4]/a"));
            singin.Click();


            IWebElement email = driver.FindElement(By.XPath("//*[@id=\'form\']/div/div/div[1]/div/form/input[2]"));
            email.SendKeys("ilaijasam123@gmail.com");

            IWebElement pass = driver.FindElement(By.XPath("//input[@name=\'password\']"));

            pass.SendKeys("bhattiboy@");

            IWebElement btn1 = driver.FindElement(By.XPath("//button[text()=\'Login\']"));
            btn1.Click();

        }


        [TestMethod]
        public void logout()
        {

            IWebDriver driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Url = "https://automationexercise.com/";


            IWebElement singin = driver.FindElement(By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[4]/a"));
            singin.Click();


            IWebElement email = driver.FindElement(By.XPath("//*[@id=\'form\']/div/div/div[1]/div/form/input[2]"));
            email.SendKeys("ilaijasam123@gmail.com");

            IWebElement pass = driver.FindElement(By.XPath("//input[@name=\'password\']"));

            pass.SendKeys("bhattiboy@");

            IWebElement btn1 = driver.FindElement(By.XPath("//button[text()=\'Login\']"));
            btn1.Click();


            //logout


            IWebElement clicklogout = driver.FindElement(By.XPath("//*[@id=\'header\']/div/div/div/div[2]/div/ul/li[4]/a"));
            clicklogout.Click();


        }

        [TestMethod]
        public void contact_us()
        {

            IWebDriver driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Url = "https://automationexercise.com/";

            IWebElement contact = driver.FindElement(By.XPath("//*[@id=\'header\']/div/div/div/div[2]/div/ul/li[9]/a"));
            contact.Click();


            IWebElement name = driver.FindElement(By.Name("//input[@name=\'name\']"));
            name.SendKeys("Haroon");

            IWebElement email = driver.FindElement(By.Name("//input[@name=\'email\']"));
            email.SendKeys("ilaijasam123@gmail.com");

            IWebElement subject = driver.FindElement(By.Name("//input[@name=\'email\']"));
            subject.SendKeys("SQA");



            IWebElement message = driver.FindElement(By.Name("//textarea[@id=\'message\']"));
            message.SendKeys("I have facing a issue");



            IWebElement file_choose = driver.FindElement(By.Name("upload_file"));
               file_choose.SendKeys("C:\\Users\\ilaij\\Downloads\\beauty.jpj");


            IWebElement click_btn = driver.FindElement(By.Name("submit"));

            click_btn.Click();


            driver.Close();



        }
        [TestMethod]
        public void check_out()
        { 
        
        
        
        }





    }
}