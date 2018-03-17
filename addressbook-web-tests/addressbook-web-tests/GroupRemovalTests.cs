using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
	[TestFixture]
	class GroupRemovalTests : TestBase
	{ 
		[Test]
		public void GroupRemovalTest()
		{
			navigationHelper.GoToHomePage();
			loginHelper.Login(new AccountData("admin", "secret"));
			navigationHelper.GoToGroupsPage();
			groupHelper.SelectGroup(1);
			groupHelper.RemoveGroup();
			groupHelper.ReturnToGroupsPage();
		}
	}
}
