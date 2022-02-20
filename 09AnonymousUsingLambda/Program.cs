using System;

namespace _09AnonymousUsingLambda
{
    class Program
    {
        // Create a delegate type 
        delegate void Del(int x);

        static void Main(string[] args)
        {
            // Instantiate the delegate using a lambda expression
            Del d = k => Console.WriteLine($"Hello {k} times from lambda expression");

            d(27);
        }
    }
}
