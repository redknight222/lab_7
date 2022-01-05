using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double S1 = CalcTriangleSquare(3, 4, 5);
            double S2 = CalcTriangleSquare(6, 7, 8);
            if (S1 > S2)
            {
                Console.WriteLine("triangle 1 Square more than 2");
            }
            else
            {
                Console.WriteLine("triangle 2 Square more than 1");
            }
            Console.ReadKey();
        }
        static double CalcTriangleSquare(int x, int y, int z)
        {
            double p = (x + y + z) / 2;
            return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }
    }
}
