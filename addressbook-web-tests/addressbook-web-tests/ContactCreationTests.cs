using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebAddressbookTests
{
	[TestFixture]
	class ContactCreationTests : TestBase
	{ 
		[Test]
		public void ContactCreationTest()
		{
			navigationHelper.GoToHomePage();
			loginHelper.Login(new AccountData("admin", "secret"));
			contactHelper.InitContactCreation();
			contactHelper.FillContactForm(new Contact("Vladimir", "Logvinov"));
			contactHelper.SubmitContactCreation();
			contactHelper.ReturnToHomePage();
		}
	}
}
