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
        public string Bonjour(PeriodeJournee periode)
        {
            return periode == PeriodeJournee.Soir || periode == PeriodeJournee.Nuit ? Expressions.Français.Bonsoir : Expressions.Français.Bonjour;
        }
        public string AuRevoir(PeriodeJournee periode)
        {
            return periode == PeriodeJournee.Soir || periode == PeriodeJournee.Nuit ? Expressions.Français.AuRevoirSoir : Expressions.Français.AuRevoir;
        }
        public string LangageUtilise => Expressions.Français.LangueUtilisee;
        public string Periode => Expressions.Français.Periode;
        public string InputText => Expressions.Français.InputText;
        public string ReverseWord => Expressions.Français.ReverseWord;
    }
}
