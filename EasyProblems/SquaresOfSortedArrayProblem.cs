using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class SquaresOfSortedArrayProblem
	{
		//solving this problem: https://leetcode.com/problems/squares-of-a-sorted-array/
		
		public static int[] SortedSquares(int[] nums)
		{
			if (nums.Length == 0)
				return nums;

			SortedDictionary<int, int> sortedSquares = new SortedDictionary<int, int>();

			int square;
			foreach (int i in nums)
			{
				square = i*i;
				if (sortedSquares.ContainsKey(square))
					sortedSquares[square]++;
				else
					sortedSquares.Add(square, 1);
			}

			int[] result = new int[nums.Length];
			int counter = 0;
			foreach(int key in sortedSquares.Keys)
			{
				for(int i = 0; i < sortedSquares[key]; i++)
				{
					result[counter++] = key;
				}
			}

			return result;
		}

		public static int[] SortedSquares_MuchSimpler(int[] nums)
		{
			if(nums.Length > 0)
			{
				for (int i = 0; i < nums.Length; i++)
				{
					nums[i] = nums[i] * nums[i];
				}

				Array.Sort(nums);
			}
			

			return nums;
		}

	}
}
