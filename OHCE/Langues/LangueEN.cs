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
        public string Bonjour(PeriodeJournee periode)
        {
            return periode == PeriodeJournee.Soir || periode == PeriodeJournee.Nuit ? Expressions.Anglais.Bonsoir : Expressions.Anglais.Bonjour;
        }
        public string AuRevoir(PeriodeJournee periode)
        {
            return periode == PeriodeJournee.Soir || periode == PeriodeJournee.Nuit ? Expressions.Anglais.AuRevoirSoir : Expressions.Anglais.AuRevoir;
        }
        public string LangageUtilise => Expressions.Anglais.LangueUtilisee;
        public string Periode => Expressions.Anglais.Periode;
        public string InputText => Expressions.Anglais.InputText;
        public string ReverseWord => Expressions.Anglais.ReverseWord;
    }
}
