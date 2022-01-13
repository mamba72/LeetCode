using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class TwoSumEqualTargetProblem
	{
		//solving this problem: https://leetcode.com/problems/two-sum/
		public static int[] TwoSum(int[] nums, int target)
		{
			int[] pair = new int[2];

			for (int i = 0; i < nums.Length; i++)
			{
				var selectedNums = nums.Select(x => x).Where(num => num + nums[i] == target);

				if(selectedNums.Count() > 0)
				{
					pair[0] = i;
					pair[1] = Array.IndexOf(nums,selectedNums.First());
					if (pair[0] == pair[1])
						continue;

					//return pair;
					break;
				}
			}

			

			return pair;
		}


		public static int[] TwoSum_SuperFastAnswer(int[] nums, int target)
		{
			Dictionary<int, int> map = new Dictionary<int, int>();

			for (int i = 0; i < nums.Length; i++)
			{
				var current = nums[i];
				var x = target - current;
				if (map.ContainsKey(x))
					return new int[] { i, map.GetValueOrDefault(x) };
				if (!map.ContainsKey(current))
					map.Add(current, i);
			}

			return new int[] { 0, 0 };
		}
	}
}
