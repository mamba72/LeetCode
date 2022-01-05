using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class ShuffleArrayProblem
	{
		//solving this problem: https://leetcode.com/problems/shuffle-the-array/
		public static int[] Shuffle(int[] nums, int n)
		{
			int[] newArray = new int[nums.Length];
			int curIndex = 0;
			for(int i = 0; i < n; i++)
			{
				newArray[curIndex] = nums[i];
				curIndex++;
				newArray[curIndex] = nums[n+i];
				curIndex++;
			}

			return newArray;
		}
	}
}
