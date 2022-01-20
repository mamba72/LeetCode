using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class CanPlaceFlowersProblem
	{
		//solving this problem: https://leetcode.com/problems/can-place-flowers/

		public static bool CanPlaceFlowers(int[] flowerbed, int n)
		{
			if (n == 0)
				return true;

			int placedFlowerCounter = 0;

			for(int i = 0; i < flowerbed.Length; i++)
			{
				if(IsValidSpot(flowerbed, i))
				{
					placedFlowerCounter++;
					flowerbed[i] = 1;

					if(placedFlowerCounter == n)
						return true;
				}
			}

			if (placedFlowerCounter >= n)
				return true;
			else
				return false;
		}


		public static bool IsValidSpot(int[] bed, int index)
		{
			if (bed[index] == 1)
				return false;

			if(index > 0)
			{
				if (bed[index - 1] == 1)
					return false;
			}

			if (index < bed.Length - 1)
				if (bed[index + 1] == 1)
					return false;

			return true;
		}

	}
}
