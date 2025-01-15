﻿using System.Diagnostics;

namespace AlgorithmsLib
{
	public class Primitivisation: IAlgorithm
	{
		public long CalculateTime(int n)
		{
			var arr = CreateRandomArray(n);  // создание массива для алгоритма не учитывается в замере времени
			var time = RunAlgorithm(arr);

			return time;
		}

		private int[] CreateRandomArray(int n)
		{
			int[] arr = new int[n];
			Random random = new Random();

			for (int i = 0; i < n; i++)
			{
				arr[i] = random.Next(1000, 5001);
			}

			return arr;
		}

		private long RunAlgorithm(int[] arr)
		{
			Stopwatch stopWatch = new Stopwatch();

			stopWatch.Restart();

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < 2)
					continue;

				arr[i] = GetClosestPrime(arr[i]);
			}

			stopWatch.Stop();

			long time = stopWatch.ElapsedMilliseconds;
			return time;
		}

		private int GetClosestPrime(int number) // наивная реализация нахождения ближайшего простого числа
		{
			int smallerPrime = number - 1;
			while (!IsPrime(smallerPrime))
			{
				smallerPrime--;
			}
			return smallerPrime;
		}

		private bool IsPrime(int number)
		{
			if (number < 2)
				return false;

			for (int i = 2; i <= Math.Sqrt(number); i++)
			{
				if (number % i == 0)
					return false;
			}

			return true;
		}
	}
}