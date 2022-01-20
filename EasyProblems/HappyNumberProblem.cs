using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class HappyNumberProblem
	{
		//solving this problem: https://leetcode.com/problems/happy-number/

		public static bool IsHappy(int n)
		{
			HashSet<int> prevSeen = new HashSet<int>();

			prevSeen.Add(n);

			while(n != 1)
			{
				int[] digits = GetDigits(n);
				n = GetSquaredSums(digits);

				if (prevSeen.Contains(n))
					return false;
				else
					prevSeen.Add(n);
			}

			return true;
		}

		public static int GetSquaredSums(int[] num)
		{
			int sum = 0;

			for(int i = 0; i < num.Length; i++)
			{
				sum += num[i] * num[i];
			}

			return sum;
		}

		public static int[] GetDigits(int num)
		{
			LinkedList<int> digits = new LinkedList<int>();

			while(num > 0)
			{
				digits.AddFirst(num % 10);
				num /= 10;
			}

			return digits.ToArray();
		}
	}
}
