using OpenQA.Selenium;

namespace WebAddressbookTests
{
	public class HelperBase
	{
		protected ApplicationManager manager;
		protected IWebDriver driver;

		public HelperBase(ApplicationManager manager)
		{
			this.manager = manager;
			this.driver = manager.Driver;
		}

		protected void Type(By locator, string text)
		{
			if (text != null)
			{
				driver.FindElement(By.Name("group_name")).Clear();
				driver.FindElement(By.Name("group_name")).SendKeys(text);
			}
		}
	}
}