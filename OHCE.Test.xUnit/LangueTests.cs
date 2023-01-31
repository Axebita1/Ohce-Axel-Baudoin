using OHCE.Langues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Test.xUnit
{
    public class LanguesTests
    {
        [Theory]
        [InlineData(PeriodeJournee.Soir, Expressions.Français.Bonsoir)]
        [InlineData(PeriodeJournee.Matin, Expressions.Français.Bonjour)]
        public void BonjourTest(PeriodeJournee periode, string salutationAttendue)
        {
            var langue = new LangueFR();
            var salutation = langue.Bonjour(periode);
            Assert.Equal(salutationAttendue, salutation);
        }

        [Theory]
        [InlineData(PeriodeJournee.Soir, Expressions.Français.AuRevoirSoir)]
        [InlineData(PeriodeJournee.Matin, Expressions.Français.AuRevoir)]
        public void AuRevoirTest(PeriodeJournee periode, string salutationAttendue)
        {
            var langue = new LangueFR();
            var auRevoir = langue.AuRevoir(periode);
            Assert.Equal(salutationAttendue, auRevoir);
        }
    }
}
