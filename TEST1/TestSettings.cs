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
        public static string hostPrefixUaToEn = "https://translate.google.com/?sl=uk&tl=en&op=translate";
        public static string twitterUrl = "https://twitter.com/intent/tweet?text";
        public static string aboutGoogleTranslateUrl = "https://translate.google.com/about/?hl=ru";
        public static string rulesAndPrinciplesUrl = "https://policies.google.com/?hl=ru";
        public static string supportUrl = "https://support.google.com/translate/?hl=ru#topic=7011755";
        public static string aboutGoogleUrl = "https://about.google/?hl=ru";

        public const string inpFieldValueEn = "cup";
        public const string outputFieldExpectedEn = "cup";
        public const string outputFieldExpectedUa = "чашка";
        public const string inpFieldValueUa = "чашка";
        public const string login = "testusersg810@gmail.com";
        public const string password = "<erjnhtqk2022";

        public const int numberForRandomString = 12;
        public const int numberForRandomStringOver5000 = 5001;
    }
}
