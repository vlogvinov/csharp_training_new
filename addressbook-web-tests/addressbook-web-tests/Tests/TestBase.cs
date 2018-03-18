﻿using NUnit.Framework;
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
		protected ApplicationManager app;

		[SetUp]
		public void Setup()
		{
			app = new ApplicationManager();
			app.Navigator.GoToHomePage();
			app.Auth.Login(new AccountData("admin", "secret"));
		}

		[TearDown]
		public void Teardown()
		{
			app.Stop();
		}
	}
}
