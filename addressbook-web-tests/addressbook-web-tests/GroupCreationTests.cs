using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
	[TestFixture]
	class GroupCreationTests : TestBase
	{ 
		[Test]
		public void GroupCreationTest()
		{
			OpenHomePage();
			Login(new AccountData("admin", "secret"));
			GoToGroupsPage();
			InitGroupCreation();
			FillGroupForm("My", "Header", "Footer");
			SumbitGroupCreation();
			ReturnToGroupsPage();
		}

		
	}
}
