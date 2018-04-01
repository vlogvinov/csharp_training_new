using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace WebAddressbookTests
{
	[TestFixture]
	class GroupCreationTests : AuthTestBase
	{ 
		[Test]
		public void GroupCreationTest()
		{
			Group group = new Group("MyName", "MyHeader", "MyFooter");
			List<Group> oldGroups = app.Groups.GetGroupList();
			app.Groups.Create(group);


			List<Group> newGroups = app.Groups.GetGroupList();
			Assert.That(oldGroups.Count + 1, Is.EqualTo(newGroups.Count));
		}

		[Test]
		public void EmptyGroupCreationTest()
		{
			Group group = new Group("", "", "");
			List<Group> oldGroups = app.Groups.GetGroupList();
			app.Groups.Create(group);

			List<Group> newGroups = app.Groups.GetGroupList();
			Assert.That(oldGroups.Count + 1, Is.EqualTo(newGroups.Count));
		}
	}
}
