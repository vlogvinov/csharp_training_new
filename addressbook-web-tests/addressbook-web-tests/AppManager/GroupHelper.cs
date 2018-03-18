﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
	public class GroupHelper : HelperBase
	{
		public GroupHelper(ApplicationManager manager) : base(manager)
		{
		
		}

		public GroupHelper Create(Group group)
		{
			manager.Navigator.GoToGroupsPage();
			InitGroupCreation();
			FillGroupForm(group);
			SumbitGroupCreation();
			ReturnToGroupsPage();
			return this;
		}

		public GroupHelper Modify(int index, Group group)
		{
			manager.Navigator.GoToGroupsPage();
			SelectGroup(index);
			InitGroupModification();
			FillGroupForm(group);
			SumbitGroupModification();
			ReturnToGroupsPage();
			return this;
		}

		public GroupHelper SumbitGroupModification()
		{
			driver.FindElement(By.XPath("(//input[@name='update'])[1]")).Click();
			return this;
		}

		public GroupHelper InitGroupModification()
		{
			driver.FindElement(By.XPath("(//input[@name='edit'])[1]")).Click();
			return this;
		}

		public GroupHelper RemoveGroup(int index)
		{
			manager.Navigator.GoToGroupsPage();
			SelectGroup(index);
			RemoveGroup();
			ReturnToGroupsPage();
			return this;
		}
		public GroupHelper ReturnToGroupsPage()
		{
			driver.FindElement(By.LinkText("group page")).Click();
			return this;
		}

		public GroupHelper SumbitGroupCreation()
		{
			driver.FindElement(By.Name("submit")).Click();
			return this;
		}

		public GroupHelper FillGroupForm(Group group)
		{
			Type(By.Name("group_name"), group.Name);
			Type(By.Name("group_header"), group.Header);
			Type(By.Name("group_footer"), group.Footer);
			return this;
		}

		private void Type(By locator, string text)
		{
			if (locator != null)
			{
				driver.FindElement(By.Name("group_name")).Clear();
				driver.FindElement(By.Name("group_name")).SendKeys(text);
			}
		}

		public GroupHelper InitGroupCreation()
		{
			driver.FindElement(By.XPath("(//input[@name='new'])[2]")).Click();
			return this;
		}

		public GroupHelper RemoveGroup()
		{
			driver.FindElement(By.Name("delete")).Click();
			return this;
		}

		public GroupHelper SelectGroup(int index)
		{
			driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
			return this;
		}
	}
}
