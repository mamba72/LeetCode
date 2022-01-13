using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
	internal class FirstMissingPositiveProblem
	{
		//solving this problem: https://leetcode.com/problems/first-missing-positive/

		public static int FirstMissingPositive(int[] nums)
		{
			Array.Sort(nums);

			//int curVal = int.MinValue;

			if(nums[nums.Length - 1] < 0)
				return 1;


			if (nums[0] > 1)
				return 1;

			for(int i = 0; i < nums.Length - 1; i++)
			{
				if (nums[i] < 0)
					continue;
				if(nums[i + 1] - nums[i] > 1)
					return nums[i] + 1;
			}

			//if we get here, then we have iterated through the whole array and didnt find a gap.
			//so just return the last number + 1

			
			return nums[nums.Length - 1] + 1;
		}

		public static int FirstMissingPositive_WithCounter(int[] nums)
		{
			//HashSet<int> numSet = new HashSet<int>(nums);
			//nums = numSet.ToArray();
			Array.Sort(nums);

			//int curVal = int.MinValue;

			//if (nums[nums.Length - 1] < 0)
			//	return 1;


			//if (nums[0] > 1)
			//	return 1;

			//for (int i = 0; i < nums.Length - 1; i++)
			//{
			//	if (nums[i] < 0)
			//		continue;
			//	if (nums[i + 1] - nums[i] > 1)
			//		return nums[i] + 1;
			//}


			int counter = 2;
			int oneStartIndex = Array.IndexOf(nums, 1);

			if (oneStartIndex == -1)
				return 1;

			for(int i = oneStartIndex + 1; i < nums.Length; i++)
			{
				if (nums[i] != counter)
					return counter;

				if(i != 0 && nums[i - 1] != nums[i])
					counter++;

			}


			//if we get here, then we have iterated through the whole array and didnt find a gap.
			//so just return the last number + 1


			return nums[nums.Length - 1] + 1;
		}
	}
}
