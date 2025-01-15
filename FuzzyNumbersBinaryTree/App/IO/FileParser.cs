using System.Globalization;
using App.FuzzyNumbers;

namespace App.IO
{
	public static class FileParser
	{
		public static List<HarmonicFuzzyNumber>? Parse(string path)
		{
			string[] lines;
			try
			{
				lines = File.ReadAllLines(path);
			}
			catch (Exception)
			{
				Console.WriteLine("Error while reading file. Please, check file path and it's security settings.");
				return null;
			}

			if (lines.Length < 7)
			{
				Console.WriteLine("Wrong file data format: file must contain at least 7 fuzzy numbers.");
				return null;
			}

			var numbers = new List<HarmonicFuzzyNumber>();
			foreach (string line in lines)
			{
				var values = line.Split(',');
				if (values.Length < 2)
				{
					Console.WriteLine("Wrong file data format: two fuzzy numbers parameters must be separated by \",\".");
					return null;
				}

				double a, b;
				if (!double.TryParse(values[0], NumberStyles.Any, CultureInfo.InvariantCulture, out a) ||
					!double.TryParse(values[1], NumberStyles.Any, CultureInfo.InvariantCulture, out b))
				{
					Console.WriteLine("Wrong file data format: two fuzzy numbers parameters must be float numbers.");
					return null;
				}

				if (a <= 0 || b <= 0)
				{
					Console.WriteLine("Wrong file data format: two fuzzy numbers parameters must be positive.");
					return null;
				}

				numbers.Add(new HarmonicFuzzyNumber(a, b));
			}

			return numbers;
		}
	}
}
