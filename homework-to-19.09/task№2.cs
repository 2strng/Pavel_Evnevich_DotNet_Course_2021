using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = -1;
            bool repeat = true;
            {


                Console.WriteLine("Задание №2");

                Console.Write("Введите число(string)");

                string input = Console.ReadLine();

                try
                {
                    num = Convert.ToInt32(input);
                    if (num < Int32.MaxValue)
                    {
                        Console.WriteLine("Значение числа - {0}" , +num);
                    }
                    else
                    {
                        Console.WriteLine("Значение num не может быть увеличено");
                    }
                }
                catch (FormatException)
                {

                }

            }

        }
    }
}
