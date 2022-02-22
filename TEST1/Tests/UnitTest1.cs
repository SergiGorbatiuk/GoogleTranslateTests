using GoogleTranslateTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace GoogleTranslateTests
{
    [TestFixture]
    public class Tests : BaseTest
    {
        [Test, Order(0)]
        [Description("EN to UA.Correct translation")]
        public void CorrectEnToUa()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.AreEqual(TestSettings.outputFieldExpectedUa, actualResult, "Incorrect translation");
        }

        [Test, Order(1)]
        [Description("EN to UA.Input fullfilled with random string")]
        public void RandomInputEnToUa()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string randomString = GenerateRandomData.GenerateRandomEnString(TestSettings.numberForRandomString);
            string actualResult = mainPageObjects.Translate(randomString);

            Assert.AreEqual(randomString, actualResult);
        }

        [Test, Order(2)]
        [Description("EN to UA.Input fullfilled with 5001 characters")]
        public void InputEnToUaOver5000Char()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string randomString = GenerateRandomData.GenerateRandomNumber(TestSettings.numberForRandomStringOver5000);
            string actualResult = mainPageObjects.Translate(randomString);

            Assert.IsTrue(mainPageObjects.Check5000CharField());
        }

        [Test, Order(3)]
        [Description("EN to UA.Input fullfilled with UA word")]
        public void UaTextIntoEnInput()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueUa);

            Assert.AreEqual(TestSettings.inpFieldValueUa, actualResult);
        }

        [Test, Order(4)]
        [Description("EN to UA.Input fullfilled with random string")]
        public void SymbolsCounterCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string randomString = GenerateRandomData.GenerateRandomEnString(TestSettings.numberForRandomString);
            string actualResult = mainPageObjects.Translate(randomString);

            Assert.AreEqual(TestSettings.numberForRandomString, mainPageObjects.ReturnCounterValue());
        }

        [Test, Order(5)]
        [Description("Check 'ExchangeLanguages' button")]
        public void ExchangeLanguagesButtonCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string url = mainPageObjects.GetUrlAfterLangExchange();

            Assert.AreEqual(TestSettings.hostPrefixUaToEn, url);
        }

        [Test, Order(6)]
        [Description("Check 'Clear input field' icon click")]
        public void ClearInputFieldIconCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);
            string inputFieldValue = mainPageObjects.ClearInputField();

            Assert.AreEqual(TestSettings.emptyField, inputFieldValue);
        }

        [Test, Order(7)]
        [Description("Check for definition area")]
        public void CheckDefinitionArea()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.CheckDefinitionArea());
        }

        [Test, Order(8)]
        [Description("Check for More definitions button")]
        public void CheckMoreDefinitionsButton()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.CheckMoreDefinitionsButton());
        }

        [Test, Order(9)]
        [Description("Check for Less definitions button")]
        public void CheckLessDefinitionsButton()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.CheckShowLessDefinitionsButton());
        }

        [Test, Order(10)]
        [Description("Check for examples area")]
        public void CheckExamplesArea()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.CheckExamplesArea());
        }

        [Test, Order(11)]
        [Description("Check for More examples button")]
        public void CheckMoreExamplesButton()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.CheckMoreExamplesButton());
        }

        [Test, Order(12)]
        [Description("Check for Less examples button")]
        public void CheckLessExamplesButton()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.CheckShowLessExamplesButton());
        }

        [Test, Order(13)]
        [Description("Check for Documents button")]
        public void CheckDocumentsButton()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            
            Assert.IsTrue(mainPageObjects.CheckDocumentsButton());
        }

        [Test, Order(14)]
        [Description("Check for Virt keyboard area")]
        public void CheckVirtKeyboardArea()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            
            Assert.IsTrue(mainPageObjects.CheckVirtKeyBoardOnButton());
        }

        [Test, Order(15)]
        [Description("EN to UA.Correct translation virt keyboard input")]
        public void CorrectEnToUaVirtKeyboardInput()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.TranslateToUkrVirtKeyboard();

            Assert.AreEqual(TestSettings.outputFieldExpectedUa, actualResult, "Incorrect translation");
        }

        [Test, Order(16)]
        [Description("Check Login")]
        public void CheckLogin()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);

            Assert.IsTrue(mainPageObjects.Login());
        }

        [Test, Order(17)]
        [Description("Check Save translation button")]
        public void CheckSaveTranslationButton()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.IsFalse(mainPageObjects.SaveTranslation());
        }

        [Test, Order(18)]
        [Description("Copy translation button check")]
        public void CopyTranslation()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.CopyTranslation(TestSettings.inpFieldValueEn);

            Assert.AreEqual(TestSettings.outputFieldExpectedUa, actualResult, "Incorrect translation");
        }

        [Test, Order(19)]
        [Description("Check for Evaluate translation area")]
        public void CheckEvaluateTranslationArea()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.CheckEvaluateTranslationArea());
        }

        [Test, Order(20)]
        [Description("Check for Send translation via Twitter")]
        public void CheckSendTranslationTwitter()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.AreEqual(TestSettings.twitterUrl,mainPageObjects.CheckSendTranslationArea());
        }

        [Test, Order(21)]
        [Description("Check History")]
        public void CheckHistory()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);

            Assert.IsFalse(mainPageObjects.CheckHistoryArea());
        }

        
        [Test, Order(22)]
        [Description("Check Saved Translations")]
        public void CheckSavedTranslations()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            mainPageObjects.Login();

            Assert.IsFalse(mainPageObjects.SavedTranslations());
        }

        [Test, Order(23)]
        [Description("Check Contribute")]
        public void CheckContribute()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            mainPageObjects.Login();

            Assert.IsFalse(mainPageObjects.Contribute());
        }

        [Test, Order(24)]
        [Description("UA to EN.Correct translation")]
        public void CorrectUaToEn()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            mainPageObjects.ExchangeLanguage();
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueUa);

            Assert.AreEqual(TestSettings.outputFieldExpectedEn, actualResult, "Incorrect translation");
        }
    }
}