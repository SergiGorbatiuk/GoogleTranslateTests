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
        [Test]
        [Description("EN to UA.Correct translation")]
        public void CorrectEnToUa()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.TranslateToUkr(TestSettings.inpFieldValueEn);

            Assert.AreEqual(TestSettings.outputFieldExpected, actualResult, "Incorrect translation");
        }

        [Test]
        [Description("EN to UA.Input fullfilled with random string")]
        public void RandomInputEnToUa()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string randomString = GenerateRandomData.GenerateRandomEnString(TestSettings.numberForRandomString);
            string actualResult = mainPageObjects.TranslateToUkr(randomString);

            Assert.AreEqual(randomString, actualResult);
        }

        [Test]
        [Description("EN to UA.Input fullfilled with 5001 characters")]
        public void InputEnToUaOver5000Char()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string randomString = GenerateRandomData.GenerateRandomNumber(TestSettings.numberForRandomStringOver5000);
            string actualResult = mainPageObjects.TranslateToUkr(randomString);

            Assert.IsTrue(mainPageObjects.Check5000CharField());
        }

        [Test]
        [Description("EN to UA.Input fullfilled with UA word")]
        public void UaTextIntoEnInput()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.TranslateToUkr(TestSettings.inpFieldValueUa);

            Assert.AreEqual(TestSettings.inpFieldValueUa, actualResult);
        }

        [Test]
        [Description("EN to UA.Input fullfilled with random string")]
        public void SymbolsCounterCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string randomString = GenerateRandomData.GenerateRandomEnString(TestSettings.numberForRandomString);
            string actualResult = mainPageObjects.TranslateToUkr(randomString);

            Assert.AreEqual(TestSettings.numberForRandomString, mainPageObjects.ReturnCounterValue());
        }

        [Test]
        [Description("Check 'ExchangeLanguages' button")]
        public void ExchangeLanguagesButtonCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string url = mainPageObjects.GetUrlAfterLangExchange();

            Assert.AreEqual(TestSettings.hostPrefixUaToEn, url);
        }

        [Test]
        [Description("Check 'Clear input field' icon click")]
        public void ClearInputFieldIconCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.TranslateToUkr(TestSettings.inpFieldValueEn);
            string inputFieldValue = mainPageObjects.ClearInputField();

            Assert.AreEqual(TestSettings.emptyField, inputFieldValue);
        }

        [Test]
        [Description("Check for definition area")]
        public void CheckDefinitionArea()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.TranslateToUkr(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.CheckDefinitionArea());
        }

        [Test]
        [Description("Check for More definitions button")]
        public void CheckMoreDefinitionsButton()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.TranslateToUkr(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.CheckMoreDefinitionsButton());
        }

        [Test]
        [Description("Check for Less definitions button")]
        public void CheckLessDefinitionsButton()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.TranslateToUkr(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.CheckShowLessDefinitionsButton());
        }

        [Test]
        [Description("Check for examples area")]
        public void CheckExamplesArea()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.TranslateToUkr(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.CheckExamplesArea());
        }

        [Test]
        [Description("Check for More examples button")]
        public void CheckMoreExamplesButton()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.TranslateToUkr(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.CheckMoreExamplesButton());
        }

        [Test]
        [Description("Check for Less examples button")]
        public void CheckLessExamplesButton()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.TranslateToUkr(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.CheckShowLessExamplesButton());
        }

        [Test]
        [Description("Check for Documents button")]
        public void CheckDocumentsButton()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            
            Assert.IsTrue(mainPageObjects.CheckDocumentsButton());
        }

        [Test]
        [Description("Check for Virt keyboard area")]
        public void CheckVirtKeyboardArea()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            
            Assert.IsTrue(mainPageObjects.CheckVirtKeyBoardOnButton());
        }

        [Test]
        [Description("EN to UA.Correct translation virt keyboard input")]
        public void CorrectEnToUaVirtKeyboardInput()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.TranslateToUkrVirtKeyboard();

            Assert.AreEqual(TestSettings.outputFieldExpected, actualResult, "Incorrect translation");
        }

        [Test]
        [Description("Check Save translation button")]
        public void CheckSaveTranslationButton()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.TranslateToUkr(TestSettings.inpFieldValueEn);

            Assert.IsFalse(mainPageObjects.SaveTranslation());
        }

        [Test]
        [Description("Copy translation button check")]
        public void CopyTranslation()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.CopyTranslation(TestSettings.inpFieldValueEn);

            Assert.AreEqual(TestSettings.outputFieldExpected, actualResult, "Incorrect translation");
        }

        [Test]
        [Description("Check for Evaluate translation area")]
        public void CheckEvaluateTranslationArea()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.TranslateToUkr(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.CheckEvaluateTranslationArea());
        }

        [Test]
        [Description("Check for Send translation via Twitter")]
        public void CheckSendTranslationTwitter()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.TranslateToUkr(TestSettings.inpFieldValueEn);

            Assert.AreEqual(TestSettings.twitterUrl,mainPageObjects.CheckSendTranslationArea());
        }

        [Test]
        [Description("Check History")]
        public void CheckHistory()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);

            Assert.IsFalse(mainPageObjects.CheckHistoryArea());
        }

        [Test]
        [Description("Check Login")]
        public void CheckLogin()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            
            Assert.IsTrue(mainPageObjects.Login());
        }

        [Test]
        [Description("Check Saved Translations")]
        public void CheckSavedTranslations()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            mainPageObjects.Login();

            Assert.IsFalse(mainPageObjects.SavedTranslations());
        }

        [Test]
        [Description("Check Contribute")]
        public void CheckContribute()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            mainPageObjects.Login();

            Assert.IsFalse(mainPageObjects.Contribute());
        }
    }
}