using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class SearchInRotatedSortedArrayProblem
	{
		//solving this problem: https://leetcode.com/problems/search-in-rotated-sorted-array-ii/

		private bool Search(int[] nums, int target)
		{
			//bool looking = true;
			int startingIndex = nums.Length / 2;

			int curIndex = startingIndex;

			while(true)
			{
				if(curIndex < 0)
					curIndex = nums.Length - 1;
				else if(curIndex == nums.Length)
					curIndex = 0;
				
				int num = nums[curIndex];

				if (num == target)
					return true;
				else if(nums[curIndex] > target && (nums[curIndex + 1] < target || nums[curIndex - 1] < target))
				{
					return false;
				}
				else if(num < target)
				{
					curIndex++;
				}
				else
				{
					curIndex--;
				}

				if (curIndex == startingIndex)
					return false;
			}

			return false;
		}

		//kinda cheating
		private bool Search_SortingArrayFirst(int[] nums, int target)
		{
			Array.Sort(nums);

			int startingIndex = nums.Length / 2;

			int curIndex = startingIndex;

			bool greaterThan = true;
			if(nums[curIndex] < target)
				greaterThan = false;

			while (true)
			{
				if (curIndex < 0 || curIndex == nums.Length)
					return false;

				int num = nums[curIndex];

				if (num == target)
					return true;
				else
				{
					if (greaterThan)
						curIndex--;
					else
						curIndex++;
				}
			}

			return false;
		}
	}
}
