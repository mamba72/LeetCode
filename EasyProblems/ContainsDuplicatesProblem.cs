using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class ContainsDuplicatesProblem
	{
		//solving this problem: https://leetcode.com/problems/contains-duplicate/
		public static void Tester()
		{
			int[] nums = { 1, 2, 3, 1, 2, 3 };
			int k = 2;
			ContainsNearbyDuplicate(nums, k);

			nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			k = 3;

			ContainsNearbyDuplicate(nums, k);
		}

		private static bool ContainsDuplicate(int[] nums)
		{
			if (nums.Length == 1)
				return false;

			SortedSet<int> prevNums = new SortedSet<int>();

			foreach(int num in nums)
			{
				if (prevNums.Contains(num))
				{
					return true;
				}
				else
					prevNums.Add(num);
			}
			return false;
		}

		//solving this problem: https://leetcode.com/problems/contains-duplicate-ii/

		private static bool ContainsNearbyDuplicate(int[] nums, int k)
		{

			if(k >= nums.Length)
				return ContainsDuplicate(nums);

			if (k == 0)
				return false;

			SortedSet<int> curWindow = new SortedSet<int>();

			int rightIndex;
			for ( rightIndex = 0; rightIndex < k; rightIndex++)
			{
				if (curWindow.Contains(nums[rightIndex]))
				{
					return true;
				}
				else
					curWindow.Add(nums[rightIndex]);
			}

			//int rightIndex = k;
			int leftIndex = 0;
			while(rightIndex < nums.Length)
			{
				curWindow.Remove(nums[leftIndex]);

				if (curWindow.Contains(nums[rightIndex]))
				{
					return true;
				}
				else
					curWindow.Add(nums[rightIndex]);

				leftIndex++;
				rightIndex++;
			}

			return false;
		}
	}
}
