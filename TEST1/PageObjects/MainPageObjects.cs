using GoogleTranslateTests;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoogleTranslateTests.PageObjects
{
    class MainPageObjects
    {
        private IWebDriver _webDriver;

        private readonly By _textInputField = By.XPath("//textarea[@class='er8xn']");
        private readonly By _textOutputField = By.XPath("//span[@jsname='W297wb']");
        private readonly By _over5000CharText = By.XPath("//div[@class='ZJGYz hJy9xb']");
        private readonly By _charCounterValue = By.XPath("//span[@jsname='qKMVIf']");
        private readonly By _exchangeLanguageButton = By.XPath("//button[@jsname='dnDxad']");
        private readonly By _clearInputIcon = By.XPath("//button[@class='VfPpkd-Bz112c-LgbsSe VfPpkd-Bz112c-LgbsSe-OWXEXe-e5LLRc-SxQuSe yHy1rc eT1oJ qiN4Vb GA2I6e']");
        private readonly By _definitionArea = By.XPath("//div[@jsname='SjRXy']");
        private readonly By _showMoreDefinitionsButton = By.XPath("//*[contains(text(),'Показать все определения')]");
        private readonly By _showLessDefinitionsButton = By.XPath("//*[contains(text(),'Скрыть часть определений')]");
        private readonly By _examplesArea = By.XPath("//div[@jsname='yaOFF']");
        private readonly By _showMoreExamplesButton = By.XPath("//*[contains(text(),'Показать все примеры')]");
        private readonly By _showLessExamplesButton = By.XPath("//*[contains(text(),'Скрыть часть примеров')]");
        private readonly By _documentsButton = By.XPath("//button[@data-idom-class='Rj2Mlf OLiIxf PDpWxe hL2wFc']");
        private readonly By _chooseDocumentButton = By.XPath("//div[@class='hYXSWe']");
        private readonly By _turnOnVirtKeyboardButton = By.XPath("//span[@class='ita-kd-img ita-icon-0 ita-kd-icon ita-kd-icon-span']");
        private readonly By _virtKeyboardArea = By.XPath("//div[@id='kbd']");
        private readonly By _virtKeyboardInputShift = By.XPath("//button[@id='K16']");
        private readonly By _virtKeyboardEnInputC = By.XPath("//button[@id='K67']");
        private readonly By _virtKeyboardEnInputU = By.XPath("//button[@id='K85']");
        private readonly By _virtKeyboardEnInputP = By.XPath("//button[@id='K80']");
        private readonly By _saveTranslationButton = By.XPath("//button[@jsname='NakZHc']");
        private readonly By _saveTranslationDialogue = By.XPath("//div[@class='VfPpkd-P5QLlc']");
        private readonly By _saveTranslationDialogueCancelButton = By.XPath("//button[@data-mdc-dialog-action='Cancel']");
        private readonly By _copyTranslationButton = By.XPath("//button[@jsname='kImuFf']");
        private readonly By _evaluateTranslationButton = By.XPath("//button[@jsname='IOOiDc']");
        private readonly By _evaluateTranslationArea = By.XPath("//div[@class='c3PRjf']");
        private readonly By _sendTranslationButton = By.XPath("//button[@jsname='ymIaV']");
        private readonly By _sendTranslationArea = By.XPath("//div[@class='MmZJl']");
        private readonly By _sendTranslationToTwitterButton = By.XPath("//div[@class='ReT2Xe']");
        private readonly By _historyButton = By.XPath("//a[@class='mqNsCe tQlvad']");
        private readonly By _historyArea = By.XPath("//div[@class='VfPpkd-P5QLlc']");
        private readonly By _closeHistoryButton = By.XPath("//button[@data-mdc-dialog-action='Cancel']");
        private readonly By _loginButton = By.XPath("//a[@class='gb_1 gb_2 gb_6d gb_6c']");
        private readonly By _loginUsernameInputField = By.XPath("//input[@name='identifier']");
        private readonly By _loginNextButton = By.XPath("//button[@jsname='LgbsSe']");
        private readonly By _loginPasswordInputField = By.XPath("//input[@name='password']");
        private readonly By _successfulLoginDisplayField = By.XPath("//a[@href='https://accounts.google.com/SignOutOptions?hl=ru&continue=https://translate.google.com/%3Fsl%3Den%26tl%3Duk%26op%3Dtranslate']");
        private readonly By _savedButton = By.XPath("//a[@class='mqNsCe jq8G6c']");
        private readonly By _savedArea = By.XPath("//div[@class='gRC91']");
        private readonly By _closeSavedButton = By.XPath("//button[contains(@class,'yHy1rc eT1oJ qiN4Vb xxmGGf')]");
        private readonly By _contributeButton = By.XPath("//a[@href='./contribute']");
        private readonly By _contributeArea = By.XPath("//div[@class='oCxMfe']");
        private readonly By _closeContributeButton = By.XPath("//button[contains(@class,'VfPpkd-Bz112c-LgbsSe yHy1rc eT1oJ INImOe clr7zd')]");
        private readonly By _textButton = By.XPath("//button[contains(@class,'Rj2Mlf OLiIxf PDpWxe irkilc')]");
        private readonly By _mainMenuButton = By.XPath("//div[@class='gb_xc']");
        private readonly By _aboutGoogleTranslateButton = By.XPath("//a[@jsname='wNMsOe']");
        private readonly By _rulesAndPrinciplesButton = By.XPath("//a[@jsname='abkpZe']");
        private readonly By _supportButton = By.XPath("//a[@jsname='h9d3hd']");
        private readonly By _aboutGoogleButton = By.XPath("//a[@jsname='MMRVdf']");
        private readonly By _chooseInputTypeDropdown = By.XPath("//a[@class='ita-kd-icon-button ita-kd-dropdown ita-kd-right']");
        private readonly By _inputUaVirtKeyboardButton = By.XPath("//*[contains(text(),'Украинский')][1]");
        private readonly By _virtKeyboardInputUaCh = By.XPath("//button[@id='K88']");
        private readonly By _virtKeyboardInputUaA = By.XPath("//button[@id='K70']");
        private readonly By _virtKeyboardInputUaSh = By.XPath("//button[@id='K73']");
        private readonly By _virtKeyboardInputUaK = By.XPath("//button[@id='K82']");

        public MainPageObjects(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public string Translate(string inputField)
        {
            _webDriver.FindElement(_textInputField).SendKeys(inputField);
            Expectation.WaitForElementVisible(_webDriver, _textOutputField);
            return _webDriver.FindElement(_textOutputField).Text;
        }

        public bool InputField5000Chars()
        {
            try
            {
                _webDriver.FindElement(_over5000CharText);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public int CounterValue()
        {
            return Convert.ToInt32(_webDriver.FindElement(_charCounterValue).Text);
        }

        public void ExchangeLanguageButton()
        {
            _webDriver.FindElement(_exchangeLanguageButton).Click();
        }

        public string UrlAfterLangExchange()
        {
            _webDriver.FindElement(_exchangeLanguageButton).Click();
            return _webDriver.Url;
        }

        public string ClearInputField()
        {
            Expectation.WaitForElementClickable(_webDriver, _clearInputIcon);
            _webDriver.FindElement(_clearInputIcon).Click();
            return _webDriver.FindElement(_textInputField).Text;
        }

        public bool DefinitionArea()
        {
            try
            {
                _webDriver.FindElement(_definitionArea);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool ShowMoreDefinitionsButton()
        {
            try
            {
                _webDriver.FindElement(_showMoreDefinitionsButton);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool ShowLessDefinitionsButton()
        {
            try
            {
                _webDriver.FindElement(_showMoreDefinitionsButton).Click();
                _webDriver.FindElement(_showLessDefinitionsButton);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool ExamplesArea()
        {
            try
            {
                _webDriver.FindElement(_examplesArea);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool ShowMoreExamplesButton()
        {
            try
            {
                _webDriver.FindElement(_showMoreExamplesButton);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool ShowLessExamplesButton()
        {
            try
            {
                _webDriver.FindElement(_showMoreExamplesButton).Click();
                _webDriver.FindElement(_showLessExamplesButton);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool DocumentsButton()
        {
            try
            {
                _webDriver.FindElement(_documentsButton).Click();
                Expectation.WaitForElementClickable(_webDriver,_chooseDocumentButton);
                _webDriver.FindElement(_chooseDocumentButton).Click();
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool VirtKeyBoardOnButton()
        {
            try
            {
                Expectation.WaitForElementClickable(_webDriver, _turnOnVirtKeyboardButton);
                _webDriver.FindElement(_turnOnVirtKeyboardButton).Click();
                Expectation.WaitForElementVisible(_webDriver, _virtKeyboardArea);
                _webDriver.FindElement(_virtKeyboardArea);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public string TranslateToUkrVirtKeyboard()
        {
            Expectation.WaitForElementClickable(_webDriver, _turnOnVirtKeyboardButton);
            _webDriver.FindElement(_turnOnVirtKeyboardButton).Click();
            _webDriver.FindElement(_virtKeyboardEnInputC).Click();
            _webDriver.FindElement(_virtKeyboardEnInputU).Click();
            _webDriver.FindElement(_virtKeyboardEnInputP).Click();
            Expectation.WaitForElementVisible(_webDriver, _textOutputField);
            return _webDriver.FindElement(_textOutputField).Text;
        }

        public bool SaveTranslationButton()
        {
            try
            {
                Expectation.WaitForElementClickable(_webDriver, _saveTranslationButton);
                _webDriver.FindElement(_saveTranslationButton).Click();
                Expectation.WaitForElementVisible(_webDriver, _saveTranslationDialogue);
                _webDriver.FindElement(_saveTranslationDialogue);
                _webDriver.FindElement(_saveTranslationDialogueCancelButton).Click();
                Thread.Sleep(400);
                _webDriver.FindElement(_saveTranslationDialogue);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public string CopyTranslationButton(string inputField)
        {
            _webDriver.FindElement(_textInputField).SendKeys(inputField);
            Expectation.WaitForElementClickable(_webDriver, _copyTranslationButton);
            _webDriver.FindElement(_copyTranslationButton).Click();
            _webDriver.FindElement(_clearInputIcon).Click();
            _webDriver.FindElement(_textInputField).SendKeys(Keys.Control + "v");
            Expectation.WaitForElementVisible(_webDriver, _textOutputField);
            return _webDriver.FindElement(_textOutputField).Text;
        }

        public bool EvaluateTranslationArea()
        {
            try
            {
                Expectation.WaitForElementClickable(_webDriver, _evaluateTranslationButton);
                _webDriver.FindElement(_evaluateTranslationButton).Click();
                Expectation.WaitForElementVisible(_webDriver, _evaluateTranslationArea);
                _webDriver.FindElement(_evaluateTranslationArea);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public string SendTranslationViaTwitter()
        {
            Expectation.WaitForElementClickable(_webDriver, _sendTranslationButton);
            _webDriver.FindElement(_sendTranslationButton).Click();
            Expectation.WaitForElementVisible(_webDriver, _sendTranslationArea);
            _webDriver.FindElement(_sendTranslationArea);
            _webDriver.FindElement(_sendTranslationToTwitterButton).Click();
            _webDriver.SwitchTo().Window(_webDriver.WindowHandles[1]);
            return _webDriver.Url;
        }

        public bool HistoryArea()
        {
            try
            {
                _webDriver.FindElement(_historyButton).Click();
                Expectation.WaitForElementVisible(_webDriver, _historyArea);
                _webDriver.FindElement(_historyArea);
                _webDriver.FindElement(_closeHistoryButton).Click();
                Thread.Sleep(1000);
                _webDriver.FindElement(_historyArea);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool LoginButton()
        {
            try
            {
                _webDriver.FindElement(_loginButton).Click();
                Expectation.WaitForElementVisible(_webDriver, _loginUsernameInputField);
                _webDriver.FindElement(_loginUsernameInputField).SendKeys(TestSettings.login);
                _webDriver.FindElement(_loginNextButton).Click();
                Expectation.WaitForElementVisible(_webDriver, _loginPasswordInputField);
                _webDriver.FindElement(_loginPasswordInputField).SendKeys(TestSettings.password);
                Expectation.WaitForElementClickable(_webDriver, _loginNextButton);
                _webDriver.FindElement(_loginNextButton).Click();
                Expectation.WaitForElementVisible(_webDriver, _successfulLoginDisplayField);
                _webDriver.FindElement(_successfulLoginDisplayField);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool SavedTranslationsButton()
        {
            try
            {
                _webDriver.FindElement(_savedButton).Click();
                Expectation.WaitForElementVisible(_webDriver, _savedArea);
                _webDriver.FindElement(_savedArea);
                _webDriver.FindElement(_closeSavedButton).Click();
                Thread.Sleep(1000);
                _webDriver.FindElement(_savedArea);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool ContributeButton()
        {
            try
            {
                _webDriver.FindElement(_contributeButton).Click();
                Expectation.WaitForElementVisible(_webDriver, _contributeArea);
                _webDriver.FindElement(_contributeArea);
                _webDriver.FindElement(_closeContributeButton).Click();
                Thread.Sleep(1000);
                _webDriver.FindElement(_contributeArea);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool InputIntoTranslationField(string text)
        {
            try
            {
                _webDriver.FindElement(_textOutputField).SendKeys(text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool TextButton(string inputField)
        {
            try
            {
                _webDriver.FindElement(_documentsButton).Click();
                Expectation.WaitForElementClickable(_webDriver,_textButton);
                _webDriver.FindElement(_textButton).Click();
                Expectation.WaitForElementVisible(_webDriver, _textInputField);
                _webDriver.FindElement(_textInputField).SendKeys(inputField);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string AboutGoogleTranslateButton()
        {
             _webDriver.FindElement(_mainMenuButton).Click();
             Expectation.WaitForElementVisible(_webDriver, _aboutGoogleTranslateButton);
             _webDriver.FindElement(_aboutGoogleTranslateButton).Click();
             return _webDriver.Url.ToString();
        }

        public string RulesAndPrinciplesButton()
        {
            _webDriver.FindElement(_mainMenuButton).Click();
            Expectation.WaitForElementVisible(_webDriver, _rulesAndPrinciplesButton);
            _webDriver.FindElement(_rulesAndPrinciplesButton).Click();
            return _webDriver.Url.ToString();
        }

        public string SupportButton()
        {
            _webDriver.FindElement(_mainMenuButton).Click();
            Expectation.WaitForElementVisible(_webDriver, _supportButton);
            _webDriver.FindElement(_supportButton).Click();
            return _webDriver.Url.ToString();
        }

        public string AboutGoogleButton()
        {
            _webDriver.FindElement(_mainMenuButton).Click();
            Expectation.WaitForElementVisible(_webDriver, _aboutGoogleButton);
            _webDriver.FindElement(_aboutGoogleButton).Click();
            return _webDriver.Url.ToString();
        }

        public string TranslateToEnVirtKeyboard()
        {
            Expectation.WaitForElementClickable(_webDriver, _chooseInputTypeDropdown);
            _webDriver.FindElement(_chooseInputTypeDropdown).Click();
            Expectation.WaitForElementClickable(_webDriver, _inputUaVirtKeyboardButton);
            _webDriver.FindElement(_inputUaVirtKeyboardButton).Click();
            _webDriver.FindElement(_virtKeyboardInputUaCh).Click();
            _webDriver.FindElement(_virtKeyboardInputUaA).Click();
            _webDriver.FindElement(_virtKeyboardInputUaSh).Click();
            _webDriver.FindElement(_virtKeyboardInputUaK).Click();
            _webDriver.FindElement(_virtKeyboardInputUaA).Click();
            Expectation.WaitForElementVisible(_webDriver, _textOutputField);
            return _webDriver.FindElement(_textOutputField).Text;
        }
    }  
}
