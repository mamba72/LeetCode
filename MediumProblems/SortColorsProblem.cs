using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class SortColorsProblem
	{
		//solving this problem: https://leetcode.com/problems/sort-colors/
		public static void SortColorsTester()
		{

		}

		public static void SortColors(int[] nums)
		{
			//plan is to make a linked list where I can simply add zeros to the front, 2s to the back, and 1s at whatever index the last 0 is.
			LinkedList<int> list = new LinkedList<int>();
			LinkedListNode<int> oneNode = null;
			for (int i = 0; i < nums.Length; i++)
			{
				if(nums[i] == 0)
				{
					list.AddFirst(0);
				}
				else if(nums[i] == 1)
				{
					if(oneNode == null)
					{
						oneNode = list.FindLast(0);
						if (oneNode == null)
						{
							oneNode = list.First;
							//if the list is empty or starts with a 2
							if(oneNode == null || oneNode.Value == 2)
							{
								list.AddFirst(1);
								oneNode = list.First;
								continue;
							}
						}
						
					}
					list.AddAfter(oneNode, 1);
				}
				else
					list.AddLast(2);
			}

			Array.Copy(list.ToArray(), nums, nums.Length);
		}
	}
}
