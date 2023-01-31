using OHCE.Langues;
using OHCE.TEST.xUNIT.Utilities;
using OHCE.TEST.xUNIT.Utilities.Builders;

namespace OHCE.TEST.xUNIT
{
    public class OhceTest
    {
        [Fact(DisplayName =
        "QUAND on entre une chaîne de caractères " +
        "ALORS celle-ci est renvoyée en miroir")]
        public void ReverseTest()
        {
            var ohce = new Ohce();

            var reverse = ohce.Palindrome("capricorne");

            Assert.Contains("enrocirpac", reverse);
        }

        [Fact(DisplayName = "QUAND on entre un Palindrome " +
                            "ALORS celui-ci est renvoyé ")]
        public void TestPalindrome()
        {
            var ohce = new Ohce();

            const string palindrome = "kayak";
            var reverse = ohce.Palindrome(palindrome);

            Assert.Contains(palindrome, reverse);
        }

        [Fact(DisplayName = "QUAND on saisit une chaîne " +
                            "Alors « Bonjour » est envoyé avant toute réponse ")]
        public void BonjourTest()
        {
            var ohce = new Ohce();

            var reverse = ohce.Palindrome(string.Empty);

            Assert.StartsWith("Bonjour", reverse);
        }

        [Fact(DisplayName = "QUAND on saisit une chaîne " +
                            "ALORS « Au revoir » est envoyé en dernier")]
        public void AurevoirTest()
        {
            var ohce = new Ohce();

            var reverse = ohce.Palindrome(string.Empty);

            Assert.StartsWith("Au revoir", reverse);
        }
    }
}