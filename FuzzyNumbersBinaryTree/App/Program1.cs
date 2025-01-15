using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

public class FuzzyNumber
{
	public double A { get; set; }
	public double B { get; set; }

	public FuzzyNumber(double a, double b)
	{
		A = a;
		B = b;
	}

	public double GetMembershipDegree(double x)
	{
		if (x >= B - A && x <= B + A)
			return 0.5 * (1 + Math.Cos(Math.PI * (x - B) / A));
		else
			return 0;
	}

	public int Defuzzify()
	{
		double numerator = 0;
		double denominator = 0;

		Console.WriteLine("\nПрименение метода центра тяжести для нечеткого числа ({0}, {1}):", A, B);
		Console.WriteLine("Операции при вычислении численного интеграла:");
		Console.WriteLine("Интервал интегрирования: [{0}, {1}]", B - A, B + A);

		for (double x = B - A; x <= B + A; x += 1)
		{
			double membershipDegree = GetMembershipDegree(x);
			numerator += x * membershipDegree;
			denominator += membershipDegree;

			Console.WriteLine("x = {0}, μ(x) = {1} (значение функции принадлежности для x), x * μ(x) = {2}", x, membershipDegree, x * membershipDegree);
		}

		if (denominator == 0)
			return 0;

		int defuzzifiedValue = (int)(numerator / denominator);
		Console.WriteLine("\nДефаззифицированное значение = {0} / {1} = {2}", numerator, denominator, defuzzifiedValue);

		return defuzzifiedValue;
	}
}

public class FuzzyBinaryTree
{
	public int Value { get; set; }
	public FuzzyBinaryTree Left { get; set; }
	public FuzzyBinaryTree Right { get; set; }
	public int Level { get; set; }

	public FuzzyBinaryTree(int value)
	{
		Value = value;
		Left = null;
		Right = null;
		Level = 0;
	}

	public void AddNode(FuzzyNumber fuzzyNumber)
	{
		int defuzzifiedValue = fuzzyNumber.Defuzzify();

		if (defuzzifiedValue < Value)
		{
			if (Left == null)
				Left = new FuzzyBinaryTree(defuzzifiedValue) { Level = this.Level + 1 };
			else
				Left.AddNode(fuzzyNumber);
		}
		else
		{
			if (Right == null)
				Right = new FuzzyBinaryTree(defuzzifiedValue) { Level = this.Level + 1 };
			else
				Right.AddNode(fuzzyNumber);
		}
	}

	public void PrintFuzzyBinaryTree()
	{
		int height = GetHeight(this);
		int col = GetCol(height);
		int[][] matrix = new int[height][];
		for (int i = 0; i < height; i++)
		{
			matrix[i] = new int[col];
			Array.Fill(matrix[i], 0);
		}
		PrintTree(matrix, this, col / 2, 0, height);

		for (int i = 0; i < matrix.Length; i++)
		{
			string row = "";
			for (int j = 0; j < matrix[i].Length; j++)
			{
				if (matrix[i][j] == 0)
				{
					row += " ";
				}
				else
				{
					row += matrix[i][j] + " ";
				}
			}
			Console.WriteLine(row);
		}
	}

	private void PrintTree(int[][] matrix, FuzzyBinaryTree root, int col, int row, int height)
	{
		if (root == null)
		{
			return;
		}
		matrix[row][col] = root.Value;
		PrintTree(matrix, root.Left, col - (int)Math.Pow(2, height - 2), row + 1, height - 1);
		PrintTree(matrix, root.Right, col + (int)Math.Pow(2, height - 2), row + 1, height - 1);
	}

	private int GetHeight(FuzzyBinaryTree root)
	{
		if (root == null)
		{
			return 0;
		}
		return Math.Max(GetHeight(root.Left), GetHeight(root.Right)) + 1;
	}

	private int GetCol(int height)
	{
		if (height == 1)
		{
			return 1;
		}
		return GetCol(height - 1) + GetCol(height - 1) + 1;
	}

	private void TraverseTree(FuzzyBinaryTree node, Dictionary<int, List<FuzzyBinaryTree>> levelNodes)
	{
		if (node == null)
			return;

		if (!levelNodes.ContainsKey(node.Level))
		{
			levelNodes[node.Level] = new List<FuzzyBinaryTree>();
		}

		levelNodes[node.Level].Add(node);

		TraverseTree(node.Left, levelNodes);
		TraverseTree(node.Right, levelNodes);
	}

