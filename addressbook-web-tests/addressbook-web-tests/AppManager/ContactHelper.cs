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
		public ContactHelper(ApplicationManager manager) : base(manager)
		{
		
		}

		public ContactHelper Create(Contact contact)
		{
			InitContactCreation();
			FillContactForm(contact);
			SubmitContactCreation();
			ReturnToHomePage();
			return this;
		}
		public ContactHelper FillContactForm(Contact contact)
		{
			Type(By.Name("firstname"), contact.Firstname);
			Type(By.Name("lastname"), contact.Lastname);
			return this;
		}

		public ContactHelper InitContactCreation()
		{
			driver.FindElement(By.LinkText("add new")).Click();
			return this;
		}

		public ContactHelper SubmitContactCreation()
		{
			driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
			return this;
		}

		public ContactHelper ReturnToHomePage()
		{
			driver.FindElement(By.LinkText("home page")).Click();
			return this;
		}
	}
}
