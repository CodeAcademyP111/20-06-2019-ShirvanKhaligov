using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace averagetaskhw
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 12, 12, 12, 12, 1, 1212, 12, 12, 212, 12, 12, 1, 21, 1, 2, 12, 2, 1, 1, 2, 1, 2, 21, 1, 2, 12, 1, 2, 122, 2, 21, 121, 21, 21, 21,};
            float result = average(arr);
            Console.WriteLine(result);
            Console.ReadKey();
        }


        static float average(int[] num)
        {
            float result = 0F;

            for (int a = 0; a < num.Length; a++)
            {
                result += num[a];
            }
            return result / num.Length;

        }
    }
}
