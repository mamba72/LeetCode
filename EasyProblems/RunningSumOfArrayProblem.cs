using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class RunningSumOfArrayProblem
	{
		//solving this problem: https://leetcode.com/problems/running-sum-of-1d-array/
		public static int[] RunningSum(int[] nums)
		{
			int prevSum = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				nums[i] += prevSum;
				prevSum = nums[i];
			}

			return nums;
		}
	}
}
