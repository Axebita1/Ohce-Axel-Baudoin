using OHCE.Langues;
using OHCE.Test.xUnit.Utilities;
using OHCE.Test.xUnit.Utilities.Builders;
namespace OHCE.Test.xUnit;
public class OhceTest
{
    [Fact(DisplayName =
        "QUAND on entre une cha�ne de caract�res " +
        "ALORS elle est renvoy�e en miroir")]
    public void ReverseTest()
    {
        var ohce = OhceBuilder.Base;
        var reversed = ohce.Palindrome("capricorne");

        Assert.Contains("enrocirpac", reversed);
    }
    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
        "QUAND on entre un palindrome " +
        "ALORS celui-ci est renvoy� " +
        "ET le <bienDit> de cette langue est envoy�")]
    [MemberData(nameof(LanguesSeules))]
    public void PalindromeTest(ILangue langue)
    {
        var ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .Build();
        const string palindrome = "kayak";
        var reversed = ohce.Palindrome(palindrome);
        Assert.Contains(palindrome + langue.BienDit, reversed);
    }
    private static readonly IEnumerable<ILangue> Langues = new ILangue[]
    {
        new LangueEN(),
        new LangueFR()
    };

    private static readonly IEnumerable<PeriodeJournee> P�riodes = new PeriodeJournee[]
    {
        PeriodeJournee.Defaut,
        PeriodeJournee.Matin,
        PeriodeJournee.Apr�sMidi,
        PeriodeJournee.Soir,
        PeriodeJournee.Nuit
    };

    public static IEnumerable<object[]> LanguesSeules => new CartesianData(Langues);
    public static IEnumerable<object[]> LanguesEtP�riodes => new CartesianData(Langues, P�riodes);

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
        "ET que la p�riode de la journ�e est <p�riode>" +
        "QUAND l'app d�marre " +
        "ALORS <bonjour> de cette langue � cette p�riode est envoy�")]
    [MemberData(nameof(LanguesSeules))]
    public void D�marrageTest(ILangue langue, PeriodeJournee periode)
    {
        var ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .AyantPourPeriodeDeLaJournee(periode)
            .Build();

        var reversed = ohce.Palindrome(string.Empty);

        Assert.StartsWith(langue.Bonjour(periode), reversed);
    }

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
        "ET que la p�riode de la journ�e est <p�riode>" +
        "QUAND l'app se ferme " +
        "ALORS <auRevoir> dans cette langue est envoy�")]
    [MemberData(nameof(LanguesSeules))]
    public void FermetureTest(ILangue langue, PeriodeJournee periode)
    {
        var ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .AyantPourPeriodeDeLaJournee(periode)
            .Build();

        var reversed = ohce.Palindrome(string.Empty);

        Assert.EndsWith(langue.AuRevoir(periode), reversed);
    }
}