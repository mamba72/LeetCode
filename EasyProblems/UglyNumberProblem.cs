using LeetCodeHelperFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class UglyNumberProblem
	{
		//solving this problem: https://leetcode.com/problems/ugly-number/
		public static void Tester()
		{
			TimingFuncts.StartStopWatch();

			int input = 14;
			IsUgly(input);

			input = 6;
			IsUgly(input);
			input = 57;
			IsUgly(input);
			input = 135421;
			IsUgly(input);
			input = 15613;
			IsUgly(input);
			input = 1684867443;
			IsUgly(input);
			input = 8;
			IsUgly(input);

			input = int.MaxValue;
			IsUgly(input);


			input = 1332185066;
			
			IsUgly(input);

			input = 1305744254;
			IsUgly(input);

			Console.WriteLine(TimingFuncts.StopStopWatch());
		}

		private static HashSet<int> prevPrimes = new HashSet<int>();

		public static bool IsUgly(int n)
		{
			if (n == 1)
				return true;

			if(n == 0)
				return false;

			if(n < 0)
				return false;

			if(n == 2 || n == 3 || n == 5)
				return true;

			

			Console.WriteLine("\nPrime factor of {0}: ", n);

			bool foundPrimeFactor = false;

			//bool returnFalse = false;



			//Parallel.For(2, n, i =>
			//{
			//	{

			//		// check for divisibility
			//		if (n % i == 0)
			//		{
			//			if (prevPrimes.Contains(i) || IsPrime(i))
			//			{
			//				//flag = 1;
			//				Console.Write(i + " ");
			//				foundPrimeFactor = true;

			//				prevPrimes.Add(i);

			//				if (!(i == 2 || i == 3 || i == 5))
			//					//return false;
			//					returnFalse = true;
			//			}
			//		}
			//	}
			//});

			//if (returnFalse)
			//	return false;

			if (IsPrime(n))
				return false;


			for (int i = 2; i < n; ++i)
			{

				// check for divisibility
				if (n % i == 0)
				{
					if (prevPrimes.Contains(i) || IsPrime(i))
					{
						//flag = 1;
						Console.Write(i + " ");
						foundPrimeFactor = true;

						prevPrimes.Add(i);

						if (!(i == 2 || i == 3 || i == 5))
							return false;
					}
				}
			}

			if (!foundPrimeFactor)
				return false;

			return true;
		}

		public static bool IsPrime(int number)
		{
			//if (number < 2) return false;
			if (number % 2 == 0) return (number == 2);
			int root = (int)Math.Sqrt((double)number);
			for (int i = 3; i <= root; i += 2)
			{
				if (number % i == 0) return false;
			}
			return true;
		}
	}
}
