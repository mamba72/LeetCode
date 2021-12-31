using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class MergeTwoSortedListsProblem
	{
		//solving this problem: https://leetcode.com/problems/merge-two-sorted-lists/
		public static void MergeTester()
		{

		}

		public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
		{
			//LinkedList<int> masterList = new LinkedList<int>();

			//if either lists are empty
			if (list1 == null)
				return list2;
			else if (list2 == null)
				return list1;

			//grab the first node, whichever is smaller

			ListNode head;
			if(list1.val <= list2.val)
			{
				head = list1;
				list1 = list1.next;
			}else
			{
				head = list2;
				list2 = list2.next;
			}
			

			ListNode curNode = head;

			while(list1 != null || list2 != null)
			{
				//if neither list is empty,
				if(list1 != null && list2 != null)
				{
					if(list1.val <= list2.val)
					{
						//masterList.AddLast(list1.val);
						curNode.next = list1;
						list1 = list1.next;
						curNode = curNode.next;
					}
					else
					{
						//masterList.AddLast(list2.val);
						curNode.next = list2;
						list2 = list2.next;
						curNode = curNode.next;
					}
				}//if list 2 is null but list1 is not
				else if(list1 != null)
				{
					//masterList.AddLast(list1.val);
					curNode.next = list1;
					list1 = list1.next;
					curNode = curNode.next;
				}//if list 1 is null but list2 is not
				else if(list2 != null)
				{
					//masterList.AddLast(list2.val);
					curNode.next = list2;
					list2 = list2.next;
					curNode = curNode.next;
				}
			}
			//now i have a linked list with all the values from both lists and it should be sorted

			return head;
		}


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
	}
}
