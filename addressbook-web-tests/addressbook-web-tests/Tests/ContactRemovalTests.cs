using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAddressbookTests;

namespace WebAddressbookTests.Tests
{
	[TestFixture]
	public class ContactRemovalTests : AuthTestBase
	{
		[Test]
		public void ContactRemovalTest()
		{
			app.Contacts.EnsureContactsExist();
			app.Contacts.Remove(1);
		}
	}
}
