using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа №1");

            Console.Write("Введите переменную a = ");

            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите переменную b = ");

            int y = int.Parse(Console.ReadLine());

            Swap(ref x,ref y);

        }


        public static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            Console.Write($"Переменная a = {a}, переменная b = {b} ");
        }

        

    }
}
