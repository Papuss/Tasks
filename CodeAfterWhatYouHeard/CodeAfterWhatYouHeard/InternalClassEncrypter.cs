using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAfterWhatYouHeard
{
    class InternalClassEncrypter
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        static void Main(string[] args)
        {
            

        }

        private static string Encrypt(string textToEncrypt)
        {
            var encryptedText = "";
            foreach(var c in textToEncrypt)
            {
                if(Alphabet.IndexOf(char.ToUpper(c)) != -1)
                {
                    encryptedText += Alphabet[Alphabet.IndexOf(char.ToUpper(c)) *2 -26]; //Alphabet.IndexOf(char.ToUpper(c));

                }
                else
                {
                    encryptedText += c;
                }
            }
            return encryptedText;

        }
    }
}
