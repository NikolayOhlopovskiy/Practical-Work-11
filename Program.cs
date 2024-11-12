using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static double Fink1(int x)
        {
            return (4 * Math.Pow(x, 2) + 1) / (x - 5);
        }
        public static double Fink2(int x)
        {
            return (3 * Math.Pow(x, 2) - 2);
        }
        static void Main(string[] args)
        {
            //Задача 3.Вычисление значения функции: 
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            double y = x < 5 ? Fink1(x) : Fink2(x);
            Console.WriteLine($"y={y}");
            Console.ReadKey();

        }
    }
}
