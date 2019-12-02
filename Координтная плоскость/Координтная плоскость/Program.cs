using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Координтная_плоскость
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату точки по Х: ");
            var dotx = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату точки по Y: ");
            var doty = double.Parse(Console.ReadLine());

            if (dotx > 0 & doty > 0)
                Console.Write("Точка в 1 четверти");
            else if (dotx > 0 & doty < 0)
                Console.Write("Точка в 4 четверти");
            else if (dotx < 0 & doty > 0)
                Console.Write("Точка в 2 четверти");
            else if (dotx < 0 & doty < 0)
                Console.Write("Точка в 3 четверти");
            else if (dotx == 0)
                Console.Write("Точка на оси Y");
            else if (doty == 0)
                Console.Write("Точка на оси X");
            else if (dotx == 0 & doty == 0)
                Console.Write("Точка совпадает с началом координат");
            else
                Console.Write("Введено неверное значение");


            Console.ReadKey();
        }
    }
}
