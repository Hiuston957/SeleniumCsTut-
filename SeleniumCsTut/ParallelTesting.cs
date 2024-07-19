using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumCsTut.BaseClass;
using OpenQA.Selenium.Support.UI;
using SeleniumCsTut.Utilities;


namespace SeleniumCsTut
{
    [TestFixture]
    public class ParallelTesting
    {
        IWebDriver driver;

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod1()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;

            var Driver = new BrowserUtility().Init(driver);
            var emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod2()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;

            var Driver = new BrowserUtility().Init(driver);
            var emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod3()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;

            var Driver = new BrowserUtility().Init(driver);
            var emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod4()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;

            var Driver = new BrowserUtility().Init(driver);
            var emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod5()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;

            var Driver = new BrowserUtility().Init(driver);
            var emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod6()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;

            var Driver = new BrowserUtility().Init(driver);
            var emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod7()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;

            var Driver = new BrowserUtility().Init(driver);
            var emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod8()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;

            var Driver = new BrowserUtility().Init(driver);
            var emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod9()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;

            var Driver = new BrowserUtility().Init(driver);
            var emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod10()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;

            var Driver = new BrowserUtility().Init(driver);
            var emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

    }
}
