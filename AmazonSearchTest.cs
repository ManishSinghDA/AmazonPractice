using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace AmazonAutomationPractise
{
    class AmazonSearchTest
    {

        IWebDriver driver;
        IWebElement element;

        [SetUp]

        public void StartBrowser()
        {
           // IWebDriver driver;
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.in");
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(300);

        }

        [Test]

        public void AmazonSearch()
        {

            //  element = driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[3]/div/form/div[1]/div/div")).Click(); 
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[3]/div/form/div[1]/div/div")).Click();
              var element = driver.FindElement(By.Id("searchDropdownBox"));
            // element.Click();
            System.Threading.Thread.Sleep(50);
            //var drpdown = driver.FindElement(By.Id("searchDropdownBox"));
            
            

            var selectElement = new SelectElement(element);
            selectElement.SelectByText("Baby");
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[3]/div/form/div[3]/div[1]/input")).SendKeys(("Johnson Diapers"));
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[3]/div/form/div[2]/div/input")).Click();
            System.Threading.Thread.Sleep(50);
           driver.FindElement(By.XPath("//*[@id="p_89/Johnson's"]")).Click();
            //*[@id="p_89/Johnson's"]
            //driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div[1]/div/div[3]/span/div/div[6]/ul/li[2]/span/a/span")).Click();
            //driver.FindElement(By.ClassName("a-size-base a-color-base")).Click();
            //driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div[1]/div/div[3]/span/div/div[6]/ul/li[1]")).Click();
            System.Threading.Thread.Sleep(50);

            ////selectElement.SelectByValue("search-alias=fashion");

            // var selectElement = new selectElement(searchDropdownBox);





        }
        [TearDown]

        public void TearDown()
        {
           // driver.Close();
        }

        private class selectElement
        {
        }
    }
}
