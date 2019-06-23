using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            int ctr = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    ctr++;
                }


            }
            Console.WriteLine("number of space is : " + ctr);
            Console.ReadKey();







        }
    }
}
