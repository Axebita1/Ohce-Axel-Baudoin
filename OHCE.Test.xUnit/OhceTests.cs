using OHCE.Langues;
using OHCE.TEST.xUNIT.Utilities;
using OHCE.TEST.xUNIT.Utilities.Builders;

namespace OHCE.TEST.xUNIT
{
    public class OhceTest
    {
        [Fact(DisplayName =
        "QUAND on entre une cha�ne de caract�res " +
        "ALORS celle-ci est renvoy�e en miroir")]
        public void ReverseTest()
        {
            var ohce = new Ohce();

            var reverse = ohce.Palindrome("capricorne");

            Assert.Contains("enrocirpac", reverse);
        }

        [Fact(DisplayName = "QUAND on entre un Palindrome " +
                            "ALORS celui-ci est renvoy� ")]
        public void TestPalindrome()
        {
            var ohce = new Ohce();

            const string palindrome = "kayak";
            var reverse = ohce.Palindrome(palindrome);

            Assert.Contains(palindrome, reverse);
        }

        [Fact(DisplayName = "QUAND on saisit une cha�ne " +
                            "Alors ��Bonjour�� est envoy� avant toute r�ponse ")]
        public void BonjourTest()
        {
            var ohce = new Ohce();

            var reverse = ohce.Palindrome(string.Empty);

            Assert.StartsWith("Bonjour", reverse);
        }

        [Fact(DisplayName = "QUAND on saisit une cha�ne " +
                            "ALORS ��Au revoir�� est envoy� en dernier")]
        public void AurevoirTest()
        {
            var ohce = new Ohce();

            var reverse = ohce.Palindrome(string.Empty);

            Assert.StartsWith("Au revoir", reverse);
        }
    }
}