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
		private IWebDriver driver;
		private StringBuilder verificationErrors;
		private string baseURL;
		protected LoginHelper loginHelper;
		protected NavigationHelper navigationHelper;
		protected GroupHelper groupHelper;
		protected ContactHelper contactHelper;

		[SetUp]
		public void SetupTest()
		{
			driver = new FirefoxDriver();
			baseURL = "http://addressbook/";
			verificationErrors = new StringBuilder();
			loginHelper = new LoginHelper(driver);
			navigationHelper = new NavigationHelper(driver, baseURL);
			groupHelper = new GroupHelper(driver);
			contactHelper = new ContactHelper(driver);
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
	}
}
