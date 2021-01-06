using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAplikacija.Tools
{
    /// <summary>
    /// Enum used for setting the language in WFAplikacija.Tools.LanguageManager
    /// </summary>
    public enum Language
    {
        English, Croatian
    }

    class LanguageManager
    {

        public static void SetLanguage(Language lang)
        {
            if (lang == Language.English)
            {
                WFAplikacija.Lang.Dictionary.Culture = new System.Globalization.CultureInfo("en-US");
            }
            else if (lang == Language.Croatian)
            {
                WFAplikacija.Lang.Dictionary.Culture = new System.Globalization.CultureInfo("hr-HR");
            }
        }
    }
}
