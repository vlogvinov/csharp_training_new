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
			OpenHomePage();
			Login(new AccountData("admin", "secret"));
			GoToGroupsPage();
			SelectGroup(1);
			RemoveGroup();
			ReturnToGroupsPage();
		}
	}
}
