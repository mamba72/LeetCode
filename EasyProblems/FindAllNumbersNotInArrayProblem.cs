using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class FindAllNumbersNotInArrayProblem
	{
		//solving this problem: https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/


		public static IList<int> FindDisappearedNumbers(int[] nums)
		{
			HashSet<int> result = new HashSet<int>(nums);
			nums = result.ToArray();
			Array.Sort(nums);
			LinkedList<int> notInArray = new LinkedList<int>();

			int curVal = 1;
			for (int i = 0; i < nums.Length; i++)
			{
				if(nums[i] != curVal)
					notInArray.AddLast(nums[i]);

				curVal++;
			}

			if (nums[nums.Length - 1] != nums.Length)
				notInArray.AddLast(nums.Length);

			return notInArray.ToList();
		}
	}
}
