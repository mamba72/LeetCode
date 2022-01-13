using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class NumbersSmallerThanCurrentProblem
	{
		//solving this problem: https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/
		public static void SmallerNumbersTester()
		{
			int[] nums = { 8, 1, 2, 2, 3 };
			Console.WriteLine(SmallerNumbersThanCurrent(nums));
		}

		public static int[] SmallerNumbersThanCurrent(int[] nums)
		{
			Dictionary<int, int> numsSmaller = new Dictionary<int, int>();

			int[] numsSorted = new int[nums.Length];
			Array.Copy(nums, numsSorted, nums.Length);

			Array.Sort(numsSorted);
			//HashSet<int> set = new HashSet<int>(nums);
			//int[] numsSorted = set.OrderBy(x => x).ToArray();



			//int[,] numsSmaller = new int[nums.Length,2];
			int previousNum = -1;

			for(int i = 0; i < numsSorted.Length; i++)
			{
				//numsSmaller[i,0] = nums[i];
				if(numsSorted[i] > previousNum)
				{
					numsSmaller.Add(numsSorted[i], i);
					previousNum = numsSorted[i];
				}
			}

			int[] output = new int[nums.Length];
			for(int j = 0; j < nums.Length; j++)
			{
				output[j] = numsSmaller[nums[j]];
			}

			return output;
		}
	}
}
