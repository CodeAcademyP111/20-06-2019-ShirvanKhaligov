using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev_tapsiriqlarim
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Azerbaycan Guclu Dovletdir ve Azerbaycanin Guclu ordusu var";
            cntlttr(word);
        }
        static void cntlttr(string letter)
        {
            int count = 1;

            for (int c = 0; c < letter.Length; c++)
            {
                for (int a = 1; a < letter.Length; a++)
                {
                    if ((letter[c] == letter[a]) && (c != a))
                    {
                        count++;
                    }

                }
                Console.WriteLine(letter[c] + " - " + count + "  eded");
                count = 1;
            }
            Console.ReadKey();
        }
    }
}
