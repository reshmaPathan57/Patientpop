using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;

namespace Patientpop
{
    [Binding]
  public class CompareNowSteps
    {
        IWebDriver driver = Driver.driver;
        CompareNowPage CompareNowPage = Driver.CompareNowPage;

        [Given(@"user is nagivate to checkup page and enter the ""(.*)"" in practice filed")]
        public void GivenUserIsNagivateToCheckupPageAndEnterTheInPracticeFiled(string text)
        {
            CompareNowPage.SelectCompetitors(text);

        }

        [Given(@"select the Amersi from dropdown")]
        public void GivenSelectTheAmersiFromDropdown()
        {
            CompareNowPage.selectnamefromdropdown();
            CompareNowPage.Assertvalues();
        }

        [Given(@"select the Prakash from dropdown")]
        public void GivenSelectThePrakashFromDropdown()
        {
            CompareNowPage.selectnamefromdropdown();
            CompareNowPage.AssertvaluesforScenarioA2();
        }

        [When(@"i select the NEURO ""(.*)"" for Speciality and click Compare now")]
        public void WhenISelectTheNEUROForSpecialityAndClickCompareNow(string NEURO)
        {
            CompareNowPage.enterOtherSpecialty(NEURO);
        }


        [When(@"i select the OBGYN ""(.*)"" for Speciality and click Compare now")]
        public void WhenISelectTheOBGYNForSpecialityAndClickCompareNow(string OBGYN)
        {
            CompareNowPage.enterSpecialty(OBGYN);
        }

        [Then(@"i should see all page and numbers should matches with overall section")]
        public void ThenIShouldSeeAllPageAndNumbersShouldMatchesWithOverallSection()
        {
            CompareNowPage.GoogleRanking();
            CompareNowPage.WebPresence();
            CompareNowPage.Website();
            CompareNowPage.Reputaion();
            CompareNowPage.overall();

        }


     
    }

}