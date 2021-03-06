﻿using System;
using Appium.Net.Integration.Tests.helpers;
using Appium.Net.Integration.Tests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.PageObjects;
using SeleniumExtras.PageObjects;

namespace Appium.Net.Integration.Tests.PageObjectTests.Android
{
    [TestFixture]
    public class TestThatChecksAttributeMix2
    {
        private AndroidDriver<AppiumWebElement> _driver;
        private AndroidPageObjectChecksAttributeMixOnNativeApp2 _pageObject;

        [OneTimeSetUp]
        public void BeforeAll()
        {
            var capabilities = Env.ServerIsRemote()
                ? Caps.GetAndroidCaps(Apps.Get("androidApiDemos"))
                : Caps.GetAndroidCaps(Apps.Get("androidApiDemos"));
            var serverUri = Env.ServerIsRemote() ? AppiumServers.RemoteServerUri : AppiumServers.LocalServiceUri;
            _driver = new AndroidDriver<AppiumWebElement>(serverUri, capabilities, Env.InitTimeoutSec);
            var timeSpan = new TimeOutDuration(new TimeSpan(0, 0, 0, 5, 0));
            _pageObject = new AndroidPageObjectChecksAttributeMixOnNativeApp2();
            PageFactory.InitElements(_driver, _pageObject, new AppiumPageObjectMemberDecorator(timeSpan));
        }

        [OneTimeTearDown]
        public void AfterEach()
        {
            _driver?.Quit();
            if (!Env.ServerIsRemote())
            {
                AppiumServers.StopLocalService();
            }
        }

        [Test]
        public void CheckMobileElement()
        {
            Assert.NotNull(_pageObject.GetMobileElementText());
        }

        [Test]
        public void CheckMobileElements()
        {
            Assert.GreaterOrEqual(_pageObject.GetMobileElementSize(), 1);
        }

        [Test]
        public void CheckMobileElementProperty()
        {
            Assert.NotNull(_pageObject.GetMobileElementPropertyText());
        }

        [Test]
        public void CheckMobileElementsProperty()
        {
            Assert.GreaterOrEqual(_pageObject.GetMobileElementPropertySize(), 1);
        }

        [Test]
        public void CheckElementFoundUsingMultipleLocators()
        {
            Assert.NotNull(_pageObject.GetMultipleFindByElementText());
        }

        [Test]
        public void CheckElementsFoundUsingMultipleLocators()
        {
            Assert.GreaterOrEqual(_pageObject.GetMultipleFindByElementSize(), 10);
            Assert.LessOrEqual(_pageObject.GetMultipleFindByElementSize(), 14);
        }

        [Test]
        public void CheckElementFoundUsingMultipleLocatorsProperty()
        {
            Assert.NotNull(_pageObject.GetMultipleFindByElementPropertyText());
        }

        [Test]
        public void CheckElementsFoundUsingMultipleLocatorssProperty()
        {
            Assert.GreaterOrEqual(_pageObject.GetMultipleFindByElementPropertySize(), 10);
            Assert.LessOrEqual(_pageObject.GetMultipleFindByElementSize(), 14);
        }

        [Test]
        public void CheckElementFoundByChainedSearch()
        {
            Assert.NotNull(_pageObject.GetFoundByChainedSearchElementText());
        }

        [Test]
        public void CheckElementsFoundByChainedSearch()
        {
            Assert.GreaterOrEqual(_pageObject.GetFoundByChainedSearchElementSize(), 10);
            Assert.LessOrEqual(_pageObject.GetMultipleFindByElementSize(), 14);
        }

        [Test]
        public void CheckFoundByChainedSearchElementProperty()
        {
            Assert.NotNull(_pageObject.GetFoundByChainedSearchElementPropertyText());
        }

        [Test]
        public void CheckFoundByChainedSearchElementsProperty()
        {
            Assert.GreaterOrEqual(_pageObject.GetFoundByChainedSearchElementPropertySize(), 10);
            Assert.LessOrEqual(_pageObject.GetMultipleFindByElementSize(), 14);
        }

        [Test]
        public void CheckElementMatchedToAll()
        {
            Assert.NotNull(_pageObject.GetMatchedToAllLocatorsElementText());
        }

        [Test]
        public void CheckElementsMatchedToAll()
        {
            Assert.GreaterOrEqual(_pageObject.GetMatchedToAllLocatorsElementSize(), 1);
            Assert.LessOrEqual(_pageObject.GetMatchedToAllLocatorsElementSize(), 13);
        }

        [Test]
        public void CheckElementMatchedToAllProperty()
        {
            Assert.NotNull(_pageObject.GetMatchedToAllLocatorsElementPropertyText());
        }

        [Test]
        public void CheckElementMatchedToAllElementsProperty()
        {
            Assert.GreaterOrEqual(_pageObject.GetMatchedToAllLocatorsElementPropertySize(), 1);
            Assert.LessOrEqual(_pageObject.GetMatchedToAllLocatorsElementPropertySize(), 13);
        }
    }
}