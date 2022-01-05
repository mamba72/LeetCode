using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class MaximumSubArray
	{
		//solving this problem:https://leetcode.com/problems/maximum-subarray/
		public static void MaxSubArrayTester()
		{
			int[] inputArray = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
			Console.WriteLine(MaxSubArray(inputArray));
		}


		static int[] windowSizeMax;
		static ManualResetEvent[] windowSizeReset;
		static int[] numArray;
		public static int MaxSubArray(int[] nums)
		{
			if(nums.Length == 1)
				return nums[0];

			numArray = nums;
			
			int maxWindowSize = nums.Length - 1;

			windowSizeReset = new ManualResetEvent[maxWindowSize];
			windowSizeReset[0] = new ManualResetEvent(false);

			windowSizeMax = new int[maxWindowSize];

			for(int i = 1; i <= maxWindowSize; i++)
			{
				windowSizeReset[i] = new ManualResetEvent(false);
				ThreadPool.QueueUserWorkItem(RunWindowScan, i);
			}

			

			foreach(var waiter in windowSizeReset)
			{
				waiter.WaitOne();
			}

			return windowSizeMax.Max();
		}

		public static void RunWindowScan(object obj)
		{
			int windowSize = (int)obj;
			

			int previousSum = SumRanges(0,windowSize);

			int max = previousSum;

			for (int rightSide = windowSize + 1; rightSide < numArray.Length; ++rightSide)
			{
				//adding the right value, subtracting the left value
				previousSum = previousSum + numArray[rightSide] - numArray[rightSide - windowSize - 1];

				max = Math.Max(max, previousSum);
			}

			windowSizeMax[windowSize - 1] = max;
			windowSizeReset[windowSize - 1].Set();
		}

		public static int SumRanges(int start, int end)
		{
			int sum = 0;
			for(int i = start; i <= end; ++i)
			{
				sum += numArray[i];
			}
			return sum;
		}
	}
}
