using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПлотностьВоздуха
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n (от 10 до 100)");
            var n = int.Parse(Console.ReadLine());
            if (n > 100 || n < 10)
            {
                Console.WriteLine("Нужно ввести число от 10 до 100");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Зависимость плотности от высоты ");
            for (int i = 0; i <= n ; i++)
                Console.WriteLine("|  {0} м  |  {1}  |", i*100, Formula(i*100));

            Console.ReadKey();
        }
        static double Formula(double j)
        {
            return 1.29 * Math.Pow(2.7, -1.25 * Math.Pow(10, -4) * j);
        }
    }
}
