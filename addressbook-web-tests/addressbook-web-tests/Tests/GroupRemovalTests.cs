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
			app.Navigator.GoToGroupsPage();
			app.Groups.SelectGroup(1);
			app.Groups.RemoveGroup();
			app.Groups.ReturnToGroupsPage();
		}
	}
}
