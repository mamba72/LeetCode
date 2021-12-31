using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class ProductOfArrayProblem
	{
		//solving this problem: https://leetcode.com/problems/product-of-array-except-self/
		public static void ProductTester()
		{

		}

		public static int[] ProductExceptSelf(int[] nums)
		{
			int[] answer = new int[nums.Length];

			
			int[] leftProduct = new int[nums.Length];
			leftProduct[0] = 1;
			int[] rightProduct = new int[nums.Length];
			rightProduct[nums.Length - 1] = 1;

			for (int i = 1; i < nums.Length; i++)
			{
				leftProduct[i] = leftProduct[i - 1] * nums[i - 1];
			}
			
			for(int j = nums.Length - 2; j >= 0; j--)
			{
				rightProduct[j] = rightProduct[j + 1] * nums[j + 1];
			}

			for(int k = 0; k < nums.Length; k++)
			{
				answer[k] = leftProduct[k] * rightProduct[k];
			}

			return answer;
		}
	}
}
