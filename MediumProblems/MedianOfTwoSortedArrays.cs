using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	class MedianOfTwoSortedArrays
	{
		//solving this problem: https://leetcode.com/problems/median-of-two-sorted-arrays/
		//answer is here: https://www.geeksforgeeks.org/median-of-two-sorted-arrays-of-different-sizes/
		public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
		{

			//merge the two arrays

			double median = -1;

			if (ZeroCase(nums1, nums2, out median))
				return median;
			else if (ZeroCase(nums2, nums1, out median))
				return median;
			//taken care of any cases where the arrays are size zero

			return 0;
		}

		public static bool ZeroCase(int[] nums1, int[] nums2, out double median)
		{
			if (nums1.Length == 0)
			{
				if (nums2.Length % 2 != 0)
				{
					//get middle element and just return it
					median = nums2[nums2.Length / 2 + 1];
					return true;
				}
			}
			
			

			median = -1;
			return false;
		}
	}
}
