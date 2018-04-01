using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
	[TestFixture]
	class GroupModificationTests : AuthTestBase
	{
		[Test]
		public void GroupModificationTest()
		{
			app.Groups.EnsureGroupsExist();
			Group newGroup = new Group("New Group", "New Header", "New footer");
			app.Groups.Modify(0, newGroup);
		}
	}
}
