using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class LongestConsecutiveSequenceProblem
	{
		//solving this problem: https://leetcode.com/problems/longest-consecutive-sequence/
		public static void Tester()
		{
			int[] nums = { 100, 4, 200, 1, 3, 2 };
			nums = new int[] { 0, 0 };
			nums = new int[] { 1, 2, 0, 1 };
			LongestConsecutive(nums);
		}
		private static int LongestConsecutive(int[] nums)
		{
			if (nums.Length == 0)
				return 0;
			else if (nums.Length == 1)
				return 1;

			Array.Sort(nums);

			int max = 1;
			int counter = 1;
			int prevNum = nums[0];
			foreach(int num in nums)
			{
				if (num == prevNum)
					continue;

				if(num == prevNum + 1)
				{
					counter++;
				}
				else
				{
					if(counter != 1 && counter > max)
						max = counter;
					counter = 1;
				}

				prevNum = num;
			}

			if(counter > max)
				max = counter;
			return max;
		}
	}
}
