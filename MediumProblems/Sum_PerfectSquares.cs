using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	class Sum_PerfectSquares
	{
		public static void PerfectSquare_Tester()
		{
			int input = 12;
			int output = PerfectSquares(input);
			Console.WriteLine("Perfect Squares Output: " + output);
		}

		//Given an integer n, return the least number of perfect square numbers that sum to n.
		public static int PerfectSquares(int n)
		{
			bool found = false;
			LinkedList<int> bestList;
			bestList = new LinkedList<int>();

			int counter = 2;
			while(found == false)
			{

				int sum = 0;
				int square;
				square = (int)Math.Pow((double)counter,(double)2);

				bestList = new LinkedList<int>();

				while (sum < n)
				{
					bestList.AddFirst(square);

					sum = bestList.Sum();
				}
				
				if(sum == n)
				{
					found = true;
					continue;
				}
				//increment counter
				++counter;
				
			}

			return bestList.Count;
		}

		//get the largest perfect square (not necessarily a factor) in a given number and return that square
		public static int LargestPerfectSquare(double n)
		{
			double sqrt;

			bool foundSqrt = false;

			while(foundSqrt == false)
			{
				sqrt = Math.Sqrt(n);
				//if it has some decimal values, then its not a perfect square
				if((int)sqrt == sqrt)
				{
					//check if square root of n
					if (sqrt * sqrt == n)
					{
						foundSqrt = true;
						continue;
					}
				}

				
				
			}

			return -1;
		}
	}
}
