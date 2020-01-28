using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium.Sample.Framework;

namespace Selenium.Sample.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]

        public void TestApplyFilter()
        {
            Browser.Goto("http://www.stackoverflow.com");
            Pages.OpenMenu();
            Pages.OpenQuestionsMenu();
            Pages.OpenFilterMenu();
            Pages.MarkByLabelText("No accepted answer");
            Pages.MarkByLabelText("Recent activity");
            Pages.MarkByLabelText("The following tags:");
            Pages.InputTextToElementByClassName("js-tageditor-replacing", "javascript");
            Pages.SelectFilterTagBySearchText("javascript");
            Pages.ApplyFilters();
            Assert.IsTrue(Pages.DoesH1HaveText("Questions tagged [javascript]"));
        }

        [TestMethod]

        public void TestSelectFilteredTag()
        {
            Browser.Goto("http://www.stackoverflow.com");
            Pages.OpenMenu();
            Pages.OpenTagsMenu();
            Pages.InputTextToElementById("tagfilter", "c#");
            Pages.SelectTagBySearchText("c#");
            Assert.IsTrue(Pages.DoesH1HaveText("Questions tagged [c#]"));

        }

        [ClassCleanup]

        public static void close()
        {
            Browser.Close();
        }
    }
}
