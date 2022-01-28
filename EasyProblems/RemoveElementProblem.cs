using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class RemoveElementProblem
	{
		//solving this problem: https://leetcode.com/problems/remove-element/
		public static void Tester()
		{
			int[] nums = { 3, 2, 2, 2,2, 3 };
			int val = 2;
			RemoveElement(nums, val);
		}
		
		public static int RemoveElement(int[] nums, int val)
		{
			if (nums.Length == 0)
				return 0;


			Queue<int> prevRemovedIndex = new Queue<int>();
			//int lastRemoved = 0;
			if (nums[0] == val)
			{
				nums[0] = -1;
				prevRemovedIndex.Enqueue(0);
			}
			
			for(int i = 1; i < nums.Length; i++)
			{
				if(nums[i] == val)
				{
					nums[i] = -1;
					prevRemovedIndex.Enqueue(i);
				}

				else if(prevRemovedIndex.Count != 0)
				{
					nums[prevRemovedIndex.Dequeue()] = nums[i];
					nums[i] = -1;
					prevRemovedIndex.Enqueue(i);
				}else
				{
					continue;
				}
				
			}

			if (prevRemovedIndex.Count != 0)
				return prevRemovedIndex.Dequeue();
			else
				return nums.Length;
		}
	}
}
