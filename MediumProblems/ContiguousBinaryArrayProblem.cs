using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class ContiguousBinaryArrayProblem
	{
		//solving this problem: https://leetcode.com/problems/contiguous-array/

		public static void Tester()
		{
			int[] nums = { };

			FindMaxLength(nums);
		}

		private static int FindMaxLength(int[] nums)
		{
			int maxLength = -1;
			int count = 0;
			Dictionary<int, int> table = new Dictionary<int, int>();
			table.Add(0, -1);

			int num;
			for (int i = 0; i < nums.Length; i++)
			{
				num = nums[i];

				if (num == 0)
					--count;
				else
					++count;

				if (table.ContainsKey(count))
					maxLength = Math.Max(maxLength, i - table[count]);
				else
					table.Add(count, i);
			}

			return maxLength;
		}
	}
}
