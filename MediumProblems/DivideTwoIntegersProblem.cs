using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class DivideTwoIntegersProblem
	{
		//solving this problem: https://leetcode.com/problems/divide-two-integers/
		public static void Tester()
		{
			int dividend = int.MinValue;
			int divisor = -1;

			Console.WriteLine(Divide(dividend,divisor));
		}

		public static int Divide(int dividend, int divisor)
		{
			if (divisor == 1)
				return dividend;

			int quotient = 0;
			bool isNegative = dividend < 0 ^ divisor < 0;

			long newDividend = (long)dividend;


			newDividend = Math.Abs(newDividend);
			divisor = Math.Abs(divisor);

			try
			{
				while (newDividend >= divisor)
				{
					newDividend -= divisor;
					quotient = checked(quotient + 1);
				}
			}catch (OverflowException)
			{
				if (isNegative)
					return int.MinValue;
				else
					return int.MaxValue;
			}
			


			if (isNegative)
				return -1 * quotient;

			return quotient;
		}
	}
}
