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
			Group group = new Group("MyName", "MyHeader", "MyFooter");
			app.Navigator.GoToGroupsPage();
			app.Groups.InitGroupCreation();
			app.Groups.FillGroupForm(group);
			app.Groups.SumbitGroupCreation();
			app.Groups.ReturnToGroupsPage();
		}

		
	}
}
