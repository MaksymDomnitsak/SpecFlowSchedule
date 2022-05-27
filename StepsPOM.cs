using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TestProject
{
    [Binding]
    internal class StepsSchedulePage
    {
        public SchedulePage page;

        public StepsSchedulePage()
        {
            page = new SchedulePage();
        }

        [Given(@"user in a schedule page")]
        public void UserInASchedulepage()
        {
            page.GoToHomePage();
        }

        [When(@"user choose t(.*) in dropdown list")]
        public void UserChooseTeacherInDropDownList(string teacher)
        {

            page.ChooseTeacher(teacher);

        }
        [When(@"user choose g(.*) in dropdown list")]
        public void UserChooseGroupInDropDownList(string groupname)
        {

            page.ChooseGroup(groupname);

        }

        [When(@"user choose s(.*) in dropdown list")]
        public void UserChooseSemesterInDropDownList(string semester)
        {

            page.ChooseSemester(semester);

        }

        [When(@"click on submitbutton")]
        public void ClickOnSubmitButton()
        {
            page.SearchClick();
        }

        [Then(@"schedule will be viewed for this teacher and header will contain (.*)")]
        public void ScheduleWillBeViewedForThisTeacher(string headerteacher)
        {
            page.AssertTeacherHeader(headerteacher);
        }

        [Then(@"schedule will be viewed for this group and header will contain (.*)")]
        public void ScheduleWillBeViewedForThisGroup(string headergroupname)
        {
            page.AssertGroupName(headergroupname);
        }

        [Then(@"schedule will be viewed for this semester and header will contain (.*)")]
        public void ScheduleWillBeViewedForThisSemester(string headersemester)
        {
            page.AssertSemesterHeader(headersemester);
        }
    }
}
