using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Yazilimci.club
{
    public class YazilimciClubTest
    {
        private   IWebDriver _driver;
        private readonly string _startPage = "https://yazilimci.club/index.php";
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [Test]
        public void Temel_Kullanici_Giris_Coskun_Fail()
        {
            string userName = "coskundogukan338@gmail.com";
            string password = "12241";
            try
            {
                _driver.Navigate().GoToUrl(_startPage);
                _driver.FindElement(By.Id("floatingInput")).SendKeys(userName);
                _driver.FindElement(By.Id("floatingPassword")).SendKeys(password);
                _driver.FindElement(By.Name("giris")).Click();

                if (_driver.PageSource.Contains("Kullanıcı Bulunamıyor"))
                {
                    Assert.Pass();

                }
                else
                {
                    Assert.Fail();
                }
            }
            finally
            {
                _driver.Close();
            }
            
        }

        [Test]
        public void Temel_Kullanici_Giris_Coskun_Pass()
        {
            string userName = "coskundogukan338@gmail.com";
            string password = "1224";
            try
            {
                _driver.Navigate().GoToUrl(_startPage);
                _driver.FindElement(By.Id("floatingInput")).SendKeys(userName);
                _driver.FindElement(By.Id("floatingPassword")).SendKeys(password);
                _driver.FindElement(By.Name("giris")).Click();

                if (_driver.PageSource.Contains("Doğukan Coşkun"))
                {
                    Assert.Pass();

                }
                else
                {
                    Assert.Fail();
                }
            }
            finally
            {
                _driver.Close();
            }
           
        
        }

        [Test]
        public void Temel_Kullanici_Giris_Muhsin_Fail()
        {
            string userName = "muhsindolu06@gmail.com";
            string password = "15011";
            try
            {
                _driver.Navigate().GoToUrl(_startPage);
                _driver.FindElement(By.Id("floatingInput")).SendKeys(userName);
                _driver.FindElement(By.Id("floatingPassword")).SendKeys(password);
                _driver.FindElement(By.Name("giris")).Click();

                if (_driver.PageSource.Contains("Kullanıcı Bulunamıyor"))
                {
                    Assert.Pass();

                }
                else
                {
                    Assert.Fail();
                }
            }
            finally
            {
                _driver.Close();
            }

            Assert.Pass();
        }

        [Test]
        public void Temel_Kullanici_Giris_Muhsin_Pass()
        {
            string userName = "muhsindolu06@gmail.com";
            string password = "1501";
            try
            {
                _driver.Navigate().GoToUrl(_startPage);
                _driver.FindElement(By.Id("floatingInput")).SendKeys(userName);
                _driver.FindElement(By.Id("floatingPassword")).SendKeys(password);
                _driver.FindElement(By.Name("giris")).Click();

                if (_driver.PageSource.Contains("Muhsin Dolu"))
                {
                    Assert.Pass();

                }
                else
                {
                    Assert.Fail();
                }
            }
            finally
            {
                _driver.Close();
            }


            Assert.Pass();
        }


        [Test]
        public void Sql_Injection_Giris_Fail()
        {
            string userName = "a@gmail.com";
            string password = "' aa'";
            try
            {
                _driver.Navigate().GoToUrl(_startPage);
                _driver.FindElement(By.Id("floatingInput")).SendKeys(userName);
                _driver.FindElement(By.Id("floatingPassword")).SendKeys(password);
                _driver.FindElement(By.Name("giris")).Click();

                if (_driver.PageSource.Contains("Kullanıcı Bulunamıyor"))
                {
                    Assert.Pass();

                }
                else
                {
                    Assert.Fail();
                }
            }
            finally
            {
                _driver.Close();
            } 
        }

        [Test]
        public void Sql_Injection_Giris_Pass()
        {
            string userName = "a@gmail.com";
            string password = "' or 'a'='a";
            try
            {
                _driver.Navigate().GoToUrl(_startPage);
                _driver.FindElement(By.Id("floatingInput")).SendKeys(userName);
                _driver.FindElement(By.Id("floatingPassword")).SendKeys(password);
                _driver.FindElement(By.Name("giris")).Click();

                if (!_driver.PageSource.Contains("Kullanıcı Bulunamıyor"))
                {
                    Assert.Pass();

                }
                else
                {
                    Assert.Fail();
                }
            }
            finally
            {
                _driver.Close();
            }
        }
    }
}