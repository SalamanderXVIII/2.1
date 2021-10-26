using System;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.1. 2-й вариант, высокий уровень, Гребенюк.
            Console.WriteLine("Введите значение x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            int y = int.Parse(Console.ReadLine());
            double r = Math.Sqrt(x * x + y * y);
            if (r <= 1)
                Console.WriteLine("Точка не попадает в область определения.");
            else if ((x <= 1) && (x >= -1) && (y <= 1) && (y >= -1))
                Console.WriteLine("Точка попадает в область определения.");
            else
                Console.WriteLine("Точка не попадает в область определения.");
        }
    }
}
