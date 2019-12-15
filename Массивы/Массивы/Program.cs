using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число меньшее или равное 20 ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите действительное число ");
            var y =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double[] numbers= new double[n];
            for (int i=0; i<n; i++)
            {
                numbers[i] = ElementsOfArray(y, i);
            }

            //foreach (var number in numbers)
            //    Console.Write("{0:F3} ",number);
            PrintArray(numbers);
            Console.WriteLine();
            SumOfElements(numbers);
            Console.WriteLine();
            Module(numbers);
            Console.WriteLine();
            ArrayOfDifferences(numbers, y);

            Console.ReadKey();
        }

        static double ElementsOfArray (double valueY, int valueN)
        {
            int factorial = 1;
            for (int i = 2; i <= valueN; i++) 
            {
                factorial = factorial * i;
            }
            return Math.Pow(valueY, valueN)/(factorial * Math.Pow(Math.E, valueY));
        }

        static void PrintArray(double []elements)
        {
            foreach (var element in elements)
                Console.Write("{0:F3} ", element);
        }

        static void SumOfElements (double[] elements)
        {
            for (var x=1; x<elements.Length; x++)
            {
                    elements[x] = elements[x] + elements[x-1];
            }
            foreach (var element in elements)
                Console.Write("{0:F3} ", element);
        }

        static void Module (double[] elements)
        {
            double difference;
            double sum = 0;
            for (var x=0; x<elements.Length-1; x++)
            {
                difference = elements[x] - elements[x+1];
                sum = sum + Math.Abs(difference);
            }
            Console.WriteLine("Сумма модулей = {0}", sum);
        }

        static void ArrayOfDifferences (double[] elements, double a)
        {
            for (var x=0; x<elements.Length; x++)
            {
                elements[x] = elements[x] - a;
            }
            Console.Write("Массив разностей: ");
            foreach (var element in elements)
                Console.Write("{0:F3} ", element);
        }
    }
}
