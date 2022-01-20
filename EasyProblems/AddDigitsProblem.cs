using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class AddDigitsProblem
	{
		//solving this problem: https://leetcode.com/problems/add-digits/

		public static int AddDigits(int num)
		{
			if(num <= 9)
				return num;

			int[] digits = GetDigits(num);
			
			while(digits.Length > 1)
			{
				num = digits.Sum();
				digits = GetDigits(num);
			}
			return digits[0];
		}

		public static int[] GetDigits(int num)
		{
			if(num <= 9)
				return new int[] { num };

			LinkedList<int> digits = new LinkedList<int>();

			while (num > 0)
			{
				digits.AddFirst(num % 10);
				num /= 10;
			}

			return digits.ToArray();
		}
	}
}
