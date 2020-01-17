using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp89
{
    class Program
    {
        static void NWD (int a, int b)
        {
            if (a > b)
            {
                for (int i = a; i >= b; i--)
                {
                    if (a > b) a -= b;
                    if (b > a) b -= a;
                }
            }
            if (b>a)
            {
                for (int i = b; i >= a; i--)
                {
                    if (a > b) a -= b;
                    if (b > a) b -= a;
                }
            }
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            NWD(25, 15);
            NWD(40, 80);
            Console.ReadKey();
        }
    }
}
