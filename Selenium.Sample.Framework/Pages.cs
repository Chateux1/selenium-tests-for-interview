using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium.Sample.Framework
{
    public class Pages
    {
        public static void OpenMenu()
        {
            IWebElement menubar = Browser.driver.FindElement(By.ClassName("left-sidebar-toggle"));
            menubar.Click();
        }

        public static void OpenQuestionsMenu()
        {
            IWebElement questionsLink = Browser.driver.FindElement(By.Id("nav-questions"));
            questionsLink.Click();
        }

        public static void OpenTagsMenu()
        {
            IWebElement tagsLink = Browser.driver.FindElement(By.Id("nav-tags"));
            tagsLink.Click();
        }

        public static void OpenFilterMenu()
        {
            IWebElement filterButton = Browser.driver.FindElement(By.XPath("//button[@data-target = 'se-uql.toggleFormButton']"));
            filterButton.Click();
        }

        public static void MarkByLabelText(string labelText)
        {
            IWebElement label = Browser.driver.FindElement(By.XPath("//label[text() = '" + labelText + "']"));
            label.Click();
        }

        public static void InputTextToElementByClassName(string className, string inputText)
        {
            IWebElement element = Browser.driver.FindElement(By.ClassName(className));
            element.SendKeys(inputText);
        }

        public static void InputTextToElementById(string id, string inputText)
        {
            IWebElement element = Browser.driver.FindElement(By.Id(id));
            element.SendKeys(inputText);
        }

        public static void SelectTagBySearchText(string searchText)
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            IWebElement tag = Browser.driver.FindElement(By.XPath("//div[@id='tags-browser']/div[1]/a[text() = '"+ searchText +"']"));
            tag.Click();
        }

        public static void SelectFilterTagBySearchText(string searchText)
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            IWebElement tag = Browser.driver.FindElement(By.XPath("//div[@class='tag-suggestions js-tag-suggestions box-border']/div[1]/span[1]/span[text() = '" + searchText +"']"));
            tag.Click();
        }
        public static void ApplyFilters()
        {
            IWebElement applyFilterButton = Browser.driver.FindElement(By.XPath("//button[@data-target = 'se-uql.applyButton']"));
            applyFilterButton.Click();
        }

        public static bool DoesH1HaveText(string text)
        {
            IWebElement heading1 = Browser.driver.FindElement(By.ClassName("fs-headline1"));
            return heading1.Text.Contains(text);
        }
    }
}
