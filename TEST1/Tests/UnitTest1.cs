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
        public void CorrectEnToUaCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.AreEqual(TestSettings.outputFieldExpectedUa, actualResult, "Incorrect translation");
        }

        [Test, Order(1)]
        [Description("EN to UA.Input fullfilled with random string")]
        public void RandomInputEnToUaCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string randomString = GenerateRandomData.GenerateRandomEnString(TestSettings.numberForRandomString);
            string actualResult = mainPageObjects.Translate(randomString);

            Assert.AreEqual(randomString, actualResult);
        }

        [Test, Order(2)]
        [Description("EN to UA.Input fullfilled with 5001 characters")]
        public void InputEnToUaOver5000CharCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string randomString = GenerateRandomData.GenerateRandomNumber(TestSettings.numberForRandomStringOver5000);
            string actualResult = mainPageObjects.Translate(randomString);

            Assert.IsTrue(mainPageObjects.InputField5000Chars());
        }

        [Test, Order(3)]
        [Description("EN to UA.Input fullfilled with UA word")]
        public void UaTextIntoEnInputCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueUa);

            Assert.AreEqual(TestSettings.outputFieldExpectedUa, actualResult.ToLower());
        }

        [Test, Order(4)]
        [Description("Check input symbols counter")]
        public void SymbolsCounterCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string randomString = GenerateRandomData.GenerateRandomEnString(TestSettings.numberForRandomString);
            string actualResult = mainPageObjects.Translate(randomString);

            Assert.AreEqual(TestSettings.numberForRandomString, mainPageObjects.CounterValue());
        }

        [Test, Order(5)]
        [Description("Check 'ExchangeLanguages' button")]
        public void ExchangeLanguagesButtonCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string url = mainPageObjects.UrlAfterLangExchange();

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
        [Description("Check definition area")]
        public void DefinitionAreaCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.DefinitionArea());
        }

        [Test, Order(8)]
        [Description("Check 'More definitions' button")]
        public void MoreDefinitionsButtonCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.ShowMoreDefinitionsButton());
        }

        [Test, Order(9)]
        [Description("Check 'Less definitions' button")]
        public void LessDefinitionsButtonCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.ShowLessDefinitionsButton());
        }

        [Test, Order(10)]
        [Description("Check examples area")]
        public void ExamplesAreaCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.ExamplesArea());
        }

        [Test, Order(11)]
        [Description("Check 'More examples' button")]
        public void MoreExamplesButtonCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.ShowMoreExamplesButton());
        }

        [Test, Order(12)]
        [Description("Check 'Less examples' button")]
        public void LessExamplesButtonCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.ShowLessExamplesButton());
        }

        [Test, Order(13)]
        [Description("Check 'Documents' button")]
        public void DocumentsButtonCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            
            Assert.IsTrue(mainPageObjects.DocumentsButton());
        }

        [Test, Order(14)]
        [Description("Check 'Text' button")]
        public void TextButtonCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);

            Assert.IsTrue(mainPageObjects.TextButton(TestSettings.inpFieldValueEn));
        }

        [Test, Order(15)]
        [Description("Check Virtual keyboard area")]
        public void VirtKeyboardAreaCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            
            Assert.IsTrue(mainPageObjects.VirtKeyBoardOnButton());
        }

        [Test, Order(16)]
        [Description("EN to UA.Correct translation virtual keyboard input")]
        public void CorrectEnToUaVirtKeyboardInputCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.TranslateToUkrVirtKeyboard();

            Assert.AreEqual(TestSettings.outputFieldExpectedUa, actualResult, "Incorrect translation");
        }

        [Test, Order(17)]
        [Description("Check Login")]
        public void LoginCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);

            Assert.IsTrue(mainPageObjects.LoginButton());
        }

        [Test, Order(18)]
        [Description("Check 'Save translation' button")]
        public void SaveTranslationButtonCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.IsFalse(mainPageObjects.SaveTranslationButton());
        }

        [Test, Order(19)]
        [Description("Check 'Copy translation' button ")]
        public void CopyTranslationCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.CopyTranslationButton(TestSettings.inpFieldValueEn);

            Assert.AreEqual(TestSettings.outputFieldExpectedUa, actualResult.ToLower(), "Incorrect translation");
        }

        [Test, Order(20)]
        [Description("Check Evaluate translation area")]
        public void EvaluateTranslationAreaCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.IsTrue(mainPageObjects.EvaluateTranslationArea());
        }

        [Test, Order(21)]
        [Description("Check 'Send translation' via Twitter")]
        public void SendTranslationTwitterCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueEn);

            Assert.That(mainPageObjects.SendTranslationViaTwitter().Contains(TestSettings.twitterUrl));
        }

        [Test, Order(22)]
        [Description("Check 'History' button")]
        public void HistoryCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);

            Assert.IsFalse(mainPageObjects.HistoryArea());
        }

        
        [Test, Order(23)]
        [Description("Check 'Saved translations' button")]
        public void SavedTranslationsCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            mainPageObjects.LoginButton();

            Assert.IsFalse(mainPageObjects.SavedTranslationsButton());
        }

        [Test, Order(24)]
        [Description("Check 'Contribute' button")]
        public void ContributeCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            mainPageObjects.LoginButton();

            Assert.IsFalse(mainPageObjects.ContributeButton());
        }

        [Test, Order(25)]
        [Description("UA to EN.Correct translation")]
        public void CorrectUaToEnCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            mainPageObjects.ExchangeLanguageButton();
            string actualResult = mainPageObjects.Translate(TestSettings.inpFieldValueUa);

            Assert.AreEqual(TestSettings.outputFieldExpectedEn, actualResult, "Incorrect translation");
        }

        [Test, Order(26)]
        [Description("UA to En.Correct translation virtual keyboard input")]
        public void CorrectUaToEnVirtKeyboardInputCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);
            mainPageObjects.ExchangeLanguageButton();
            string actualResult = mainPageObjects.TranslateToEnVirtKeyboard();

            Assert.AreEqual(TestSettings.outputFieldExpectedEn, actualResult, "Incorrect translation");
        }

        [Test, Order(27)]
        [Description("Translation field not editable")]
        public void InputIntoTranslationFieldCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);

            Assert.IsFalse(mainPageObjects.InputIntoTranslationField(TestSettings.inpFieldValueEn));
        }

        [Test, Order(28)]
        [Description("Check 'About Google Translate' button")]
        public void AboutGoogleTranslateButtonCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);

            Assert.AreEqual(TestSettings.aboutGoogleTranslateUrl,mainPageObjects.AboutGoogleTranslateButton(),"Urls don't match");
        }

        [Test, Order(29)]
        [Description("Check 'Rules and Principles' button")]
        public void RulesAndPrinciplesButtonCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);

            Assert.AreEqual(TestSettings.rulesAndPrinciplesUrl, mainPageObjects.RulesAndPrinciplesButton(), "Urls don't match");
        }

        [Test, Order(30)]
        [Description("Check 'Support' button")]
        public void SupportButtonCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);

            Assert.AreEqual(TestSettings.supportUrl, mainPageObjects.SupportButton(), "Urls don't match");
        }

        [Test, Order(31)]
        [Description("Check 'About Google' button")]
        public void AboutGoogleButtonCheck()
        {
            var mainPageObjects = new MainPageObjects(_webDriver);

            Assert.AreEqual(TestSettings.aboutGoogleUrl, mainPageObjects.AboutGoogleButton(), "Urls don't match");
        }
    }
}