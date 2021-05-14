using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace PageTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForAdmin()
        {
            using (var driver = new ChromeDriver())
            {

                //open register page
                driver.Navigate().GoToUrl("http://localhost:4200/home");


                new WebDriverWait(driver, TimeSpan.FromMinutes(3)).Until(
                    d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete")
                    );

                var pageTitle = driver.PageSource.Contains("ABC Healthcare");
                Assert.IsTrue(pageTitle);
                var LogIn = driver.FindElementByXPath("/html/body/app-root/app-nav-bar/nav/div/ul/div[1]/li/a");
                Assert.IsNotNull(LogIn);
                LogIn.Click();
                new WebDriverWait(driver, TimeSpan.FromMinutes(3)).Until(
                   d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete")
                   );
                pageTitle = driver.PageSource.Contains("Sign In");
                Assert.IsTrue(pageTitle);
                driver.FindElementByName("UserName").SendKeys("Admin");
                driver.FindElementByName("Password").SendKeys("1234");
                new WebDriverWait(driver, TimeSpan.FromMinutes(3)).Until(
                   d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete")
                   );
                var SignIn = driver.FindElementById("signin");
                Assert.IsNotNull(SignIn);
                SignIn.Click();
                new WebDriverWait(driver, TimeSpan.FromMinutes(3)).Until(
                d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete")
                );
                pageTitle = driver.PageSource.Contains("Filters");
                Assert.IsTrue(pageTitle);
                var AdminPanel = driver.FindElementByXPath("/html/body/app-root/app-nav-bar/nav/div[1]/ul/div[2]/li/a");
                Assert.IsNotNull(AdminPanel);
                AdminPanel.Click();
                new WebDriverWait(driver, TimeSpan.FromMinutes(3)).Until(
                   d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete")
                   );
                pageTitle = driver.PageSource.Contains("Product Detail Register");
                Assert.IsTrue(pageTitle);
                driver.FindElementByName("productName").SendKeys("test");
                driver.FindElementByName("imageUrl").SendKeys("http:test/pic.com");
                driver.FindElementByName("price").SendKeys("30");
                driver.FindElementByName("description").SendKeys("this is a test");
                driver.FindElementByName("productType").SendKeys("Tablet");
                new WebDriverWait(driver, TimeSpan.FromMinutes(3)).Until(
                 d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete")
                 );
                var Submit = driver.FindElementByXPath("/html/body/app-root/app-admin-panel/div/div/div/div[1]/app-admin-detail/form/div[6]/button");
                Assert.IsNotNull(Submit);
                Submit.Click();
                new WebDriverWait(driver, TimeSpan.FromMinutes(3)).Until(
                 d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete")
                 );
                var Logout = driver.FindElementByXPath("/html/body/app-root/app-nav-bar/nav/div[3]/button");
                Assert.IsNotNull(Logout);
                Logout.Click();




            }
        }
        [TestMethod]
        public void TestForCustomer()
        {
            using (var driver = new ChromeDriver())
            {

                //open register page
                driver.Navigate().GoToUrl("http://localhost:4200/home");


                new WebDriverWait(driver, TimeSpan.FromMinutes(3)).Until(
                    d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete")
                    );

                var pageTitle = driver.PageSource.Contains("ABC Healthcare");
                Assert.IsTrue(pageTitle);
                var AddButton = driver.FindElementByXPath("/html/body/app-root/app-nav-bar/nav/div/ul/div[1]/li/a");
                Assert.IsNotNull(AddButton);
                AddButton.Click();
                new WebDriverWait(driver, TimeSpan.FromMinutes(3)).Until(
                   d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete")
                   );
                var pageTitle2 = driver.PageSource.Contains("Sign In");
                Assert.IsTrue(pageTitle2);
                driver.FindElementByName("UserName").SendKeys("rdubey");
                driver.FindElementByName("Password").SendKeys("1234");
                new WebDriverWait(driver, TimeSpan.FromMinutes(3)).Until(
                   d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete")
                   );
                var SignIn = driver.FindElementByXPath("/html/body/app-root/app-user/div/div/div[2]/div/app-login/form/div[3]/div/button");
                Assert.IsNotNull(SignIn);
                SignIn.Click();
                new WebDriverWait(driver, TimeSpan.FromMinutes(3)).Until(
                   d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete")
                   );
                var Addtocart = driver.FindElementByXPath("/html/body/app-root/app-product/div/div[2]/div/div/div[1]/div/div[3]");
                Assert.IsNotNull(Addtocart);
                Addtocart.Click();

                new WebDriverWait(driver, TimeSpan.FromMinutes(3)).Until(
                d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete")
                );
                var cart = driver.FindElementByXPath("/html/body/app-root/app-nav-bar/nav/div[1]/ul/div[2]/li/div/i");
                Assert.IsNotNull(cart);
                cart.Click();

                new WebDriverWait(driver, TimeSpan.FromMinutes(3)).Until(
                d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete")
                );
                var checkout = driver.FindElementByXPath("/html/body/app-root/app-cart/section/div/div[2]/div/div[2]/button");
                Assert.IsNotNull(checkout);
                checkout.Click();

                new WebDriverWait(driver, TimeSpan.FromMinutes(3)).Until(
                d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete")
                );
                driver.FindElementByName("fullName").SendKeys("test");
                driver.FindElementByName("email").SendKeys("test@gmail.com");
                driver.FindElementByName("address").SendKeys("test address");
                driver.FindElementByName("city").SendKeys("test city");
                driver.FindElementByName("nameOnCard").SendKeys("test");
                driver.FindElementByName("cardNumber").SendKeys("1111-2222-3333");
                driver.FindElementByName("expMonth").SendKeys("June");


                var finalcheckout = driver.FindElementByXPath("/html/body/app-root/app-checkout/div/div/div[1]/div/form/button");
                Assert.IsNotNull(finalcheckout);
                finalcheckout.Click();

                new WebDriverWait(driver, TimeSpan.FromMinutes(3)).Until(
                d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete")
                );



                var Logout = driver.FindElementByXPath("/html/body/app-root/app-nav-bar/nav/div[3]/button");
                Assert.IsNotNull(Logout);
                Logout.Click();












            }
        }
        }
}
