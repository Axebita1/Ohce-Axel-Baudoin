using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Test.xUnit.Utilities.DoubleTest
{
    internal record MockLangue : ILangue
    {
        public string BienDit { get; init; } = string.Empty;
        public string Bonjour(PeriodeJournee periode) => string.Empty;
        public string AuRevoir(PeriodeJournee periode) => string.Empty;
        public string LangageUtilise { get; init; } = string.Empty;
        public string InputText { get; init; } = string.Empty;
        public string ReverseWord { get; init; } = string.Empty;
        public string Periode { get; init; } = string.Empty;
    }
}
