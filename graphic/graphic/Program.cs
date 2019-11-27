using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите х ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите у ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Принадлежит ли точка графику: " +graphic (y));
            Console.ReadKey();
        }
        static bool graphic (double y)
        {
            return y > 1 || y < -3;
        }
        
    }
}
