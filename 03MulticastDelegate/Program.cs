using System;

namespace _03MulticastDelegate
{
    class Program
    {
        delegate void SomeEvent(int x, int y);
        static void Foo1(int x, int y)
        {
            Console.WriteLine("Foo1");
        }
        static void Foo2(int x, int y)
        {
            Console.WriteLine("Foo2");
        }

        static void Main(string[] args)
        {
            SomeEvent func = new SomeEvent(Foo1);
            func += new SomeEvent(Foo2);
            Console.WriteLine("Invoking func:");
            func(1, 2);             // Foo1 and Foo2 are called
            func -= new SomeEvent(Foo1);
            Console.WriteLine("Invoking func:");
            func(2, 3);             // Only Foo2 is called
        }   
    }
}
