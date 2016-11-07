using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharpPractice
{
	class Program
	{
		//declaring variables
		static int current_year;
		static int user_age;
		static String input_age;

		static void Main(string[] args)
		{
			//Finds the current ye
			current_year = DateTime.Now.Year;

			//Displays welcome
			Console.WriteLine("Hello World! It's currently " + current_year + "!");
			Thread.Sleep(2000);

			Console.Write("How old are you? ");
			input_age = Console.ReadLine();


			if (int.TryParse(input_age, out user_age))
			{
				Console.WriteLine("Wow! You're becoming ancient if you're " + user_age + "already!");
			}
			else
			{
				Console.WriteLine("Lame-ass, that's not an age.");
			}

			Console.Read();
		}
	}
}
