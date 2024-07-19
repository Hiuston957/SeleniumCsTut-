using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsTut
{
    [TestFixture]
    public class SeleniumCSharpTutorial04
    {
        [Test]
        [Author("Lukasz Kuynski", "lukasz.kutynski@microsoft.wsei.edu.pl")]
        [Description("Facebook login Verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(String urlName) 
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                // driver.Url = "https://www.facebook.com/";
                driver.Url = urlName;
                var emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
                //var emailTextField = driver.FindElement(By.XPath(".//*[@id='eail']"));

                emailTextField.SendKeys("Selenium C#");
                driver.Quit();
            } catch (Exception e) {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                // string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                screenshot.SaveAsFile("D:\\repos\\SeleniumCsTut\\SeleniumCsTut\\Screenshots\\s1.jpeg");
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if(driver != null) driver.Quit();
            }
        }

        static IList DataDrivenTesting()
        {
            var list = new List<string>();
            list.Add("https://www.facebook.com/");
            //list.Add("https://www.youtube.com/");
            //list.Add("https://www.gmail.com/");

            return list;
        }

        //[Test]
        //[Author("author name", "author email")]
        //[Description("Facebook login Verify")]
        //public void Test2()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://www.facebook.com/";
        //    var emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
        //    emailTextField.SendKeys("Selenium C#");
        //    driver.Quit();
        //}

    }
}
