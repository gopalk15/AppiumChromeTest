using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;
using System;

namespace Appium.ChromeTest.Test
{
    [TestClass]
    public class RemoteConnectionTest
    {
        [TestMethod]
        public void EstablishRemoteConnection()
        {
            //Setup Desired Capabilities
            AppiumOptions caps = new AppiumOptions();

            caps.AddAdditionalCapability(MobileCapabilityType.PlatformName, MobilePlatform.Android);
            caps.AddAdditionalCapability(MobileCapabilityType.AutomationName, AutomationName.Appium);
            caps.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator-5554");
            caps.AddAdditionalCapability(MobileCapabilityType.BrowserName, MobileBrowserType.Chrome);


            //Launch Android Webdriver
            RemoteWebDriver driver = new RemoteWebDriver(new Uri("http://172.16.0.7:4723/wd/hub"), caps);
            //AndroidDriver<IWebElement> driver = new AndroidDriver<IWebElement>(new Uri("http://127.16.0.7:4723/wd/hub"), caps);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //Test HandShake
            driver.Navigate().GoToUrl("http://dev-online.dev.tsretail.co.za/sport");

            //Shut Down Driver
            driver.Quit();


        }
    }
}
