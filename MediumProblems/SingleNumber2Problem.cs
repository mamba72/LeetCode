using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class SingleNumber2Problem
	{
		//solving this problem: https://leetcode.com/problems/single-number-ii/
		private static int singleNumber(int[] nums)
		{
			if(nums.Length == 1)
				return nums[0];

			Array.Sort(nums);

			for(int i = 0; i < nums.Length - 2; i += 3)
			{ 
				if(nums[i] != nums[i + 1])
					return nums[i];
			}


			return nums[nums.Length - 1];
		}


	}
}
