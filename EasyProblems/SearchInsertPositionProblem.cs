using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class SearchInsertPositionProblem
	{
		//solving this problem: https://leetcode.com/problems/search-insert-position/
		public static void SearchInsertTester()
		{

		}

		public static int SearchInsert(int[] nums, int target)
		{
			for(int i = 0; i < nums.Length; i++)
			{
				if(nums[i] >= target)
					return i;
			}

			return nums.Length;
		}
	}
}
