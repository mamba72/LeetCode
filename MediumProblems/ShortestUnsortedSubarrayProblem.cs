using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class ShortestUnsortedSubarrayProblem
	{
		//solving this problem: https://leetcode.com/problems/shortest-unsorted-continuous-subarray/
		public static void FindUnsortedTester()
		{
			int[] input = new int[] { 1, 3, 2, 2, 2 };
			Console.WriteLine(FindUnsortedSubArray(input));
		}


		public static int FindUnsortedSubArray(int[] nums)
		{
			if (nums.Length == 1)
				return 0;

			int leftIndex = 0;
			int rightIndex = nums.Length - 1;
			bool foundLeft = false;
			bool foundRight = false;
			int firstCopyLeft = -1;
			int firstCopyRight = -1;


			while (leftIndex < rightIndex)
			{
				if(foundLeft == false)
				{
					if (nums[leftIndex] > nums[leftIndex + 1])
					{
						foundLeft = true;
						firstCopyLeft = -1;
					}
					else if (nums[leftIndex] == nums[leftIndex + 1])
					{
						if (firstCopyLeft == -1)
							firstCopyLeft = leftIndex - 1;

						leftIndex++;
					}

					else
						leftIndex++;
				}
				if(foundRight == false)
				{
					if(nums[rightIndex] < nums[rightIndex - 1])
					{
						foundRight = true;
						firstCopyRight = -1;
						rightIndex++;
					}else if(nums[rightIndex] == nums[rightIndex - 1])
					{
						if(firstCopyRight == -1)
							firstCopyRight = rightIndex + 1;
						rightIndex--;
					}
						
					else
						rightIndex--;
				}

				if (foundLeft && foundRight)
					break;
			}

			if (firstCopyLeft != -1)
				leftIndex = firstCopyLeft;
			if (firstCopyRight != -1)
				rightIndex = firstCopyRight;


			return Math.Max(rightIndex - leftIndex,0);
		}



		public static int FindUnsortedArray_WithSorting(int[] nums)
		{
			int[] sorted = new int[nums.Length];
			Array.Copy(nums, sorted, nums.Length);
			Array.Sort(sorted);

			int leftIndex = 0;
			int rightIndex = sorted.Length - 1;

			bool foundLeft = false;
			bool foundRight = false;

			while(leftIndex < rightIndex)
			{
				if(foundLeft == false)
				{
					if (nums[leftIndex] != sorted[leftIndex])
						foundLeft = true;
					else
						leftIndex++;
				}

				if(foundRight == false)
				{
					if(nums[rightIndex] != sorted[rightIndex])
					{
						foundRight = true;
						rightIndex++;
					}else
					{
						rightIndex--;
					}
				}

				if (foundRight && foundLeft)
					break;
			}

			return Math.Max(rightIndex - leftIndex, 0);

		}




	}
}
