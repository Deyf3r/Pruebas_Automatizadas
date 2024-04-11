using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V121.HeadlessExperimental;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Test_01
{
     class Program
    {

        static void Main(string[] args)
        {

            //-------------------------------------------------------------- Login --------------------------------------------------------------//

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            driver.Manage().Window.Maximize();

            IWebElement button = driver.FindElement(By.Id("login2"));
            button.Click();

            IWebElement input = driver.FindElement(By.Id("loginusername"));
            input.SendKeys("Daniel Acosta");

            IWebElement inputct = driver.FindElement(By.Id("loginpassword"));
            inputct.SendKeys("Deivimaxy1524+++");

            IWebElement buttonlogin2 = driver.FindElement(By.XPath("//button[@type='button' and text()='Log in']"));
            buttonlogin2.Click();


            driver.Url = "https://www.demoblaze.com/index.html";
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("TestLogin.png");


            ////-------------------------------------------------------------- Register --------------------------------------------------------------//

            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            driver.Manage().Window.Maximize();

            IWebElement buttonreg = driver.FindElement(By.Id("signin2"));
            buttonreg.Click();

            IWebElement inputreg = driver.FindElement(By.Id("sign-username"));
            inputreg.SendKeys("Daniel Acosta");

            IWebElement inputctreg = driver.FindElement(By.Id("sign-password"));
            inputctreg.SendKeys("Deivimaxy1524+++");

            IWebElement buttonregister = driver.FindElement(By.XPath("//button[@type='button' and text()='Sign up']"));
            buttonregister.Click();

            driver.Url = "https://www.demoblaze.com/index.html";
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Testregister.png");



            //-------------------------------------------------------------- Carrito --------------------------------------------------------------//

            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            driver.Manage().Window.Maximize();

            IWebElement buttoncart = driver.FindElement(By.Id("cartur"));
            buttoncart.Click();

            IWebElement buttonorder = driver.FindElement(By.CssSelector(".btn-success"));
            buttonorder.Click();

            IWebElement inputname = driver.FindElement(By.Id("name"));
            inputname.SendKeys("Boca Chula");

            IWebElement inputcountry = driver.FindElement(By.Id("country"));
            inputcountry.SendKeys("Republica Dominicana");

            IWebElement inputcity = driver.FindElement(By.Id("city"));
            inputcity.SendKeys("Santo Domingo");

            IWebElement inputcard = driver.FindElement(By.Id("card"));
            inputcard.SendKeys("2545 1515 1212 3223 2121");

            IWebElement inputyear = driver.FindElement(By.Id("month"));
            inputyear.SendKeys("04");

            IWebElement inputmonth = driver.FindElement(By.Id("year"));
            inputmonth.SendKeys("2007");

            IWebElement buttoncarrito = driver.FindElement(By.XPath("//button[@type='button' and text()='Purchase']"));
            buttoncarrito.Click();


            driver.Url = "https://www.demoblaze.com/cart.html";
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Testcart.png");



            //-------------------------------------------------------------- Categoria --------------------------------------------------------------//

            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            driver.Manage().Window.Maximize();


            IWebElement buttoncategory1 = driver.FindElement(By.LinkText("Phones"));
            buttoncategory1.Click();

            IWebElement buttoncategory2 = driver.FindElement(By.LinkText("Laptops"));
            buttoncategory2.Click();

            IWebElement buttoncategory3 = driver.FindElement(By.LinkText("Monitors"));
            buttoncategory3.Click();

            driver.Url = "https://www.demoblaze.com/index.html";
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Testcategorias.png");



            //-------------------------------------------------------------- Contacto --------------------------------------------------------------//

            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            driver.Manage().Window.Maximize();


            IWebElement buttoncontact = driver.FindElement(By.LinkText("Contact"));
            buttoncontact.Click();

            IWebElement inputemailcon = driver.FindElement(By.Id("recipient-email"));
            inputemailcon.SendKeys("marcos15@gmail.com");

            IWebElement inputnamecon = driver.FindElement(By.Id("recipient-name"));
            inputnamecon.SendKeys("Marcos De los Santos");

            IWebElement inputmessagecon = driver.FindElement(By.Id("message-text"));
            inputmessagecon.SendKeys("Muy bonita pagina, me encantó cada apartado y su facilidad de uso. ");

            driver.Url = "https://www.demoblaze.com/cart.html";
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Testcontacto.png");

            IWebElement buttoncontacto = driver.FindElement(By.XPath("//button[@type='button' and text()='Send message']"));
            buttoncontacto.Click();



            driver.Quit();


        }
    }
}
