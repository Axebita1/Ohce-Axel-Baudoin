using System.Text;

namespace OHCE
{
    public class Ohce
    {
        public Ohce() { }
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
                stringBuilder.Append(" - Mot inversé : " + reversedInput + "\n");
            }

            stringBuilder.Append(DireAuRevoir()); 
            return stringBuilder.ToString();
        }

        public string DireBonjour()
        {
            return "Bonjour";
        }

        public string DireAuRevoir()
        {
            return "Au revoir";
        }

        public string DireBienDit()
        {
            return " - Bien dit !";
        }
    }
}