	public override string ToString()
	{
		return Value.ToString();
	}
}

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Создание нечеткого бинарного дерева...");
		FuzzyBinaryTree tree = new FuzzyBinaryTree(GetFuzzyNumberFromFile().Defuzzify());

		Console.WriteLine("Добавление узлов в дерево...");
		List<FuzzyNumber> fuzzyNumbers = GetFuzzyNumbersFromFile();
		if (fuzzyNumbers.Count < 7)
		{
			Console.WriteLine("Количество элементов в двоичном дереве должно быть не менее 7. Завершение программы.");
			return;
		}

		for (int i = 0; i < 6; i++)
		{
			tree.AddNode(fuzzyNumbers[i]);
		}

		Console.WriteLine("Дерево до добавления пользовательского узла:");
		tree.PrintFuzzyBinaryTree();

		Console.WriteLine("Введите параметры a и b для нового нечеткого числа:");
		FuzzyNumber userFuzzyNumber = GetFuzzyNumberFromUser();

		Console.WriteLine("Добавление пользовательского узла...");
		tree.AddNode(userFuzzyNumber);

		Console.WriteLine("Дерево после добавления пользовательского узла:");
		tree.PrintFuzzyBinaryTree();
	}

	static FuzzyNumber GetFuzzyNumberFromUser()
	{
		double a, b;

		while (true)
		{
			Console.Write("Введите параметр a: ");
			if (!double.TryParse(Console.ReadLine(), out a))
			{
				Console.WriteLine("Неверный формат ввода. Пожалуйста, введите число.");
				continue;
			}

			Console.Write("Введите параметр b: ");
			if (!double.TryParse(Console.ReadLine(), out b))
			{
				Console.WriteLine("Неверный формат ввода. Пожалуйста, введите число.");
				continue;
			}

			if (a <= 0 || b <= 0)
			{
				Console.WriteLine("Параметры a и b должны быть положительными числами.");
				continue;
			}

			return new FuzzyNumber(a, b);
		}
	}

	static FuzzyNumber GetFuzzyNumberFromFile()
	{
		string filePath = "D:\\Downloads\\Telegram\\fuzzy_numbers.txt";
		if (!File.Exists(filePath))
		{
			Console.WriteLine("Файл {0} не существует. Завершение программы.", filePath);
			return null;
		}

		string[] lines = File.ReadAllLines(filePath);
		if (lines.Length == 0)
		{
			Console.WriteLine("Файл {0} пустой. Завершение программы.", filePath);
			return null;
		}

		string[] values = lines[0].Split(',');
		if (values.Length != 2)
		{
			Console.WriteLine("Некорректный формат данных в файле {0}. Завершение программы.", filePath);
			return null;
		}

		double a, b;
		if (!double.TryParse(values[0], NumberStyles.Any,
		  CultureInfo.InvariantCulture, out a) || !double.TryParse(values[1], NumberStyles.Any,
		  CultureInfo.InvariantCulture, out b))
		{
			Console.WriteLine("Некорректный формат данных в файле {0}. Завершение программы.", filePath);
			return null;
		}

		if (a <= 0 || b <= 0)
		{
			Console.WriteLine("Параметры a и b должны быть положительными числами.");
			return null;
		}

		return new FuzzyNumber(a, b);
	}

	static List<FuzzyNumber> GetFuzzyNumbersFromFile()
	{
		string filePath = "D:\\Downloads\\Telegram\\fuzzy_numbers.txt";
		if (!File.Exists(filePath))
		{
			Console.WriteLine("Файл {0} не существует. Завершение программы.", filePath);
			return null;
		}

		List<FuzzyNumber> fuzzyNumbers = new List<FuzzyNumber>();
		string[] lines = File.ReadAllLines(filePath);
		if (lines.Length == 0)
		{
			Console.WriteLine("Файл {0} пустой. Завершение программы.", filePath);
			return null;
		}

		foreach (string line in lines)
		{
			string[] values = line.Split(',');
			if (values.Length != 2)
			{
				Console.WriteLine("Некорректный формат данных в файле {0}. Завершение программы.", filePath);
				return null;
			}

			double a, b;
			if (!double.TryParse(values[0], NumberStyles.Any,
		  CultureInfo.InvariantCulture, out a) || !double.TryParse(values[1], NumberStyles.Any,
		  CultureInfo.InvariantCulture, out b))
			{
				Console.WriteLine("Некорректный формат данных в файле {0}. Завершение программы.", filePath);
				return null;
			}

			if (a <= 0 || b <= 0)
			{
				Console.WriteLine("Параметры a и b должны быть положительными числами.");
				return null;
			}

			fuzzyNumbers.Add(new FuzzyNumber(a, b));
		}

		return fuzzyNumbers;
	}
}