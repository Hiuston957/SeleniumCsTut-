using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumCsTut.BaseClass;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCsTut
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            var emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            IWebElement cookies = driver.FindElement(By.XPath(".//div[@aria-label='Zezwól na wszystkie pliki cookie']"));
            //cookies.Click();
            executor.ExecuteScript("arguments[0].click();", cookies);
            IWebElement registerBtn = driver.FindElement(By.XPath("//a[text()='Utwórz nowe konto'][@data-testid='open-registration-form-button']"));
            // registerBtn.Click();
            executor.ExecuteScript("arguments[0].click();", registerBtn);
            Thread.Sleep(3000);
            IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement el = new SelectElement(monthDropdownList);
            el.SelectByIndex(1);
            el.SelectByText("mar");
            el.SelectByValue("6");
        }

        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            var emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            var emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);
        }
    }
}
