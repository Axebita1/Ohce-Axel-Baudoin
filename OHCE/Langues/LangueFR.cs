using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Langues
{
    public class LangueFR : ILangue
    {
        public string BienDit => Expressions.Français.BienDit;
        public string Bonjour => Expressions.Français.Bonjour;
        public string AuRevoir => Expressions.Français.AuRevoir;
        public string LangageUtilise => Expressions.Français.LangueUtilisee;
        public string InputText => Expressions.Français.InputText;
        public string ReverseWord => Expressions.Français.ReverseWord;
    }
}
