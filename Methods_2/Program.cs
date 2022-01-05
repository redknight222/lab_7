using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double S, V;
            CalcCubeSquareVolume(3,out S, out V);
            Console.WriteLine("Cube square ={0}", S);
            Console.WriteLine("Cube volume ={0}", V);
            Console.ReadKey();
        }
        static void CalcCubeSquareVolume(int a, out double S, out double V)
        {
            S = 6 * Math.Pow(a, 2);
            V = Math.Pow(a, 3);
        }
    }
}
