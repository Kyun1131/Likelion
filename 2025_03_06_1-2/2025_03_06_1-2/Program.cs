using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_03_06_1_2
{
    

    class Program
    {
        static void Increase(ref int x)
        {
            x++;
        }


        static void Main(string[] args)
        {
            int a = 10;
            Increase(ref a);

            Console.WriteLine("A의 값: " + a);

        }
    }
}
