using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class RangeSumQueryProblem
	{
		//solving this problem: https://leetcode.com/problems/range-sum-query-immutable/

		public class NumArray
		{
			private int[] nums;
			public NumArray(int[] nums)
			{
				this.nums = nums;
			}

			public int SumRange(int left, int right)
			{
				int sum = 0;
				for (int i = left; i <= right; i++)
				{
					sum += nums[i];
				}
				return sum;
			}
		}

		//solving this problem: https://leetcode.com/problems/range-sum-query-mutable/
		public static void Tester()
		{
			int[] nums = { 9, -8 };
			NumArray_Mutable mutable = new NumArray_Mutable(nums);
			mutable.Update(0, 3);
			mutable.SumRange(1,1);

		}
		
		public class NumArray_Mutable
		{
			int[] nums;
			int[] sums;
			public NumArray_Mutable(int[] nums)
			{
				this.nums=nums;

				sums=new int[nums.Length];
				sums[0] = nums[0];
				for (int i = 1; i < nums.Length; i++)
				{
					sums[i] = sums[i-1] + nums[i];
				}
			}

			public void Update(int index, int val)
			{
				int diff = nums[index] - val;
				nums[index] = val;

				if(index == 0)
				{
					sums[0] = nums[0];
					index++;
				}
				//_ = ChangeSums(diff, index);

				if(sums.Length - index < 5000)
				{
					for (int i = index; i < nums.Length; i++)
					{
						sums[i] -= diff;
					}
				}else
				{
					int threadCount = 10;
					int numToDo = sums.Length - index;
					bool oddOneOut = numToDo % 10 != 0;

					Parallel.For(0, threadCount, threadNum =>
					{
						int startIndex = index + threadNum * numToDo;
						for (int i = 0; i < numToDo; ++i)
						{
							sums[startIndex] -= diff;
							startIndex++;
						}
					});

					if(oddOneOut)
						sums[sums.Length - 1] -= diff;

					//Parallel.For(index, nums.Length, i =>
					//{
					//	sums[i] -= diff;
					//});
				}
				

				
			}

			//private async Task ChangeSums(int diff, int index)
			//{
			//	await Task.Run(() =>
			//	{
			//		for (int i = index; i < nums.Length; i++)
			//		{
			//			sums[i] -= diff;
			//		}
			//	});
				
			//}

			public int SumRange(int left, int right)
			{
				if(left == 0)
					return sums[right];
				else if(left == right)
					return nums[left];
				else
				{
					return sums[right] - sums[left - 1];
				}
			}
		}
	}
}
