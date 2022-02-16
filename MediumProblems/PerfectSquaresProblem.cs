using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class PerfectSquaresProblem
	{
		//solving this problem: https://leetcode.com/problems/perfect-squares/
		public static void Tester()
		{
			int num = 12;
			numSquares(num);

		}

		private static int numSquares(int n)
		{
			if (n == 1)
				return 1;

			if (IsPerfectSquare(n))
				return 1;

			int counter = 0;

			int curNum;

			while(n > 0)
			{
				curNum = (int)Math.Sqrt(n);
				n -= (int)Math.Pow(curNum, 2);
				counter++;
			}
			return counter;
		}

		private static bool IsPerfectSquare(int n)
		{
			return Math.Sqrt(n) == (int)Math.Sqrt(n);
		}
	}
}
