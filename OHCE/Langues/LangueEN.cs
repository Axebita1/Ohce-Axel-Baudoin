using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Langues
{
    public class LangueEN : ILangue
    {
        public string BienDit => Expressions.Anglais.BienDit;
        public string Bonjour => Expressions.Anglais.Bonjour;
        public string AuRevoir => Expressions.Anglais.AuRevoir;
        public string LangageUtilise => Expressions.Anglais.LangueUtilisee;
        public string InputText => Expressions.Anglais.InputText;
        public string ReverseWord => Expressions.Anglais.ReverseWord;
    }
}
