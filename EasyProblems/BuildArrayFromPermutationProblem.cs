using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class BuildArrayFromPermutationProblem
	{
		//solving this problem: https://leetcode.com/problems/build-array-from-permutation/

		public int[] BuildArray(int[] nums)
		{
			int [] result = new int[nums.Length];

			for (int i = 0; i < nums.Length; i++)
			{
				result[i] = nums[nums[i]];
			}

			return result;
		}
	}
}
