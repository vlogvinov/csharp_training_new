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
			manager.Navigator.GoToHomePage();
			InitContactCreation();
			FillContactForm(contact);
			SubmitContactCreation();
			ReturnToHomePage();
			return this;
		}

		public void EnsureContactsExist()
		{
			if (driver.FindElements(By.XPath("//tr[@name='entry']")).Count <= 0)
			{
				Create(new Contact("NewlyCreatedFirstName", "NewlyCreatedLastName"));
			}
		}

		public void Modify(int index, Contact contact)
		{
			manager.Navigator.GoToHomePage();
			SelectContact(index);
			InitContactModification(index);
			FillContactForm(contact);
			SubmitContactCreationModification();
		}

		public void SubmitContactCreationModification()
		{
			driver.FindElement(By.XPath("(//input[@value='Update'])[2]")).Click();
		}

		public void InitContactModification(int index)
		{
			driver.FindElement(By.XPath("(//tr[@name='entry'])[' + index +']//td[8]//img")).Click();
		}

		public ContactHelper Remove(int index)
		{
			manager.Navigator.GoToHomePage();
			SelectContact(index);
			RemoveContact();
			return this;
		}

		private void SelectContact(int index)
		{
			driver.FindElement(By.XPath("(//tr[@name='entry'])[" + index + "]//td[1]/input")).Click();
		}

		private void RemoveContact()
		{
			driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
			IAlert alert = driver.SwitchTo().Alert();
			alert.Accept();
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
