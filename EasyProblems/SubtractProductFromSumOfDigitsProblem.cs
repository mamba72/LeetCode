using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeHelperFunctions;

namespace EasyProblems
{
	internal class SubtractProductFromSumOfDigitsProblem
	{
		//solving this problem: https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
		public static void Tester()
		{
			int n = 754203276;

			TimingFuncts.StartStopWatch();
			for (int i = 0; i < 100; ++i)
				SubtractProductAndSum(n);
			Console.WriteLine("String Based:\t" + TimingFuncts.StopStopWatchElapsedTime());

			TimingFuncts.StartStopWatch();
			for (int i = 0; i < 100; ++i)
				SubtractProductAndSum_Mod(n);
			Console.WriteLine("Mod Based:\t" + TimingFuncts.StopStopWatchElapsedTime());
		}


		private static int SubtractProductAndSum(int n)
		{
			string nStr = n.ToString();

			int sum = 0;
			int product = 1;

			foreach(char c in nStr)
			{
				int num = int.Parse(c.ToString());

				sum += num;
				product *= num;
			}

			return product - sum;
		}

		private static int SubtractProductAndSum_Mod(int n)
		{
			int sum = 0;
			int product = 1;

			int nextDigit;
			//int nextDigit = n;
			while (n > 0)
			{
				nextDigit = n % 10;
				n = (n - nextDigit) / 10;

				sum += nextDigit;
				product *= nextDigit;
			}

			return product - sum;
		}
	}
}
