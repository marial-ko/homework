using System;

namespace дз3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("Введите х: ");
            x = double.Parse(Console.ReadLine());
            y = (2 / (x * x + 25) + Math.Cos(x)) / Math.Sqrt(x * x * x * x + 1) + (Math.Sin(x) + Math.Cos(x)) / 2;
            Console.WriteLine(y);

            Console.ReadKey();

        }
    }
}
