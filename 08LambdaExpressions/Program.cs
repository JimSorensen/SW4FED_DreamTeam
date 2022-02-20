using System;

namespace _08LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> returnLength;

            // Using an anonymous method to create a delegate instance: 
            returnLength = delegate (string text) { return text.Length; };
            Console.WriteLine(returnLength("Hello"));

            // A long-winded lambda expression:   
            returnLength = (string text) => { return text.Length; };
            Console.WriteLine(returnLength("Hello"));

            // If you can express the whole of the body in a single expression 
            returnLength = (string text) => text.Length;
            Console.WriteLine(returnLength("Hello"));

            // If the compiler can “guess” the parameter types: 
            returnLength = (text) => text.Length;
            Console.WriteLine(returnLength("Hello"));

            // When the lambda expression only needs a single parameter, and that parameter can be implicitly typed: 
            returnLength = text => text.Length;
            Console.WriteLine(returnLength("Hello"));
        }
    }
}
