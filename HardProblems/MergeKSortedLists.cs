using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
	internal class MergeKSortedLists
	{
		//solving this problem: https://leetcode.com/problems/merge-k-sorted-lists/
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int val = 0, ListNode next = null)
			{
				this.val = val;
				this.next = next;
			}
		}

		public static ListNode MergeKLists(ListNode[] lists)
		{
			LinkedList<int> fullList = AddToList(lists);

			int[] SortedList = new int[fullList.Count];
			Array.Sort(SortedList);

			ListNode head = new ListNode(SortedList[0]);
			ListNode curNode = head;
			for (int i = 1; i < SortedList.Length; i++)
            {
				curNode.next = new ListNode(SortedList[i]);
				curNode = curNode.next;
            }

			return head;

		}

		private static LinkedList<int> AddToList(ListNode[] lists)
		{
			LinkedList<int> fullList = new LinkedList<int>();
			for (int i = 0; i < lists.Length; i++)
            {
				ListNode curNode = lists[i];
				while(curNode != null)
                {
					fullList.AddLast(curNode.val);
					curNode = curNode.next;
                }
            }

			return fullList;
        }
	}
}
