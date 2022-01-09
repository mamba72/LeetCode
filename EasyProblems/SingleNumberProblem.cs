using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class SingleNumberProblem
	{
		//solving this problem: https://leetcode.com/problems/single-number/

		public static int SingleNumber(int[] nums)
		{

			if(nums.Length == 1)
				return nums[0];


			Array.Sort(nums);

			for(int i = 0; i < nums.Length - 1; i += 2)
			{
				//if the pair in our window are not equal, we have found a loner
				if(nums[i] != nums[i + 1])
				{
					//return the loner
					return nums[i];
				}
			}//end for loop

			//if we made it here, we have not found the loner, but we have looked through
			//all indicies other than the last one

			return nums[nums.Length - 1];
		}



		

	}
}
