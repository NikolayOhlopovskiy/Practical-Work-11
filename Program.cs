using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        public static void SayHello()
        {
            Console.WriteLine("Привет");
        }
        public static void SayBuy()
        {
            Console.WriteLine("Прощай");
        }
        static void Main(string[] args)
        {
            Задача 1.Вывод  сообщений приветствия
            и прощания с использованием дополнительных методов.
            SayHello();
            SayBuy();
            Console.ReadKey();

        }
    }
}
