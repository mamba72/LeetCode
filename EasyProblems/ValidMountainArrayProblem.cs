using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class ValidMountainArrayProblem
	{
		//solving this problem: https://leetcode.com/problems/valid-mountain-array/
		public static void Tester()
		{
			int[] nums = { 0, 3, 2, 1 };
			ValidMountainArray(nums);

			nums = new int[] { 2,1 };
			ValidMountainArray(nums);
		}

		public static bool ValidMountainArray(int[] arr)
		{
			if(arr.Length == 1)
			{
				return false;
			}

			int left = 0, right = arr.Length - 1;

			bool leftStop = false;
			bool rightStop = false;

			while(left < right && (!rightStop || !leftStop))
			{
				if(leftStop == false && arr[left] < arr[left + 1])
				{
					left++;
					
				}
				else if (arr[left] == arr[left + 1])
				{
					return false;
				}
				else
					leftStop = true;


				if (rightStop == false && arr[right] < arr[right - 1])
				{
					right--;
					
				}else if(arr[right] == arr[right - 1])
				{
					return false;
				}
				else
					rightStop = true;
			}//end while loop

			if(left == 0 || right == arr.Length - 1)
				return false;

			if(left == right)
				return true;
			else
				return false;

		}
	}
}
