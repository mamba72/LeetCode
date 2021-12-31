using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Threading;

namespace MediumProblems
{
	internal class SmallestIntDivisibleByKProblem
	{
		//solving this problem: https://leetcode.com/problems/smallest-integer-divisible-by-k/
		public static void SmallestIntTester()
		{
			int input = 49993;
			Console.WriteLine("Input: " + input + ", Output: " + SmallestRepunitDivByK_BigInt(input));


			MediumMain.StartStopWatch();
			for (int i = 1; i <= 1000; i++)
			{
				//Console.WriteLine("Input: " + i + ", Output: " + SmallestRepunitDivByK(i));
				SmallestRepunitDivByK_BigInt(i);

				if (i % 1000 == 0)
				{
					Console.WriteLine(((double)i / 100000d) + "% done");
				}
			}
			string regularTime = MediumMain.StopStopWatch();
			Console.WriteLine(regularTime);


			//ThreadPool.QueueUserWorkItem(new WaitCallback(Test), (new int[] { 1, 499999, 1 }));
			//ThreadPool.QueueUserWorkItem(new WaitCallback(Test), (new int[] { 500000, 100000, 2 }));

			//Console.Read();
		}

		public static int RealSolution(int k)
		{
			if(k % 2 == 0 || k % 5 == 0)
			{
				return -1;
			}

			for( int r = 0, n = 1; n <= k; n++)
			{
				r = (10 * r + 1) % k;
				if (r == 0)
					return n;
			}

			return -1;
		}



		public static int SmallestRepunitDivByK(int k)
		{
			
			//double bigK = new double(k);
			double bigK = (double)k;
			int remainderCounter = 0;
			HashSet<double> prevRemainders = new HashSet<double>();
			double curInt = 0;

			if ((k + "").Length > 1)
			{
				for (int i = 0; i < (k + "").Length - 1; i++)
				{
					curInt = curInt * 10 + 1;
				}
			}


			double remainder = 0;
			//just keep going until exception
			do
			{
				curInt = curInt * 10 + 1;
				prevRemainders.Add(remainder);

				remainder = curInt % bigK;
				//remainder = BigInteger.Remainder(curInt, bigK);

				if (prevRemainders.Contains(remainder))
				{
					remainderCounter++;
				}
				else
				{
					remainderCounter = 0;
				}

				if (remainderCounter >= 5)
				{
					return -1;
				}

			} while (remainder != 0);


			return (curInt + "").Length;
		}

		public static int SmallestRepunitDivByK_BigInt(int k)
		{

			//double bigK = new double(k);
			BigInteger bigK = k;
			int remainderCounter = 0;
			HashSet<ulong> prevRemainders = new HashSet<ulong>();
			BigInteger[] curInts = new BigInteger[2];

			//if ((k + "").Length > 1)
			//{
				for (int i = 0; i < (k + "").Length - 1; i++)
				{
					curInts[0] = curInts[0] * 10 + 1;
				}
				//make the next one, just 1 power larger
				curInts[1] = curInts[0] * 10 + 1;
			//}


			ulong[] remainders = new ulong[2];
			//just keep going until exception
			do
			{
				curInts[0] = curInts[1];
				curInts[1] = curInts[1] * 10 + 1;
				prevRemainders.Add(remainders[0]);
				prevRemainders.Add(remainders[1]);


				remainders[0] = (ulong)(curInts[0] % bigK);
				remainders[1] = (ulong)(curInts[1] % bigK);

				//remainder = BigInteger.Remainder(curInt, bigK);

				if (prevRemainders.Contains(remainders[1])) //(prevRemainders.Contains(remainders[0]) || prevRemainders.Contains(remainders[1]))
				{
					remainderCounter++;
				}
				else
				{
					remainderCounter = 0;
				}

				if (remainderCounter >= 5)
				{
					return -1;
				}

				if(remainders[0] == 0)
					return (curInts[0] + "").Length;
				else if (remainders[1] == 0)
					return (curInts[1] + "").Length;

			} while (true);


			//return (curInt + "").Length;
		}


	}
}
