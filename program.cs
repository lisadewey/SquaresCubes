using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_SquaresCubes
{
	class Program
	{
		static void Main(string[] args)
		{
			bool run = true;

			while (run)
			{
				run = DoWork();
			}

			Console.ReadLine();
		}

		public static void DisplayHeader(string dashes, string header)
		{
			Console.WriteLine(dashes);
			Console.SetCursorPosition((Console.WindowWidth - header.Length) / 2, Console.CursorTop);
			Console.WriteLine(header);
			Console.WriteLine(dashes);
		}

		public static bool DoWork()
		{
			string dashes = new string('-', Console.WindowWidth);
			string equal = new string('=', 7);
			string equalCubed = new string('=', 6);
			string header = "Learn your squares and cubes!";

			try
			{
				Console.Clear();
				DisplayHeader(dashes, header);

				Console.WriteLine();
				Console.Write("Please enter a whole number: ");
				int num = int.Parse(Console.ReadLine());
				Console.WriteLine();

				for (int i = 1; i <= num; i++)
				{
					Console.SetCursorPosition(0, 7);
					Console.WriteLine("Number");
					Console.SetCursorPosition(0, 8);
					Console.Write(equal);
					Console.SetCursorPosition(0, 8 + i);
					Console.WriteLine(i);

					Console.SetCursorPosition(10, 7);
					Console.WriteLine("Squared");
					Console.SetCursorPosition(10, 8);
					Console.WriteLine(equal);
					Console.SetCursorPosition(10, 8 + i);
					Console.WriteLine(Math.Pow(i,2));

					Console.SetCursorPosition(21, 7);
					Console.WriteLine("Cubed");
					Console.SetCursorPosition(21, 8);
					Console.WriteLine(equalCubed);
					Console.SetCursorPosition(21, 8 + i);
					Console.WriteLine(Math.Pow(i,3));
				}
			}

			catch
			{
				Console.WriteLine("You need to enter a whole number.");
			}

			return Continue();
		}
    
		public static bool Continue()
		{
			bool goOn = true;

			while (goOn)
			{
				Console.WriteLine();
				Console.Write("Do you wish to continue? (y/n): ");
				string input = Console.ReadLine();
				input = input.ToLower();
				Console.WriteLine();

				if (input == "n")
				{
					Console.WriteLine("Goodbye!");
					goOn = false;
				}
				else if (input == "y")
				{
					Console.WriteLine();
					return true;
				}
				else
				{
					Console.WriteLine("Sorry, I didn't understand that..");
					Console.WriteLine();
				}

			}

			Console.WriteLine();

			return goOn;
		}
	}
}
			

