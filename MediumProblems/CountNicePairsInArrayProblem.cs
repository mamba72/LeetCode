using LeetCodeHelperFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class CountNicePairsInArrayProblem
	{
		//solving this problem: https://leetcode.com/problems/count-nice-pairs-in-an-array/
		public static void CountNicePairsTester()
		{
			int[] input = InputReadingFuncts.ReadMassiveInput_Array("\\MassiveInputs\\CountNicePairs_MassiveInputArray.txt");
			Console.WriteLine(CountNicePairs(input));
		}


		private static int modVal = 1000000007;
		public static int CountNicePairs(int[] nums)
		{
			if (nums.Length == 1)
				return 0;

			Dictionary<int, int> numsToCount = new Dictionary<int, int>();
			int count = 0;

			int num;
			for (int i = 0; i < nums.Length; i++)
			{
				num = nums[i] - rev(nums[i]);

				if(numsToCount.ContainsKey(num))
				{
					count = (count + numsToCount[num]) % modVal;
					numsToCount[num]++;
				}else
					numsToCount.Add(num, 1);
			}

			return count;// % modVal;
		}

		public static int rev(int num)
		{
			if(num < 10)
				return num;
			return checked(int.Parse(new string(num.ToString().Reverse().ToArray())));
		}
	}
}
