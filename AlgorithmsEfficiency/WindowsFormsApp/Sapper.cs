using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
	public class Sapper
	{
		public long CalculateTime(int n)
		{
			var field = CreateRandomField(n); // создание поля для алгоритма не учитывается в замере времени
			var time = RunAlgorithm(field, n);

			return time;
		}
		private int[,] CreateRandomField(int n)
		{
			int[,] field = new int[n, n];
			Random random = new Random();

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					field[i, j] = random.Next(2);
				}
			}

			return field;
		}

		private long RunAlgorithm(int[,] field, int n)
		{
			Stopwatch stopWatch = new Stopwatch();

			stopWatch.Restart(); // начало замера времени

			FindLargestSafeZone(field, n);

			stopWatch.Stop(); // окончание замера времени

			long time = stopWatch.ElapsedMilliseconds;
			return time;
		}

		private static void FindLargestSafeZone(int[,] field, int n) // наивная реализация нахождения нибольшей безопасной зоны
		{
			int[,] dp = new int[n, n];
			int maxSize = 0;

			// Заполняем первую строку и первый столбец динамического массива dp
			for (int i = 0; i < n; i++)
			{
				dp[i, 0] = 1;
				dp[0, i] = 1;
			}

			// Находим размер самой большой безопасной зоны
			for (int i = 1; i < n; i++)
			{
				for (int j = 1; j < n; j++)
				{
					if (field[i, j] == 0)
					{
						// Если текущая ячейка свободна от мин, то находим минимальный размер среди текущего, предыдущего ряда и предыдущего столбца
						int minSize = Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1]));
						dp[i, j] = minSize + 1;
						maxSize = Math.Max(maxSize, dp[i, j]);
					}
				}
			}
		}
	}
}
