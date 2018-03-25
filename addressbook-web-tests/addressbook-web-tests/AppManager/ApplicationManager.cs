﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
	public class ApplicationManager
	{

		private IWebDriver driver;
		private string baseURL;

		protected LoginHelper loginHelper;
		protected NavigationHelper navigator;
		protected GroupHelper groupHelper;
		protected ContactHelper contactHelper;

		public ApplicationManager()
		{
			driver = new ChromeDriver();
			baseURL = "http://addressbook/";
			loginHelper = new LoginHelper(this);
			navigator = new NavigationHelper(this, baseURL);
			groupHelper = new GroupHelper(this);
			contactHelper = new ContactHelper(this);
		}

		public void Stop()
		{
			driver.Quit();
		}

		public LoginHelper Auth
		{ 
			get
			{
				return loginHelper;
			}
		}

		public NavigationHelper Navigator
		{ 
			get
			{
				return navigator;
			}
		}

		public GroupHelper Groups
		{ 
			get
			{
				return groupHelper;
			}
		}

		public ContactHelper Contacts
		{ 
			get
			{
				return contactHelper;
			}
		}

		public IWebDriver Driver 
		{ 
			get 
			{
				return driver;
			}
		}
	}
}
