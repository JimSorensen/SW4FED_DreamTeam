using System;

namespace _10UdemySection3_v29
{
	public delegate void StringDelegate(string text);

	internal class Program
	{
		static void Main(string[] args)
		{
			StringDelegate stringDelegate = ToUpperCase;
			WriteOutput("this is a lowercase string", stringDelegate);
		}

		static void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());
		static void ToLowerCase(string text) => Console.WriteLine(text.ToLower());

		static void WriteOutput(string text, StringDelegate stringDelegate)
		{
			Console.WriteLine($"Before:{ text}");
			stringDelegate(text);
		}
	}
}
