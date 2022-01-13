using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class FourSumProblem
	{
		//solving this problem: https://leetcode.com/problems/4sum/
		public static void Tester()
		{
			int[] input = { 2, 2, 2, 2, 2 };
			int target = 8;
			input = new int[]{ 15, -2, 78, 23, -27, 37, -44, 25, -91, -14, -83, -62, 19, -30, -44, -85, -37, -29, 26, -62, -40, -20, 80, -100, 61, 96, 70, -87, -67, 97, 12, 45, 99, 30, -42, 57, 27, 29, -55, 21, 87, -53, 53, -49, 16, -28, -12, -4, -9, 16, -40, 76, 97, 44, -1, 86, 47, 60, 34, 54, 47, -77, 76, 26, -94, -12, -92, -44, 77, 20, -32, -52, -76, -77, 59, 32, 5, 12, -35, -3, 6, 32, 77, 9, -23, 93, -47, -50, 83, 29, 71, -94, -61, 92, -45, 35, -74, 55, 67, 5, 24, -48, -28, -83, 87, -27, -23, 17, -70, -5, 99, -97, 83, -62, -34, 79, 9, -13, 92, 50, 65, -67, 98, 96, -28, -89, 98, -3, -47, -52, -46, -80, 80, -27, -73, -25, -45, -62, -56, 42, 50, -1, 82, 6, 51, 0, 61, -81, -4, -70, 19, -7, 17, -45, 51, 33, -43, -61, 15, -24, 42, -94, -22, 24, -24, -6, 37, -9, -31, 22, -2, 19, -58, -100, -74, -64, 62, 39, -5, 61, 56, 93, 72, -100, 46, 9, -14, 73, 86, -76, -80, -54, 25, -74, -65, 23, -58, 38, -17, -16};
			Console.WriteLine(FourSum(input, target));

		}


		public static IList<IList<int>> FourSum(int[] nums, int target)
		{
			Array.Sort(nums);

			List<IList<int>> result = new List<IList<int>>();

			if(nums.Length < 4)
			{
				return result;
			}

			//else if(nums.Length == 4 && nums.Sum() == target)
			//{
			//	result.Add(nums.ToList());
			//	return result;
			//}

			//HashSet<int[]> sums = new HashSet<int[]>();
			LinkedList<int[]> sums = new LinkedList<int[]>();

			int newTarget;
			for(int i = 0; i < nums.Length; i++)
			{
				newTarget = target - nums[i];

				threeSum(nums, newTarget, i, ref sums);


			}

			var resArray = sums.Select(x => (x[0], x[1], x[2], x[3])).Distinct().Select(y=>new int[] {y.Item1, y.Item2, y.Item3, y.Item4}).ToArray();

			result.AddRange(resArray);


			return result;

		}

		


		public static void threeSum(int[] nums, int target, int curIndex, ref LinkedList<int[]> sums)
		{

			//LinkedList<int[]> res = new LinkedList<int[]>();

			for(int i = 0; i < nums.Length - 2;i++)
			{
				if (i == curIndex)
					continue;

				if(i == 0 || (nums[i] != nums[i - 1])) //removed i > 0 && 
				{
					int lo = i + 1, hi = nums.Length - 1, sum = target - nums[i];

					while(lo < hi)
					{
						if(lo == curIndex)
						{
							lo++;
							continue;
						}	
						if(hi == curIndex)
						{
							hi--;
							continue;
						}

						if (nums[lo] + nums[hi] == sum)
						{
							int[] newArray = new int[] { nums[i], nums[lo], nums[hi], nums[curIndex] };
							Array.Sort( newArray );
							sums.AddFirst(newArray);

							//while (lo < hi && nums[lo] == nums[lo + 1]) lo++;
							//while (lo < hi && nums[hi] == nums[hi - 1]) hi--;
							lo++;
							hi--;

						}
						else if (nums[lo] + nums[hi] < sum) lo++;
						else hi--;
					}
				}
			}

			//return res;

		}


	}
}
