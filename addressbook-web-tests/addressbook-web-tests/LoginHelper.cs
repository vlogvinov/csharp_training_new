﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
	public class LoginHelper : HelperBase
	{

		public LoginHelper(IWebDriver driver) : base(driver)
		{

		}
		public void Login(AccountData account)
		{
			driver.FindElement(By.Name("user")).Click();
			driver.FindElement(By.Name("user")).Clear();
			driver.FindElement(By.Name("user")).SendKeys(account.Username);
			driver.FindElement(By.Name("pass")).Clear();
			driver.FindElement(By.Name("pass")).SendKeys(account.Password);
			driver.FindElement(By.XPath("//input[@value='Login']")).Click();
		}
	}
}
