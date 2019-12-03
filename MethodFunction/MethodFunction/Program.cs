using System;

namespace MethodFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var x=F(2,3)+F(7,8)+F(1,4);
            Console.WriteLine("x={0:F3}", x);

            Console.ReadKey();
        }
        static double F(double x, double y)
        {
            return (Math.Sqrt(x+Math.Tan(y)))/(Math.Pow(x,2)+Math.Pow(y,2));
        }
    }
}
