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

		public LoginHelper(ApplicationManager manager) : base(manager)
		{

		}
		public void Login(AccountData account)
		{
			Type(By.Name("user"), account.Username);
			Type(By.Name("pass"), account.Password);
			driver.FindElement(By.XPath("//input[@value='Login']")).Click();
		}
	}
}
