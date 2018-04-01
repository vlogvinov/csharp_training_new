using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests.Tests
{
	[TestFixture]
	public class ContactModificationTests : AuthTestBase
	{
		[Test]
		public void ContactModificationTest()
		{
			app.Contacts.EnsureContactsExist();
			Contact contact = new Contact("TEST", "TEST");
			app.Contacts.Modify(1, contact);
		}
	}
}
