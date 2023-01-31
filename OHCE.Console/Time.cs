using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Console
{
    public class Time
    {
        public readonly PeriodeJournee PeriodeActuelle;
        public Time()
        {
            int hour = DateTime.Now.Hour;
            if (hour <= 7)
            {
                PeriodeActuelle = PeriodeJournee.Nuit;
            }
            else if (hour <= 12)
            {
                PeriodeActuelle = PeriodeJournee.Matin;
            }
            else if (hour <= 17)
            {
                PeriodeActuelle = PeriodeJournee.AprèsMidi;
            }
            else if (hour <= 23)
            {
                PeriodeActuelle = PeriodeJournee.Soir;
            }
            else
            {
                PeriodeActuelle = PeriodeJournee.Defaut;
            }
        }
    }
}
