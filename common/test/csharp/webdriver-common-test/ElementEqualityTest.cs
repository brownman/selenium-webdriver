using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace OpenQa.Selenium
{
    [TestFixture]
    public class ElementEqualityTest : DriverTestFixture
    {
        [Test]
        public void ElementEqualityShouldWork()
        {
            driver.Url = (simpleTestPage);

            IWebElement body = driver.FindElement(By.TagName("body"));
            IWebElement xbody = driver.FindElement(By.XPath("//body"));

            Assert.AreEqual(body, xbody);
        }

        [Test]
        public void ElementInequalityShouldWork()
        {
            driver.Url = (simpleTestPage);

            List<IWebElement> ps = driver.FindElements(By.TagName("p"));

            Assert.AreNotEqual(ps[0], ps[1]);
        }

        [Test]
        [IgnoreBrowser(Browser.IE)]
        [IgnoreBrowser(Browser.Remote)]
        public void FindElementHashCodeShouldMatchEquality()
        {
            driver.Url = (simpleTestPage);
            IWebElement body = driver.FindElement(By.TagName("body"));
            IWebElement xbody = driver.FindElement(By.XPath("//body"));

            Assert.AreEqual(body.GetHashCode(), xbody.GetHashCode());
        }

        [Test]
        [IgnoreBrowser(Browser.IE)]
        [IgnoreBrowser(Browser.Remote)]
        public void FindElementsHashCodeShouldMatchEquality()
        {
            driver.Url = (simpleTestPage);
            List<IWebElement> body = driver.FindElements(By.TagName("body"));
            List<IWebElement> xbody = driver.FindElements(By.XPath("//body"));

            Assert.AreEqual(body[0].GetHashCode(), xbody[0].GetHashCode());
        }
    }
}