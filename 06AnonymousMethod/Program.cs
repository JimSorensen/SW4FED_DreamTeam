using System;

namespace _06AnonymousMethod
{
    class Program
    {
        // Create a delegate type 
        delegate void Del(int x);

        static void Main(string[] args)
        {
            // Instantiate the delegate using an anonymous method 
            Del d = delegate (int k) {
                Console.WriteLine($"Hello {k} times from anonymous");
            };

            d(27);
        }
    }
}
