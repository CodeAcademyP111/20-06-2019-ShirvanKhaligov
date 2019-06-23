using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversetask
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = "Hello Ali";
            string c = "";
            for (int i = b.Length - 1; i >= 0; i--)
            {

                Console.Write(b[i]);


            }
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
