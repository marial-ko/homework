using System;

namespace LogicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = Input("k ");
            var m = Input("m ");
            var n = Input("n ");
            Console.WriteLine("Значение выражения "+F(k,m,n));

            Console.ReadKey();
        }
        static bool F(double k, double m, double n)
        {
            return k < 0 && m < 0 && n < 0;
        }
        static double Input(string name)
        {
            Console.WriteLine("Введите число " + name);
            return double.Parse(Console.ReadLine());
        }
    }
}
