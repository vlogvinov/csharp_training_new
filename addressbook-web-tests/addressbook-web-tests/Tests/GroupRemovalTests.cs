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
	class GroupRemovalTests : AuthTestBase
	{ 
		[Test]
		public void GroupRemovalTest()
		{
			app.Groups.EnsureGroupsExist();

			List<Group> oldGroups = app.Groups.GetGroupList();

			app.Groups.RemoveGroup(0);

			oldGroups.RemoveAt(0);
			List<Group> newGroups = app.Groups.GetGroupList();
			Assert.That(oldGroups, Is.EqualTo(newGroups));
		
		}
	}
}
