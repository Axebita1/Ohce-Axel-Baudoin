using System.Text;

namespace OHCE
{
    public class Ohce
    {
        private readonly ILangue _langue;
        public Ohce(ILangue langue)
        {
            _langue = langue;
        }
        public string Palindrome(string input)
        {

            var stringBuilder = new StringBuilder(DireBonjour() + '\n');
            var reversedInput = new string(input.Reverse().ToArray());

            if (reversedInput.Equals(input))
            {
                stringBuilder.Append(" - Palindrome : " + reversedInput + "\n" + DireBienDit() + "\n");
            }
            else
            {
                stringBuilder.Append(_langue.ReverseWord + " : " + reversedInput + "\n");
            }

            stringBuilder.Append(DireAuRevoir());
            return stringBuilder.ToString();
        }

        public string DireBonjour()
        {
            return _langue.Bonjour;
        }

        public string DireAuRevoir()
        {
            return _langue.AuRevoir;
        }

        public string DireBienDit()
        {
            return _langue.BienDit;
        }
    }
}