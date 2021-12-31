using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class RemoveDuplicatesFromSortedArrayProblem
	{
		//solving this problem: https://leetcode.com/problems/remove-duplicates-from-sorted-array/
		public static void RemoveTester()
		{
			int[] input = { 1, 1, 1, 2, 2, 3 };
			Console.WriteLine(RemoveDuplicates(input));
		}

		public static int RemoveDuplicates(int[] nums)
		{
			if (nums.Length == 0)
				return 0;
			else if (nums.Length == 1)
				return 1;

			SortedDictionary<int, bool> numbers = BuildDictionary(nums);

			int index = 0;
			foreach(var pair in numbers)
			{
				nums[index] = pair.Key;

				if (pair.Value)
				{
					++index;
					nums[index] = pair.Key;
				}
				++index;
			}


			return index;
		}

		public static SortedDictionary<int, bool> BuildDictionary(int[] nums)
		{
			SortedDictionary<int, bool> dictionary = new SortedDictionary<int,bool>();
			for(int i = 0; i < nums.Length; i++)
			{
				if(dictionary.ContainsKey(nums[i]))
					dictionary[nums[i]] = true;
				else
					dictionary.Add(nums[i], false);
			}
			return dictionary;
		}
	}
}
