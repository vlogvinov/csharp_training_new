using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
	[TestFixture]
	public class LoginTests : TestBase
	{
		[Test]
		public void LoginWithValidCredentials()
		{
			AccountData account = new AccountData("admin", "secret");
			app.Auth.Logout();
			app.Auth.Login(account);
			Assert.That(app.Auth.IsLoggedIn(account), Is.True);
		}


		[Test]
		public void LoginWithInvalidCredentials()
		{
			AccountData account = new AccountData("admin", "123456");
			app.Auth.Logout();
			app.Auth.Login(account);
			Assert.That(app.Auth.IsLoggedIn(account), Is.False);
		}
	}
}
