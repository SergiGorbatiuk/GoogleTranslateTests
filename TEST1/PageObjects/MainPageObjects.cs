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
        private readonly By _virtKeyboardInputC = By.XPath("//button[@id='K67']");
        private readonly By _virtKeyboardInputU = By.XPath("//button[@id='K85']");
        private readonly By _virtKeyboardInputP = By.XPath("//button[@id='K80']");
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


        public MainPageObjects(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public string TranslateToUkr(string inputField)
        {
            _webDriver.FindElement(_textInputField).SendKeys(inputField);
            Expectation.WaitForElementVisible(_webDriver, _textOutputField);
            return _webDriver.FindElement(_textOutputField).Text;
        }

        public bool Check5000CharField()
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

        public int ReturnCounterValue()
        {
            return Convert.ToInt32(_webDriver.FindElement(_charCounterValue).Text);
        }

        public string GetUrlAfterLangExchange()
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

        public bool CheckDefinitionArea()
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

        public bool CheckMoreDefinitionsButton()
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

        public bool CheckShowLessDefinitionsButton()
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

        public bool CheckExamplesArea()
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

        public bool CheckMoreExamplesButton()
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

        public bool CheckShowLessExamplesButton()
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

        public bool CheckDocumentsButton()
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

        public bool CheckVirtKeyBoardOnButton()
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
            _webDriver.FindElement(_virtKeyboardInputShift).Click();
            _webDriver.FindElement(_virtKeyboardInputC).Click();
            _webDriver.FindElement(_virtKeyboardInputU).Click();
            _webDriver.FindElement(_virtKeyboardInputP).Click();
            Expectation.WaitForElementVisible(_webDriver, _textOutputField);
            return _webDriver.FindElement(_textOutputField).Text;
        }

        public bool SaveTranslation()
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

        public string CopyTranslation(string inputField)
        {
            _webDriver.FindElement(_textInputField).SendKeys(inputField);
            Expectation.WaitForElementClickable(_webDriver, _copyTranslationButton);
            _webDriver.FindElement(_copyTranslationButton).Click();
            _webDriver.FindElement(_clearInputIcon).Click();
            _webDriver.FindElement(_textInputField).SendKeys(Keys.Control + "v");
            Expectation.WaitForElementVisible(_webDriver, _textOutputField);
            return _webDriver.FindElement(_textOutputField).Text;
        }

        public bool CheckEvaluateTranslationArea()
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

        public string CheckSendTranslationArea()
        {
            Expectation.WaitForElementClickable(_webDriver, _sendTranslationButton);
            _webDriver.FindElement(_sendTranslationButton).Click();
            Expectation.WaitForElementVisible(_webDriver, _sendTranslationArea);
            _webDriver.FindElement(_sendTranslationArea);
            _webDriver.FindElement(_sendTranslationToTwitterButton).Click();
            _webDriver.SwitchTo().Window(_webDriver.WindowHandles[1]);
            return _webDriver.Url;
        }

        public bool CheckHistoryArea()
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

        public bool Login()
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

        public bool SavedTranslations()
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

        public bool Contribute()
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
    }  
}
