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


		//private static int SearchInsert_Attempt2(int[] nums, int target)
		//{

		//	if(target < nums[nums.Length / 2])
		//	{
		//		//in first half
		//		int[] firstHalf = new int[nums.Length / 2];
		//		Array.Copy(nums, firstHalf, nums.Length / 2);
		//		return SearchInsert_Attempt2(firstHalf, target);
		//	}else if(target > nums[nums.Length / 2])
		//	{
		//		//in second half
		//		int[] secondHalf = new int[nums.Length / 2];
		//		Array.Copy(nums, nums.Length / 2, secondHalf,0, nums.Length / 2);
		//		return SearchInsert_Attempt2(secondHalf, target);
		//	}
		//	else
		//	{
		//		//is middle
		//		return (nums.Length / 2) + 1;
		//	}

			

		//}



		
	}
}
