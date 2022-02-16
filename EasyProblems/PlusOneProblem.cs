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
			int[] digits = { 8,9,9,9 };
			PlusOne(digits);

			digits = new int[] { 9,9,9,9 };
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
					--curIndex;
				}
				else if(carry == 1)
				{
					digits[curIndex] += 1;
					carry = 0;
				}

				
			}while(carry != 0 && curIndex >= 0);

			if(digits[0] == 0)
			{
				//handle overflow

				int[] bigNums = new int[digits.Length + 1];

				bigNums[0] = 1;
				digits = bigNums;
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
