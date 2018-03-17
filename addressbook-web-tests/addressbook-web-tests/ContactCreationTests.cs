﻿using System;
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
			OpenHomePage();
			Login(new AccountData("admin", "secret"));
			InitContactCreation();
			FillContactForm(new Contact("Vladimir", "Logvinov"));
			SubmitContactCreation();
			ReturnToHomePage();
		}
	}
}
