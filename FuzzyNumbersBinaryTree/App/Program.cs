using App.BinaryTree;
using App.IO;
using App.FuzzyNumbers;

namespace App
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length < 1) 
			{
				Console.WriteLine("Not enough arguments. Please, specify file path.");
				Environment.Exit(-1);
			}

			var numbers = FileParser.Parse(args[0]);
			if (numbers == null)
			{
				Environment.Exit(-1);
			}

			Console.WriteLine("Tree creation...");
			var fuzzyBinaryTree = new BinaryTree<int>();
			foreach (var number in numbers)
			{
				Console.WriteLine("Defazzification of ({0} {1}):", number.A, number.B);
				var value = number.Defuzzify();
				fuzzyBinaryTree.Insert(value);
			}
			Console.WriteLine("Your tree:");
			TreePrinter.Print(fuzzyBinaryTree);

			do
			{
				Console.WriteLine("\nPlease, select option:");
				Console.WriteLine("1 - node deletion");
				Console.WriteLine("2 - tree printing");
				Console.WriteLine("3 - programme exit");

				var response = Console.ReadLine();

				switch (response)
				{
					case "1":
						Console.WriteLine("\nEnter node:");
						var toDelete = ConsoleParser.Parse(Console.ReadLine());
						if (toDelete != null)
						{
							Console.WriteLine("\nNode deletion...");
							var value = toDelete.Defuzzify();
							fuzzyBinaryTree.Remove(value);
							Console.WriteLine("Done.");
						}
						break;
					case "2":
						Console.WriteLine("\nYour tree:");
						TreePrinter.Print(fuzzyBinaryTree);
						break;
					case "3":
						Environment.Exit(0);
						break;
					default:
						Console.WriteLine("\nWrong option!");
						continue;
				}

			} while (true);
		}
	}
}
