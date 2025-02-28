﻿using System;

namespace _02DelegateToInstance
{
    class Program
    {
		public class User
		{
			string name;
			public User(string name)
			{
				this.name = name;
			}
			public void Process(string message)
			{
				Console.WriteLine("{0}: {1}", name, message);
			}
		}
		class Test
		{
			delegate void ProcessHandler(string message);

			public static void Main()
			{
				User aUser = new User("George");
				ProcessHandler ph = new ProcessHandler(aUser.Process);

				ph("Wake Up!");
			}
		}
	}
}
