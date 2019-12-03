using System;

namespace дз2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y,z;
            Console.Write("Введите первый катет ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Введите второй катет ");
            y = double.Parse(Console.ReadLine());
            z = Math.Sqrt(x * x + y * y);
            Console.Write("Площадь равна ");
            Console.WriteLine(0.5*x*y);
            Console.Write("Периметр равен ");
            Console.WriteLine(x + y + z);

            Console.ReadKey();

           

        }
    }
}
