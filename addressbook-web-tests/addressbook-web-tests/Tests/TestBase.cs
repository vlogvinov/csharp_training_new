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
	public class TestBase
	{
		protected ApplicationManager app;

		[SetUp]
		public void SetupApplicationManager()
		{
			app = ApplicationManager.GetInstance();
		}
	}
}
