using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class MinimumAbsoluteDifferenceProblem
	{

		//solving this problem: https://leetcode.com/problems/minimum-absolute-difference/
		public static void MinimumAbsDiffTester()
		{
			int[] inputArr = new int[] { 4, 2, 1, 3 };
			MinimumAbsDifference(inputArr);

		}

		private static List<IList<int>> allPairs;

		private static int _minDiff = int.MaxValue;
		private static int MinDiff 
		{ 
			get=> _minDiff;
			set
			{
				_minDiff = value;
				//allPairs.Clear();
			}
		}

		public static IList<IList<int>> MinimumAbsDifference(int[] arr)
		{
			Array.Sort(arr);

			allPairs = new List<IList<int>>();

			MinDiff = FindMinDiff(arr);


			for (int i = 0; i < arr.Length - 1; i++)
			{
				//check if it equals the min, if so, add it to the list
				if ((arr[i+1] - arr[i]) == MinDiff)
				{
					allPairs.Add(new List<int>(new int[] { arr[i], arr[i + 1] }));
				}
			}

			return allPairs;
		}

		//public struct PairDiff
		//{
		//	public PairDiff(int num1, int num2)
		//	{
		//		this.num1 = num1;
		//		this.num2 = num2;
		//	}
		//	public int num1;
		//	public int num2;
		//	public int diff { get => num2 - num1; }
		//}

		public static int FindMinDiff(int[] arr)
		{
			int curMin = int.MaxValue;
			for (int i = 0; i < arr.Length - 1; i++)
			{
				curMin = Math.Min(curMin, arr[i + 1] - arr[i]);
			}

			return curMin;
		}
	}
}
