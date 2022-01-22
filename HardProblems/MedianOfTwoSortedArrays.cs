using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
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


		public static void Tester()
		{
			int[] num1 = new int[] {1,2};
			int[] num2 = new int[] { 3, 4 };

			MedianOfTwoArrays_SecondLook(num1 , num2);
		}

		//using the algorithm from GeeksforGeeks but not copy and pasted
		public static double MedianOfTwoArrays_SecondLook(int[] nums1, int[] nums2)
		{
			int count = 0;

			//double mOdd;
			//double mEven;

			int index1 = 0;
			int index2 = 0;

			int[] outputArray = new int[((nums1.Length + nums2.Length)/2)+1];

			int[] smallerArray;
			int[] largerArray;

			if (nums1.Length < nums2.Length)
			{
				smallerArray = nums1;
				largerArray = nums2;
			}
			else
			{
				smallerArray = nums2;
				largerArray = nums1;
			}
				

			while(count < (outputArray.Length))
			{
				if(index1 < smallerArray.Length && index2 < largerArray.Length)
				{
					if(smallerArray[index1] < largerArray[index2])
					{
						outputArray[count] = smallerArray[index1];
						++index1;
						//index1 = Math.Min(index1 + 1, smallerArray.Length - 1);
					}
					else
					{
						outputArray[count] = largerArray[index2];
						++index2;
						//index2 = Math.Min(index2 + 1, largerArray.Length - 1);
					}
				}
				else
				{
					if(index1 < smallerArray.Length)
					{
						outputArray[count] = smallerArray[index1];
						index1++;
					}
					else
					{
						outputArray[count] = largerArray[index2];
						index2++;
					}
				}

				count++;
			}

			int middleIndex = (nums1.Length + nums2.Length) / 2;

			//if even
			if ((nums1.Length + nums2.Length) % 2 == 0)
			{
				double average = ((double)outputArray[middleIndex] +
					(double)outputArray[(middleIndex) - 1]) / 2;
				return average;
			}
			//if odd
			else
			{
				return outputArray[middleIndex];
			}

		}
	}
}
