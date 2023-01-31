using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using OHCE.Langues;

namespace OHCE.Console
{
    public class Proxy
    {
        public ILangue Langue;
        public Proxy()
        {
            var systemLang = CultureInfo.InstalledUICulture.TwoLetterISOLanguageName;
            if (systemLang == "fr")
            {
                Langue = new LangueFR();
            }
            else
            {
                Langue = new LangueEN();
            }
        }
    }
}
