using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamePVP
{
    //Bron: https://www.geeksforgeeks.org/convert-string-binary-sequence/
    //TODO: Hashing hoe sla ik een wachtwoord veilig op
    internal class Encoding
    {
        public string StrToByte (string s)
        {
            int n = s.Length;
            string bin = "";
            foreach (char letter in s)
            {
                int index = s.IndexOf(letter);
                int val = s[index];
                while (val > 0)
                {
                    if (val % 2 == 1)
                    {
                        bin += '1';
                    }
                    else
                    {
                        bin += "0";
                    }
                    val /= 2;

                }
            }
            return bin;
        }
    }
}
