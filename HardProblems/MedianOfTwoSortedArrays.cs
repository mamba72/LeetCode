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
			}else if (nums2.Length == 0)
            {
				if (nums1.Length % 2 != 0)
				{
					//get middle element and just return it
					median = nums2[nums2.Length / 2 + 1];
					return true;
				}else
                {
					median = (nums1[nums1.Length / 2] + nums1[(nums1.Length / 2) + 1]) / 2;
					return true;
                }
			}
			
			

			median = -1;
			return false;
		}


		public static double MedianOfTwoArrays_AddToList(int[] nums1, int[] nums2)
        {
			double median = -1;
			if(ZeroCase(nums1, nums2,out median))
            {
				return median;
            }

			//create a linked list
			LinkedList<int> fullList = new LinkedList<int>();

			foreach (int num in nums1)
			{
				fullList.AddLast(num);
			}

			foreach (int num in nums2)
            {
				fullList.AddLast(num);
            }

			int[] fullArray = fullList.ToArray();

			if(fullArray.Length % 2 == 0)
            {
				return (fullArray[(fullArray.Length / 2)] + fullArray[(fullArray.Length / 2) + 1]) / 2;
			}
			else //odd length, so get middle
            {
				return fullArray[(fullArray.Length / 2) + 1];
            }

        }
	}
}
