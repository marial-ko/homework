using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinCos
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSinCos(13);
            PrintSinCos(37);
            PrintSinCos(113);
            Console.Write("Введите значение угла в градусах ");
            var angle = double.Parse(Console.ReadLine());
            PrintSinCos(angle);
            Console.ReadKey();

            void PrintSinCos (double angleInDegrees)
            {
                double sin = Math.Sin(ConvertDegreesToRadians(angleInDegrees));
                double cos = Math.Cos(ConvertDegreesToRadians(angleInDegrees));
                Console.WriteLine("Синус угла {0} = {1:0.###}\n Косинус угла {0} = {2:0.###}", angleInDegrees, sin, cos);
            }

            double ConvertDegreesToRadians (double angleInDeegrees)
            {
                return angleInDeegrees * Math.PI / 180;
            }
        }
    }
}
