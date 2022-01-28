using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class MaximumProductSubarrayProblem
	{
		//solving this problem: https://leetcode.com/problems/maximum-product-subarray/
		public static void Tester()
		{
			int[] nums = { 0, 2 };
			nums = new int[] { -2, 3, -4 };
			MaxProduct(nums);
		}

		private static int MaxProduct(int[] nums)
		{
			int max = int.MinValue, product = 1;
			int prevProduct = int.MinValue;

			foreach (int num in nums)
			{
				product *= num;
				max = Math.Max(max, product);

				if (product == 0)
					product = 1;

				else if (product < prevProduct)
					product = 1;

				prevProduct = product;
			}

			return max;
		}

		//taken from here: https://leetcode.com/problems/maximum-product-subarray/discuss/1608862/JAVA-or-3-Solutions-or-Detailed-Explanation-Using-Image
		private static int MaxProduct_AttemptTwo(int[] nums)
		{
			int n = nums.Length;
			int l = 1, r = 1;
			int ans = nums[0];

			for (int i = 0; i < n; i++)
			{

				//if any of l or r become 0 then update it to 1
				l = l == 0 ? 1 : l;
				r = r == 0 ? 1 : r;

				l *= nums[i];   //prefix product
				r *= nums[n - 1 - i];    //suffix product

				ans = Math.Max(ans, Math.Max(l, r));

			}

			return ans;

		}
	}
}
