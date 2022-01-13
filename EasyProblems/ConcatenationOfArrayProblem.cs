using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class ConcatenationOfArrayProblem
	{
		//solving this problem: https://leetcode.com/problems/concatenation-of-array/

		public static int[] GetConcatenation(int[] nums)
		{
			int[] ans = new int[nums.Length * 2];

			if (nums.Length <= 200)
			{
				for (int i = 0; i < nums.Length; ++i)
				{
					ans[i] = nums[i];
					ans[i + nums.Length] = nums[i];
				}
			}
			else
			{
				Parallel.For(0, nums.Length, i =>
				{
					ans[i] = nums[i];
					ans[i + nums.Length] = nums[i];
				});
			}
			
			

			return ans;
		}
	}
}
