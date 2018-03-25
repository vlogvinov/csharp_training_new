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

			app.Groups.RemoveGroup(1);
		}
	}
}
