using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class NumGoodPairsProblem
	{
		//solving this problem: https://leetcode.com/problems/number-of-good-pairs/

		public static int NumIdenticalPairs(int[] nums)
		{
			//LinkedList<int[]> pairList = new LinkedList<int[]>();
			if(nums.Length == 1)
				return 0;

			int count = 0;

			for(int i = 0; i < nums.Length - 1; i++)
			{
				for(int j = i + 1; j < nums.Length; j++)
				{
					if(nums[j] == nums[i])
						count++;
						//pairList.AddLast(new int[] { i, j });
				}
			}

			return count; //pairList.Count; 
		}
	}
}
