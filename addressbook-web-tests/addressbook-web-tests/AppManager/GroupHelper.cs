using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
	public class GroupHelper : HelperBase
	{
		public GroupHelper(IWebDriver driver) : base(driver)
		{
		
		}
		public void ReturnToGroupsPage()
		{
			driver.FindElement(By.LinkText("group page")).Click();
		}

		public void SumbitGroupCreation()
		{
			driver.FindElement(By.Name("submit")).Click();
		}

		public void FillGroupForm(string name, string header, string footer)
		{
			driver.FindElement(By.Name("group_name")).Click();
			driver.FindElement(By.Name("group_name")).Clear();
			driver.FindElement(By.Name("group_name")).SendKeys(name);
			driver.FindElement(By.Name("group_header")).Click();
			driver.FindElement(By.Name("group_header")).Clear();
			driver.FindElement(By.Name("group_header")).SendKeys(header);
			driver.FindElement(By.Name("group_footer")).Click();
			driver.FindElement(By.Name("group_footer")).Clear();
			driver.FindElement(By.Name("group_footer")).SendKeys(footer);
		}

		public void InitGroupCreation()
		{
			driver.FindElement(By.XPath("(//input[@name='new'])[2]")).Click();
		}

		public void RemoveGroup()
		{
			driver.FindElement(By.Name("delete")).Click();
		}

		public void SelectGroup(int index)
		{
			driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
		}
	}
}
