using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class PlusOneProblem
	{
		//solving this problem: https://leetcode.com/problems/plus-one/
		public static void Tester()
		{
			int[] digits = { };
			PlusOne(digits);
		}

		private static int[] PlusOne(int[] digits)
		{
			
			short carry = 0;
			
			int curIndex = digits.Length - 1;

			digits[curIndex] += 1;

			do
			{
				if(digits[curIndex] + carry == 10)
				{
					carry = 1;
					digits[curIndex] = 0;
					curIndex++;
				}
				else if(carry == 1)
				{
					digits[curIndex] += 1;
				}

				
			}while(carry != 0);

			if(digits[0] == 10)
			{
				//handle overflow
			}

			return digits;
		}

		//public static int[] PlusOne_BigInt(int[] digits)
		//{
		//	BigInteger big = new BigInteger(1);

		//	for(int i = digits.Length - 1; i >= 0; i--)
		//	{
		//		big += digits[i] * Math.Pow(10, );
		//	}
		//}
	}
}
