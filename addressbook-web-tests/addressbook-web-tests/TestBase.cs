using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
	class TestBase
	{
		private IWebDriver driver;
		private StringBuilder verificationErrors;
		private string baseURL;
		private bool acceptNextAlert = true;

		[SetUp]
		public void SetupTest()
		{

			driver = new FirefoxDriver();
			baseURL = "http://addressbook/";
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

		protected void ReturnToGroupsPage()
		{
			driver.FindElement(By.LinkText("group page")).Click();
		}

		protected void SumbitGroupCreation()
		{
			driver.FindElement(By.Name("submit")).Click();
		}

		protected void FillGroupForm(string name, string header, string footer)
		{
			driver.FindElement(By.Name("group_name")).Click();
			driver.FindElement(By.Name("group_name")).Clear();
			driver.FindElement(By.Name("group_name")).SendKeys(name);
			driver.FindElement(By.Name("group_header")).Click();
			driver.FindElement(By.Name("group_header")).Clear();
			driver.FindElement(By.Name("group_header")).SendKeys(header);
			driver.FindElement(By.Name("group_footer")).Click();
			driver.FindElement(By.Name("group_footer")).Clear();
			driver.FindElement(By.Name("group_footer")).SendKeys(footer);
		}

		protected void InitGroupCreation()
		{
			driver.FindElement(By.XPath("(//input[@name='new'])[2]")).Click();
		}

		protected void GoToGroupsPage()
		{
			driver.FindElement(By.XPath("//li[@class='admin']/a[@href='group.php']")).Click();
		}

		protected void Login(AccountData account)
		{
			driver.FindElement(By.Name("user")).Click();
			driver.FindElement(By.Name("user")).Clear();
			driver.FindElement(By.Name("user")).SendKeys(account.Username);
			driver.FindElement(By.Name("pass")).Clear();
			driver.FindElement(By.Name("pass")).SendKeys(account.Password);
			driver.FindElement(By.XPath("//input[@value='Login']")).Click();
		}

		protected void OpenHomePage()
		{
			driver.Navigate().GoToUrl(baseURL);
		}

		protected void RemoveGroup()
		{
			driver.FindElement(By.Name("delete")).Click();
		}

		protected void SelectGroup(int index)
		{
			driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
		}

		protected void FillContactForm(Contact contact)
		{
			driver.FindElement(By.Name("firstname")).Click();
			driver.FindElement(By.Name("firstname")).Clear();
			driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
			driver.FindElement(By.Name("lastname")).Click();
			driver.FindElement(By.Name("lastname")).Clear();
			driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
		}

		protected void InitContactCreation()
		{
			driver.FindElement(By.LinkText("add new")).Click();
		}

		protected void SubmitContactCreation()
		{
			driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
		}

		protected void ReturnToHomePage()
		{
			driver.FindElement(By.LinkText("home page")).Click();
		}
	}
}
