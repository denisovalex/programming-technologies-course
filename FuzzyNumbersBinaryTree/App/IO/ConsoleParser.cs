using App.FuzzyNumbers;
using System.Globalization;

namespace App.IO
{
	public static class ConsoleParser
	{
		public static HarmonicFuzzyNumber? Parse(string? input)
		{
			var values = input.Split(',');
			if (values.Length < 2)
			{
				Console.WriteLine("Wrong data format: two fuzzy numbers parameters must be separated by \",\".");
				return null;
			}

			double a, b;
			if (!double.TryParse(values[0], NumberStyles.Any, CultureInfo.InvariantCulture, out a) ||
				!double.TryParse(values[1], NumberStyles.Any, CultureInfo.InvariantCulture, out b))
			{
				Console.WriteLine("Wrong data format: two fuzzy numbers parameters must be float numbers.");
				return null;
			}

			if (a <= 0 || b <= 0)
			{
				Console.WriteLine("Wrong data format: two fuzzy numbers parameters must be positive.");
				return null;
			}

			return new HarmonicFuzzyNumber(a, b);
		}
	}
}
