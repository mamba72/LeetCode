using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
	internal class TrappingRainWaterProblem
	{
		//solving this problem: https://leetcode.com/problems/trapping-rain-water/
		public static void Tester()
		{
			int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
			//height = new int[] { 4, 2, 0, 3, 2, 5 };
			Trap(height);
		}
		
		private static int Trap(int[] height)
		{
			int leftIndex = 0;
			int rightIndex = height.Length - 1;
			int rainBoxes = 0;

			//shift the indexes to the first nonzero value
			while (leftIndex < rightIndex && height[leftIndex] == 0)
				leftIndex++;
			while (leftIndex < rightIndex && height[rightIndex] == 0)
				rightIndex--;

			//int prevHeight = 0;
			int prevCountHeight = 0;
			while (leftIndex < rightIndex)
			{
				//if (height[leftIndex] == 0 || height[rightIndex] == 0)
				//	goto subtractPos;

				int minWall = Math.Min(height[leftIndex], height[rightIndex]);
				for(int i = leftIndex + 1; i < rightIndex; i++)
				{
					if(height[i] < minWall)
						rainBoxes += minWall - Math.Max(height[i], prevCountHeight);
				}
				prevCountHeight = minWall;
				//subtractPos:
				//if(height[leftIndex] < height[rightIndex])
				//	leftIndex++;
				//else
				//	rightIndex--;

				while (leftIndex < rightIndex && height[leftIndex] <= minWall)
					leftIndex++;
				while (leftIndex < rightIndex && height[rightIndex] <= minWall)
					rightIndex--;

			}

			return rainBoxes;
		}

		
	}
}
