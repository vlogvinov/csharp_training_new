using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
	public class ContactHelper : HelperBase
	{
		public ContactHelper(IWebDriver driver) : base(driver)
		{
		
		}
		public void FillContactForm(Contact contact)
		{
			driver.FindElement(By.Name("firstname")).Click();
			driver.FindElement(By.Name("firstname")).Clear();
			driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
			driver.FindElement(By.Name("lastname")).Click();
			driver.FindElement(By.Name("lastname")).Clear();
			driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
		}

		public void InitContactCreation()
		{
			driver.FindElement(By.LinkText("add new")).Click();
		}

		public void SubmitContactCreation()
		{
			driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
		}

		public void ReturnToHomePage()
		{
			driver.FindElement(By.LinkText("home page")).Click();
		}
	}
}
