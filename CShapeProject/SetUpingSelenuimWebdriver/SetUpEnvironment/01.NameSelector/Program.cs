using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using NUnit.Framework;

class EntryPoint
{
    [TestFixture]
    public class Chrome_Sample_test
    {
        [Test(Description = "Check SauceLabs Homepage for Login Link")]
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://testing.todvachev.com/selectors/name/");
            IWebElement element = driver.FindElement(By.Name("myName"));

            if (element.Displayed)
            {
                GreenMessage("Yes, I can see the element, It's rigth there!!");
            }
            else
            {
                RedMessage("No, Someting wrong!");
            }
            driver.Close();
        }

        private static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            //Console.ForegroundColor = ConsoleColor.White;
        }

        private static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            //Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
