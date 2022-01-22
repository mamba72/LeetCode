using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class SetMismatchProblem
	{
		//solving this problem: https://leetcode.com/problems/set-mismatch/

		public static int[] FindErrorNums(int[] nums)
		{
			Array.Sort(nums);

			foreach (int num in nums)
				Console.Write(num + ", ");
			Console.WriteLine();

			int missing = 0;
			int duplicate = 0;


			for(int i = 0; i < nums.Length - 1; i++)
			{
				if(nums[i] != i + 1)
				{
					//return new int[] { nums[i], i + 1 };
					missing = i + 1;
				}
				if(nums[i] == nums[i+1])
				{
					//return new int[] {i + 1, i+2};
					duplicate = nums[i];
				}

				if(missing != 0 && duplicate != 0)
					return new int[] { duplicate, missing };
			}



			return null;
		}
	}
}
