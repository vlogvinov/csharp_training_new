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
	class ContactCreationTests : AuthTestBase
	{ 
		[Test]
		public void ContactCreationTest()
		{
			Contact contact = new Contact("Vladimir", "Logvinov");
			app.Contacts.Create(contact);
		}
	}
}
