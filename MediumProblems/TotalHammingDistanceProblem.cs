using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class TotalHammingDistanceProblem
	{
		//solving this problem: https://leetcode.com/problems/total-hamming-distance/
		public static void HammingTester()
		{
			int[] input = { 4,14,2,123,564,8 };
			int diff = TotalHammingDistance(input);
			Console.WriteLine(diff);
		}

		//static List<List<int>> comb;
		//static bool[] used;

		public static int TotalHammingDistance(int[] nums)
		{
			if(nums.Length == 1)
				return 0;

			int total = 0;
			//iterate through the numbers, trying to get all the combinations
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					total += GetHammingDistance(nums[i], nums[j]);
				}
			}
			return total;


			//used = new bool[nums.Length];
			//comb = new List<List<int>>();
			//List<int> c = new List<int>();
			//GetComb(nums, 0, c);

			//foreach(List<int> num in comb)
			//{
			//	foreach(int num2 in num)
			//	{
			//		Console.Write(num2 + ", ");
			//	}
			//	Console.WriteLine();
			//}
			//return total; 
		}

		//public static void ZeroExtendStrings(ref string binX, ref string binY)
		//{
		//	if (binX.Length != binY.Length)
		//	{
		//		if (binX.Length < binY.Length)
		//		{
		//			binX = (new string('0', binY.Length - binX.Length)) + binX;
		//		}
		//		else
		//		{
		//			binY = (new string('0', binX.Length - binY.Length)) + binY;
		//		}
		//	}
		//}

		public static int GetHammingDistance(int x, int y)
		{
			int count = 0;
			int xor = x ^ y;
			
			while(xor != 0)
			{
				xor = xor & (xor - 1);
				count++;
			}
			return count;
		}


		//static void GetComb(int[] arr, int colindex, List<int> c)
		//{

		//	if (colindex >= arr.Length)
		//	{
		//		comb.Add(new List<int>(c));
		//		return;
		//	}
		//	for (int i = 0; i < arr.Length; i++)
		//	{
		//		if (!used[i])
		//		{
		//			used[i] = true;
		//			c.Add(arr[i]);
		//			GetComb(arr, colindex + 1, c);
		//			c.RemoveAt(c.Count - 1);
		//			used[i] = false;
		//		}
		//	}
		//}
	}
}
