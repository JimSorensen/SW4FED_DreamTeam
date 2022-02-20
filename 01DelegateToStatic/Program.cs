using System;

namespace _01DelegateToStatic
{
    class Program
    {
        delegate double Del(double x);

        static void Main(string[] args)
        {
            Del delInst = new Del(Math.Sin);
            double x = delInst(1.0);
            Console.WriteLine("Sin of 1,0 is: {0:f4}", x);
        }
    }
}
