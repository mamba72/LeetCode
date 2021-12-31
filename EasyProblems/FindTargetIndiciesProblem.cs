using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class FindTargetIndiciesProblem
	{
		//solving this problem: https://leetcode.com/problems/find-target-indices-after-sorting-array/
		public static void TargetIndiciesTester()
		{
			int[] inputArray = { 38, 89, 7, 100, 19, 23, 17, 29, 67, 76, 69, 21, 29, 31, 71, 22, 36, 41, 23, 96, 61, 100, 52, 60, 53, 62, 66, 67, 13 };
			int target = 61;

			Console.WriteLine(TargetIndicies(inputArray, target));
		}
		public static IList<int> TargetIndicies(int[] nums, int target)
		{
			Array.Sort(nums);
			List<int> result = new List<int>();

			int start = 0;

			if (nums[nums.Length / 2] < target)
				start = nums.Length / 2;

			for (start = start; start < nums.Length; start++)
			{
				if (nums[start] > target)
					break;
				if (nums[start] == target)
					result.Add(start);
			}
			return result;
		}
	}
}
