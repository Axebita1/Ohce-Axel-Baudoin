using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public interface ILangue
    {
        string BienDit { get; }
        string Bonjour(PeriodeJournee periode);
        string AuRevoir(PeriodeJournee periode);
        string LangageUtilise { get; }
        string Periode { get; }
        string InputText { get; }
        string ReverseWord { get; }
    }
}
