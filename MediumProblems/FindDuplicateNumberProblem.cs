using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class FindDuplicateNumberProblem
	{
		//solving this problem: https://leetcode.com/problems/find-the-duplicate-number/

		public static int FindDuplicate(int[] nums)
		{
			int[] numCount = new int[nums.Length + 1];

			for(int i = 0; i < nums.Length; i++)
			{
				if(numCount[nums[i]] != 0)
					return nums[i];
				else
					numCount[nums[i]]++;
			}



			return -1;
		}
	}
}
