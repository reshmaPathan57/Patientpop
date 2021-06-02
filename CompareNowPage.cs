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
    public class CompareNowPage
    {
        IWebDriver driver = Driver.driver;



        internal void SelectCompetitors(string text)
        {

            driver.FindElement(By.Id("practicename")).Click();
            driver.FindElement(By.Id("practicename")).Clear();
            driver.FindElement(By.Id("practicename")).SendKeys(text);

        }
     internal void selectnamefromdropdown()
        {
            driver.FindElement(By.ClassName("pac-matched"));
            Actions act = new Actions(driver);
            act.SendKeys(Keys.ArrowDown).Perform();
            act.SendKeys(Keys.Enter).Perform();
        }
        internal void Assertvalues()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.Id("practicename")).Click();
            Assert.AreEqual("Shamsah Amersi, MD", driver.FindElement(By.Id("practicename")).GetAttribute("value"));
            driver.FindElement(By.Id("streetaddress")).Click();
            Assert.AreEqual("2825 Santa Monica Boulevard", driver.FindElement(By.Id("streetaddress")).GetAttribute("value"));
            driver.FindElement(By.Id("city")).Click();
            Assert.AreEqual("Santa Monica", driver.FindElement(By.Id("city")).GetAttribute("value"));
            driver.FindElement(By.XPath("//form[@id='compare-form']/div[3]/div[2]/div/div/div/div/div")).Click();
            driver.FindElement(By.Id("zipcode")).Click();
            Assert.AreEqual("90404", driver.FindElement(By.Id("zipcode")).GetAttribute("value"));
            driver.FindElement(By.Id("website")).Click();
            Assert.AreEqual("https://www.dramersi.com/", driver.FindElement(By.Id("website")).GetAttribute("value"));

        }

        internal void AssertvaluesforScenarioA2()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.Id("practicename")).Click();
            Assert.AreEqual("Prakash Neal MD", driver.FindElement(By.Id("practicename")).GetAttribute("value"));
            driver.FindElement(By.Id("streetaddress")).Click();
            Assert.AreEqual("1500 East Duarte Road", driver.FindElement(By.Id("streetaddress")).GetAttribute("value"));
            driver.FindElement(By.Id("city")).Click();
            Assert.AreEqual("Duarte", driver.FindElement(By.Id("city")).GetAttribute("value"));
            driver.FindElement(By.XPath("//form[@id='compare-form']/div[3]/div[2]/div/div/div/div/div")).Click();
            driver.FindElement(By.Id("zipcode")).Click();
            Assert.AreEqual("91010", driver.FindElement(By.Id("zipcode")).GetAttribute("value"));
            driver.FindElement(By.Id("website")).Click();
            Assert.AreEqual("http://www.cityofhope.org/", driver.FindElement(By.Id("website")).GetAttribute("value"));
        }
        internal void enterSpecialty(string OBGYN)
        {
            driver.FindElement(By.Id("specialty")).Clear();
            driver.FindElement(By.Id("specialty")).SendKeys(OBGYN);
            driver.FindElement(By.ClassName("v-list-item__mask"));
            Actions act = new Actions(driver);
            act.SendKeys(Keys.ArrowDown).Perform();
            act.SendKeys(Keys.Enter).Perform();
            driver.FindElement(By.XPath("//button[@id='diagnose-submit']/span")).Click();
        }
        internal void enterOtherSpecialty(string NEURO)
        {
            driver.FindElement(By.Id("specialty")).Clear();
            driver.FindElement(By.Id("specialty")).SendKeys(NEURO);
            driver.FindElement(By.ClassName("v-list-item__mask"));
            Actions act = new Actions(driver);
            act.SendKeys(Keys.ArrowDown).Perform();
            act.SendKeys(Keys.Enter).Perform();
            driver.FindElement(By.XPath("//button[@id='diagnose-submit']/span")).Click();
        }

        internal void GoogleRanking()
        {
            driver.FindElement(By.XPath("//li[contains(.,'Google Ranking')]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //Assert.AreEqual("Your Practice", driver.FindElement(By.ClassName("score-name")));
            //Assert.AreEqual("score-value", driver.FindElement(By.ClassName("text.score-value")));
            //bool AreSame = false;
           // System.Console.WriteLine(AreSame);
        }
        internal void WebPresence()
        {
            var next = driver.FindElement(By.XPath("(//span[@class='btn btn-nav btn-nav-next'])[2]"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(next);
            actions.Perform();


        }
        internal void Website()
        {

            var next = driver.FindElement(By.XPath("(//span[@class='btn btn-nav btn-nav-next'])[2]"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(next);
            actions.Perform();

        }
        internal void Reputaion()
        {
            var next = driver.FindElement(By.XPath("(//span[@class='btn btn-nav btn-nav-next'])[2]"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(next);
            actions.Perform();
            //driver.FindElement(By.XPath("(//span[@class='btn btn-nav btn-nav-next'])[2]")).Click();
        }
        internal void overall()
        {
            var next = driver.FindElement(By.XPath("(//span[@class='btn btn-nav btn-nav-next'])[2]"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(next);
            actions.Perform();
            actions.Click();


        }

    }
}
