using LeetCodeHelperFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class ContinuousSubarraySumProblem
	{
		//solving this problem: https://leetcode.com/problems/continuous-subarray-sum/
		public static void Tester()
		{
			int[] input = new int[] { 98, 84, 83, 96, 22, 14, 56, 71, 37, 15, 6, 13, 35, 0, 36, 47, 85, 29, 48, 30, 94, 14, 14, 54, 18, 33, 46, 16, 18, 27, 70, 94, 0, 60, 46, 50, 24, 48, 60, 62, 63, 35, 91, 3, 56, 79, 16, 67, 0, 64, 82, 16, 98, 79, 39, 77, 9, 1, 72, 2, 75, 48, 8, 73, 25, 51, 20, 25, 70, 30, 72, 41, 78, 18, 49, 56, 45, 63, 78, 78, 82, 46, 49, 11, 43, 86, 12, 75, 13, 29, 99, 77, 96, 6, 15, 63, 90, 47, 16, 44, 18, 56, 76, 75, 78, 28, 56, 92, 70, 53, 69, 2, 87, 76, 23, 95, 32, 74, 6, 40, 68, 60, 3, 73, 11, 57, 78, 4, 68, 38, 9, 59, 78, 21, 50, 1, 90, 59, 83, 28, 44, 45, 82, 13, 65, 21, 61, 69, 50, 59, 24, 93, 97, 43, 15, 94, 67, 59, 31, 39, 46, 53, 81, 15, 99, 45, 0, 55, 52, 99, 97, 63, 79, 8, 78, 74, 23, 88, 20, 66, 55, 32, 60, 5, 2, 25, 56, 75, 36, 24, 50, 0, 97, 22, 99, 6, 52, 26, 40, 93, 84, 13, 12, 23, 10, 27, 21, 61, 89, 9, 77, 28, 37, 43, 13, 34, 27, 81, 56, 6, 61, 8, 57, 17, 38, 14, 58, 49, 38, 17, 51, 64, 81, 100, 55, 15, 78, 25, 13, 96, 5, 81, 70, 54, 40, 8, 72, 47, 75, 41, 27, 52, 86, 58, 97, 39, 49, 0, 48, 54, 52, 56, 33, 46, 97, 36, 14, 22, 76, 30, 49, 100, 29, 28, 58, 18, 73, 7, 81, 32, 78, 73, 95, 3, 75, 74, 51, 99, 80, 85, 16, 26, 18, 55, 11, 21, 38, 83, 46, 44 };
			input = InputReadingFuncts.ReadMassiveInput_Array("\\MassiveInputs\\ContinuousSubarray_MassiveInput.txt");
			int k = 2000000000;

			Console.WriteLine("Starting Window-based For Loop: ");
			TimingFuncts.StartStopWatch();
			Console.WriteLine(CheckSubarraySum_WindowBased(input, k));
			Console.WriteLine(TimingFuncts.StopStopWatch());

			Console.WriteLine("Starting Parallel For Loop");
			TimingFuncts.StartStopWatch();
			Console.WriteLine(CheckSubarraySum_ParallelFor(input, k));
			Console.WriteLine(TimingFuncts.StopStopWatch());

			Console.WriteLine("Starting Non Parallel For Loop: ");
			TimingFuncts.StartStopWatch();
			Console.WriteLine(CheckSubarraySum(input, k));
			Console.WriteLine(TimingFuncts.StopStopWatch());
		}

		public static bool CheckSubarraySum(int[] nums, int k)
		{
			int curSum;
			for (int i = 0; i < nums.Length; i++)
			{
				//curSum = nums[i];
				curSum = nums[i];

				for (int j = i + 1; j < nums.Length; j++)
				{
					curSum += nums[j];

					if(curSum % k == 0)
						return true;
				}

			}

			return false;
		}


		public static bool CheckSubarraySum_ParallelFor(int[] nums, int k)
		{
			if(nums.Length < 5000)
			{
				for (int i = 0; i < nums.Length; i++)
				{
					//curSum = nums[i];
					int curSum = nums[i];

					for (int j = i + 1; j < nums.Length; j++)
					{
						curSum += nums[j];

						if (curSum % k == 0)
							return true;
					}

				}

				return false;
			}
			else
			{
				bool foundSubarray = false;

				Parallel.For(0, nums.Length, curIndex =>
				{
					int curSum = nums[curIndex];

					for (int j = curIndex + 1; j < nums.Length; j++)
					{
						if (foundSubarray)
							break;

						curSum += nums[j];

						if (curSum % k == 0)
						{
							foundSubarray = true;
							break;
						}
					}

				});

				return foundSubarray;
			}

			//return false;
			
		}

		public static int[] staticNums;
		public static bool CheckSubarraySum_WindowBased(int[] nums, int k)
		{
			staticNums = nums;

			if(nums.Length < 5000)
			{

				bool foundSubarray = false;

				for(int windowSize = 1; windowSize < nums.Length; windowSize++)
				{
					int leftSide = 0;
					int rightSide = leftSide + windowSize;

					int prevSum = GetInitialSum(leftSide, rightSide);

					if (prevSum % k == 0)
						foundSubarray = true;

					while (rightSide < nums.Length - 1 && foundSubarray == false)
					{
						rightSide++;

						prevSum += staticNums[rightSide];

						prevSum -= staticNums[leftSide];

						leftSide++;

						if (prevSum % k == 0)
							foundSubarray = true;

					}
				}

				return foundSubarray;
			}
			else
			{
				bool foundSubarray = false;

				Parallel.For(1, nums.Length - 1, windowSize =>
				{
					int leftSide = 0;
					int rightSide = leftSide + windowSize;

					int prevSum = GetInitialSum(leftSide,rightSide);

					if (prevSum % k == 0)
						foundSubarray = true;

					while(rightSide < nums.Length - 1 && foundSubarray == false)
					{
						rightSide++;

						prevSum += staticNums[rightSide];

						prevSum -= staticNums[leftSide];

						leftSide++;

						if (prevSum % k == 0)
							foundSubarray = true;

					}
				});

				return foundSubarray;
			}
		}

		public static int GetInitialSum(int leftSide, int rigthSide)
		{
			int curSum = 0;
			for (int i = leftSide; i <= rigthSide; i++)
			{
				curSum += staticNums[i];
			}
			return curSum;
		}
	}
}
