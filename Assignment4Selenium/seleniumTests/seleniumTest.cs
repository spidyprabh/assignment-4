using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace seleniumTests
{
    public class seleniumTest
    {
    [TestFixture]
    public class CreateNewUser
    {
      private IWebDriver driver;
      private StringBuilder verificationErrors;
      private string baseURL;
      private bool acceptNextAlert = true;

      [SetUp]
      public void SetupTest()
      {
        driver = new FirefoxDriver();
        baseURL = "https://qa-assignment-4.herokuapp.com/";
        verificationErrors = new StringBuilder();
      }

      [TearDown]
      public void TeardownTest()
      {
        try
        {
          driver.Quit();
        }
        catch (Exception)
        {
          // Ignore errors if unable to close the browser
        }
        Assert.AreEqual("", verificationErrors.ToString());
      }
      [Test]
      public void InputDetailsSearchBoxExpectedValueTest()
      {
        driver.Navigate().GoToUrl("https://qa-assignment-4.herokuapp.com/users");
        driver.FindElement(By.Id("search")).Click();
        driver.FindElement(By.Id("search")).Clear();
        driver.FindElement(By.Id("search")).SendKeys("prabhjyot");
        driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Users'])[1]/following::button[1]")).Click();
        Assert.AreEqual("Prabhjyot", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='prabhjyot.291@gmail.com'])[1]/following::td[1]")).Text);
      }
      [Test]
      public void TheJDPowerExpectedCarDisplayedTest()
      {
        driver.Navigate().GoToUrl("https://qa-assignment-4.herokuapp.com/users");
        driver.FindElement(By.Id("search")).Click();
        driver.FindElement(By.Id("search")).Clear();
        driver.FindElement(By.Id("search")).SendKeys("prabhjyot");
        driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Users'])[1]/following::button[1]")).Click();
        driver.FindElement(By.LinkText("JD URL")).Click();
        Assert.AreEqual("Select a 2018 Ford Focus trim level", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='See less'])[1]/following::h2[1]")).Text);
      }
      [Test]
      public void TheRequiredFieldsExpectedErrorDisplayedTest()
      {
        driver.Navigate().GoToUrl("https://qa-assignment-4.herokuapp.com/users");
        driver.FindElement(By.LinkText("New User")).Click();
        driver.FindElement(By.Id("user_email")).Click();
        driver.FindElement(By.Id("user_email")).Clear();
        driver.FindElement(By.Id("user_email")).SendKeys("manpreetkaur12@");
        driver.FindElement(By.Id("user_name")).Click();
        driver.FindElement(By.Id("user_name")).Clear();
        driver.FindElement(By.Id("user_name")).SendKeys("Manpreet Kaur");
        driver.FindElement(By.Id("user_address")).Click();
        driver.FindElement(By.Id("user_address")).Clear();
        driver.FindElement(By.Id("user_address")).SendKeys("Tr 14 west");
        driver.FindElement(By.Id("user_phone")).Click();
        driver.FindElement(By.Id("user_phone")).Clear();
        driver.FindElement(By.Id("user_phone")).SendKeys("654-780-9988");
        driver.FindElement(By.Id("user_city")).Click();
        driver.FindElement(By.Id("user_city")).Clear();
        driver.FindElement(By.Id("user_city")).SendKeys("Elmira");
        driver.FindElement(By.Id("user_vehicle_make")).Click();
        driver.FindElement(By.Id("user_vehicle_make")).Clear();
        driver.FindElement(By.Id("user_vehicle_make")).SendKeys("Ford");
        driver.FindElement(By.Id("user_vehicle_model")).Click();
        driver.FindElement(By.Id("user_vehicle_model")).Clear();
        driver.FindElement(By.Id("user_vehicle_model")).SendKeys("Mustang");
        driver.FindElement(By.Id("user_vehicle_year")).Click();
        driver.FindElement(By.Id("user_vehicle_year")).Clear();
        driver.FindElement(By.Id("user_vehicle_year")).SendKeys("2018");
        driver.FindElement(By.Name("commit")).Click();
        Assert.AreEqual("Email is invalid", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='New User'])[1]/following::li[1]")).Text);
        driver.FindElement(By.Id("user_name")).Click();
        driver.FindElement(By.Id("user_name")).Clear();
        driver.FindElement(By.Id("user_name")).SendKeys("");
        driver.FindElement(By.Name("commit")).Click();
        driver.FindElement(By.Id("user_email")).Click();
        driver.FindElement(By.Id("user_email")).Clear();
        driver.FindElement(By.Id("user_email")).SendKeys("manpreetkaur12@gmail.com");
        driver.FindElement(By.Id("user_name")).Click();
        driver.FindElement(By.Name("commit")).Click();
        Assert.AreEqual("Name can't be blank", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='New User'])[1]/following::li[1]")).Text);
        driver.FindElement(By.Id("user_name")).Click();
        driver.FindElement(By.Id("user_name")).Clear();
        driver.FindElement(By.Id("user_name")).SendKeys("Manpreet Kaur");
        driver.FindElement(By.Id("user_address")).Click();
        driver.FindElement(By.Id("user_address")).Clear();
        driver.FindElement(By.Id("user_address")).SendKeys("");
        driver.FindElement(By.Name("commit")).Click();
        Assert.AreEqual("Address can't be blank", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='New User'])[1]/following::li[1]")).Text);
        driver.FindElement(By.Id("user_address")).Click();
        driver.FindElement(By.Id("user_address")).Clear();
        driver.FindElement(By.Id("user_address")).SendKeys("14west");
        driver.FindElement(By.Id("user_phone")).Click();
        driver.FindElement(By.Id("user_phone")).Clear();
        driver.FindElement(By.Id("user_phone")).SendKeys("");
        driver.FindElement(By.Name("commit")).Click();
        Assert.AreEqual("Phone can't be blank", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='New User'])[1]/following::li[1]")).Text);
        driver.FindElement(By.Id("user_phone")).Click();
        driver.FindElement(By.Id("user_phone")).Clear();
        driver.FindElement(By.Id("user_phone")).SendKeys("647-445-4758");
        driver.FindElement(By.Id("user_city")).Click();
        driver.FindElement(By.Id("user_city")).Clear();
        driver.FindElement(By.Id("user_city")).SendKeys("");
        driver.FindElement(By.Name("commit")).Click();
        Assert.AreEqual("City can't be blank", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='New User'])[1]/following::li[1]")).Text);
        driver.FindElement(By.Id("user_city")).Click();
        driver.FindElement(By.Id("user_city")).Clear();
        driver.FindElement(By.Id("user_city")).SendKeys("Elmira");
        driver.FindElement(By.Id("user_vehicle_make")).Click();
        driver.FindElement(By.Name("commit")).Click();
      }
      [Test]
      public void TheTheEditValueExpectedValuesUpdatedTest()
      {
        driver.Navigate().GoToUrl("https://qa-assignment-4.herokuapp.com/");
        driver.FindElement(By.Id("search")).Click();
        driver.FindElement(By.Id("search")).Clear();
        driver.FindElement(By.Id("search")).SendKeys("prabhjyot");
        driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        driver.FindElement(By.LinkText("Edit")).Click();
        driver.FindElement(By.Id("user_city")).Click();
        driver.FindElement(By.Id("user_city")).Clear();
        driver.FindElement(By.Id("user_city")).SendKeys("Elmira");
        driver.FindElement(By.Name("commit")).Click();
        Assert.AreEqual("User was successfully updated.", driver.FindElement(By.Id("notice")).Text);
      }
      [Test]
      public void TheWrongPhoneNumberExpectedPhoneErrorTest()
      {
        driver.Navigate().GoToUrl("https://qa-assignment-4.herokuapp.com/users");
        driver.FindElement(By.LinkText("New User")).Click();
        driver.FindElement(By.Id("user_email")).Click();
        driver.FindElement(By.Id("user_email")).Clear();
        driver.FindElement(By.Id("user_email")).SendKeys("deepsingh@gmail.com");
        driver.FindElement(By.Id("user_name")).Click();
        driver.FindElement(By.Id("user_name")).Clear();
        driver.FindElement(By.Id("user_name")).SendKeys("Deep Singh");
        driver.FindElement(By.Id("user_address")).Click();
        driver.FindElement(By.Id("user_address")).Clear();
        driver.FindElement(By.Id("user_address")).SendKeys("23St.West Lukewood");
        driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Address'])[1]/following::label[1]")).Click();
        driver.FindElement(By.Id("user_phone")).Clear();
        driver.FindElement(By.Id("user_phone")).SendKeys("5564565555");
        driver.FindElement(By.Id("user_city")).Click();
        driver.FindElement(By.Id("user_city")).Clear();
        driver.FindElement(By.Id("user_city")).SendKeys("Elmira");
        driver.FindElement(By.Id("user_vehicle_make")).Click();
        driver.FindElement(By.Id("user_vehicle_make")).Clear();
        driver.FindElement(By.Id("user_vehicle_make")).SendKeys("GCM");
        driver.FindElement(By.Id("user_vehicle_model")).Click();
        driver.FindElement(By.Id("user_vehicle_model")).Clear();
        driver.FindElement(By.Id("user_vehicle_model")).SendKeys("Alcadia");
        driver.FindElement(By.Id("user_vehicle_year")).Click();
        driver.FindElement(By.Id("user_vehicle_year")).Clear();
        driver.FindElement(By.Id("user_vehicle_year")).SendKeys("2018");
        driver.FindElement(By.Name("commit")).Click();
        Assert.AreEqual("Phone is invalid", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='New User'])[1]/following::li[1]")).Text);
      }
      [Test]
      public void EnterNewUser_Expected_UserCreatedTest()
      {
        driver.Navigate().GoToUrl("https://qa-assignment-4.herokuapp.com/");
        driver.FindElement(By.LinkText("New User")).Click();
        driver.FindElement(By.Id("user_email")).Click();
        driver.FindElement(By.Id("user_email")).Clear();
        driver.FindElement(By.Id("user_email")).SendKeys("payal234@gmail.com");
        driver.FindElement(By.Id("user_name")).Click();
        driver.FindElement(By.Id("user_name")).Clear();
        driver.FindElement(By.Id("user_name")).SendKeys("Payal Batra");
        driver.FindElement(By.Id("user_address")).Click();
        driver.FindElement(By.Id("user_address")).Clear();
        driver.FindElement(By.Id("user_address")).SendKeys("234 st. Tropez road");
        driver.FindElement(By.Id("user_phone")).Click();
        driver.FindElement(By.Id("user_phone")).Clear();
        driver.FindElement(By.Id("user_phone")).SendKeys("226-889-4456");
        driver.FindElement(By.Id("user_city")).Click();
        driver.FindElement(By.Id("user_city")).Clear();
        driver.FindElement(By.Id("user_city")).SendKeys("Brampton");
        driver.FindElement(By.Id("user_vehicle_make")).Click();
        driver.FindElement(By.Id("user_vehicle_make")).Clear();
        driver.FindElement(By.Id("user_vehicle_make")).SendKeys("Ford");
        driver.FindElement(By.Id("user_vehicle_model")).Click();
        driver.FindElement(By.Id("user_vehicle_model")).Clear();
        driver.FindElement(By.Id("user_vehicle_model")).SendKeys("Focus");
        driver.FindElement(By.Id("user_vehicle_year")).Click();
        driver.FindElement(By.Id("user_vehicle_year")).Clear();
        driver.FindElement(By.Id("user_vehicle_year")).SendKeys("2018");
        driver.FindElement(By.Name("commit")).Click();
        Assert.AreEqual("User was successfully created.", driver.FindElement(By.Id("notice")).Text);
      }
      private bool IsElementPresent(By by)
      {
        try
        {
          driver.FindElement(by);
          return true;
        }
        catch (NoSuchElementException)
        {
          return false;
        }
      }

      private bool IsAlertPresent()
      {
        try
        {
          driver.SwitchTo().Alert();
          return true;
        }
        catch (NoAlertPresentException)
        {
          return false;
        }
      }

      private string CloseAlertAndGetItsText()
      {
        try
        {
          IAlert alert = driver.SwitchTo().Alert();
          string alertText = alert.Text;
          if (acceptNextAlert)
          {
            alert.Accept();
          }
          else
          {
            alert.Dismiss();
          }
          return alertText;
        }
        finally
        {
          acceptNextAlert = true;
        }
      }
    }
  }
}
