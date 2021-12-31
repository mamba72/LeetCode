using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class RemoveDuplicatesFromSortedArrayProblem
	{
		//solving this problem: https://leetcode.com/problems/remove-duplicates-from-sorted-array/
		public static void RemoveTester()
		{
			int[] input = { 1, 1, 2 };
			Console.WriteLine(RemoveDuplicates(input));
		}

		public static int RemoveDuplicates(int[] nums)
		{
			if (nums.Length == 0)
				return 0;
			else if (nums.Length == 1)
				return 1;
			SortedSet<int> numbers = new SortedSet<int>(nums);

			int index = 0;
			foreach(int num in numbers)
			{
				nums[index++] = num;
			}


			return numbers.Count;
		}
	}
}
