using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTranslateTests
{
    public class TestSettings
    {
        public static string hostPrefixEnToUk = "https://translate.google.com/?sl=en&tl=uk&op=translate";
        public static string locationEnToUk = "https://translate.google.com/?sl=en&tl=uk&op=translate";
        public static string hostPrefixUaToEn = "https://translate.google.com/?sl=uk&tl=en&op=translate";
        public static string twitterUrl = "https://twitter.com/intent/tweet?text=%D0%A7%D0%B0%D1%88%D0%BA%D0%B0";

        public const string inpFieldValueEn = "Cup";
        public const string outputFieldExpected = "Чашка";
        public const string inpFieldValueUa = "Чашка";
        public const string emptyField = "";
        public const string login = "testusersg810@gmail.com";
        public const string password = "<erjnhtqk2022";

        public const int numberForRandomString = 12;
        public const int numberForRandomStringOver5000 = 5001;
    }
}
