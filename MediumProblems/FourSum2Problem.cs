using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class FourSum2Problem
	{
		//solving this problem: https://leetcode.com/problems/4sum-ii/
		public static void Tester()
		{
			int[] nums1 = { 1, 2 };
			int[] nums2 = { -2, -1 };
			int[] nums3 = { -1, 2 };
			int[] nums4 = { 0, 2 };

			Console.WriteLine(FourSumCount_BruteForce(nums1, nums2, nums3, nums4));
		}


		private static int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
		{
			
			Dictionary<int,int> map = new Dictionary<int, int>();

			for(int i = 0; i < nums1.Length; i++)
			{
				for(int j = 0; j < nums2.Length; j++)
				{
					int sum = nums3[i] + nums4[j];
					if(map.ContainsKey(sum))
						map[sum]++;
					else
						map.Add(sum, map.GetValueOrDefault(sum, 0) + 1);
				}
			}

			int res = 0;
			for(int i = 0;i < nums1.Length; i++)
			{
				for(int j =0; j < nums2.Length;j++)
				{
					res += map.GetValueOrDefault(-1 * (nums1[i] + nums2[j]), 0);
				}
			}

			return res;

		}

		private static Dictionary<int, int> GetTwoSums(int[] nums1, int[] nums2)
		{
			Dictionary<int , int> result = new Dictionary<int,int>();

			int sum;
			for (int i = 0; i < nums1.Length; i++)
			{
				for(int j = 0; j < nums1.Length; j++)
				{
					sum = nums1[i] + nums2[j];

					if (result.ContainsKey(sum))
						result[sum]++;
					else
						result.Add(sum, 1);
				}
			}

			return result;
		}


		private static int FourSumCount_BruteForce(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
		{
			Array.Sort(nums1);
			Array.Sort(nums2);
			Array.Sort(nums3);
			Array.Sort(nums4);

			int count = 0;
			for(int i = 0; i < nums1.Length;i++)
			{
				//sum = nums1[i];

				for(int j = 0;j < nums2.Length;j++)
				{
					int sum2 = nums1[i] + nums2[j];
					//if (sum2 > 0)
					//	break;

					for(int k = 0; k < nums3.Length;k++)
					{
						int sum3 = sum2 + nums3[k];

						for (int g = 0; g < nums4.Length;g++)
						{
							int sum4 = sum3 + nums4[g];
							if(sum4 == 0)
								count++;
							else if(sum4 > 0)
							{
								break;
							}
						}
					}
				}
			}

			return count;
		}
	}
}
