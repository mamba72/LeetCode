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
				while (curNode != null)
				{
					fullList.AddLast(curNode.val);
					curNode = curNode.next;
				}
			}

			return fullList;
		}


		//private static ListNode MergeKLists_Attempt2(ListNode[] lists)
		//{
		//	if(lists.Length == 0)
		//		return null;
		//	else if(lists.Length == 1)
		//		return lists[0];

		//	ListNode minHead = lists[0];
		//	int indexToSkip = 0;
		//	for(int i = 0; i < lists.Length;i++)
		//	{
		//		if(minHead.val > lists[i].val)
		//		{
		//			minHead = lists[i];
		//			indexToSkip = i;
		//		}
		//	}

		//	bool hasNodesLeft = true;
		//	ListNode curNode = minHead;
		//	while(hasNodesLeft)
		//	{
		//		foreach(ListNode nextListNode in lists)
		//		{
		//			if()
		//		}
		//	}
		//}

		//private static ListNode GetMinNode(ListNode[] lists, int indexToSkip)
		//{
		//	for
		//}

		private static ListNode MergeKLists_Attempt3(ListNode[] lists)
		{
			if (lists.Length == 0)
				return null;
			else if (lists.Length == 1)
				return lists[0];

			ListNode l1 = lists[0];

			for(int i = 1; i < lists.Length;i++)
			{
				l1 = MergeTwoLists(l1, lists[i]);
			}
			return l1;
		}

		private static ListNode MergeTwoLists(ListNode l1, ListNode l2)
		{
			if (l1 == null) return l2;
			else if (l2 == null) return l1;

			if (l1.val < l2.val)
			{
				l1.next = MergeTwoLists(l1.next, l2);
				return l1;
			}
			else
			{
				l2.next = MergeTwoLists(l1, l2.next);
				return l2;
			}
		}
	}
}
