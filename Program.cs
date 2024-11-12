using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int Sum (int x, int y)
        {
            return x+y;
        }
       public static int Dif (int x, int y)
        {
            return x-y;
        }
        public static int Proiz (int x, int y)
        {
            return x * y;
        }
        public static int Chast(int x, int y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            //Задача 2.Нахождение суммы, разности,
            //произведения и частного двух целых чисел с использованием дополнительных методов.
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y=");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Sum(x,y)}");
            Console.WriteLine($"{Dif(x, y)}");
            Console.WriteLine($"{Proiz(x, y)}");
            Console.WriteLine($"{Chast(x, y)}");
            Console.ReadKey();
        }
    }
}
