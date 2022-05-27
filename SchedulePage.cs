#nullable disable
using OpenQA.Selenium;
using System;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace TestProject
{
    internal class SchedulePage
    {
        readonly string BaseURL = "http://develop-softserve.herokuapp.com/schedule?semester=53";

        private IWebDriver driver;
        private WebDriverWait wait;

        public SchedulePage()
        {
            this.driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How=How.CssSelector, Using= "nav.header-blocks:nth-child(3)>a:nth-child(1)")]
        [CacheLookup]
        public IWebElement headerBtn;

        [FindsBy(How = How.Id, Using = "group")]
        [CacheLookup]
        public IWebElement groupSelect;

        [FindsBy(How = How.Id, Using = "teacher")]
        [CacheLookup]
        public IWebElement teacherSelect;

        [FindsBy(How = How.Id, Using = "semester")]
        [CacheLookup]
        public IWebElement semesterSelect;

        [FindsBy(How = How.CssSelector, Using = "#root>div>section>section>div>form>button")]
        [CacheLookup]
        public IWebElement searchBtn;

        [FindsBy(How = How.CssSelector, Using = "#root>div>h1")]
        [CacheLookup]
        public IWebElement headerTitle;

        [FindsBy(How = How.CssSelector, Using = "#root>div>header>nav.header-blocks.header-blocks_two>a")]
        [CacheLookup]
        public IWebElement loginBtn;

        [FindsBy(How = How.CssSelector, Using = "#root>div>div>table")]
        [CacheLookup]
        public IWebElement scheduleTable;

        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(BaseURL);
        }

        public void ChooseTeacher(string teacher)
        {

            wait.Until(d => teacherSelect.Enabled);
            var selectElement = new SelectElement(teacherSelect);
            selectElement.SelectByText(teacher);

        }
        public void SearchClick()
        {

            wait.Until(d => searchBtn.Displayed);
            searchBtn.Click();
            wait.Until(d => scheduleTable.Displayed);

        }

        public void AssertTeacherHeader(string headerteacher)
        {
            wait.Until(d => headerTitle.Displayed); 
            Assert.Contains(headerteacher, headerTitle.Text);
        }

        public void AssertGroupName(string headergroupname)
        {
            wait.Until(d => headerTitle.Displayed);
            Assert.Contains(headergroupname, headerTitle.Text);
        }

        public void AssertSemesterHeader(string headersemester)
        {
            wait.Until(d => headerTitle.Displayed);
            Assert.Contains(headersemester, headerTitle.Text);
        }

        public void ChooseGroup(string groupname)
        {

            wait.Until(d => groupSelect.Enabled);
            var selectElement = new SelectElement(groupSelect);
            selectElement.SelectByText(groupname);

        }

        public void ChooseSemester(string semester)
        {

            wait.Until(d => semesterSelect.Enabled);
            var selectElement = new SelectElement(semesterSelect);
            selectElement.SelectByText(semester);
        }
    }
}
