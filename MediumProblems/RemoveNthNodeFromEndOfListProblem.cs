using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeHelperFunctions;
using static LeetCodeHelperFunctions.InputReadingFuncts;

namespace MediumProblems
{
	internal class RemoveNthNodeFromEndOfListProblem
	{
		//solving this problem: https://leetcode.com/problems/remove-nth-node-from-end-of-list/
		public static void Tester()
		{
			int[] nums = { 1, 2, 3, 4, 5 };
			int n = 2;

			nums = new int[] {1,2};
			n = 2;
			ListNode head = InputReadingFuncts.CreateListFromArray(nums);

			ListNode otherHead = RemoveNthFromEnd(head, n);

			CreateArrayFromList(otherHead);

			Console.WriteLine();
		}


		public static ListNode RemoveNthFromEnd(ListNode head, int n)
		{
			if(head.next == null)
			{
				return null;
			}

			ListNode curNode = head;
			ListNode removeParent = curNode;

			int nodeCounter = 0;
			while(curNode.next != null)
			{
				curNode = curNode.next;

				if(nodeCounter > n - 1)
					removeParent = removeParent.next;
				nodeCounter++;
			}

			
			if(removeParent != head)
				removeParent.next = removeParent.next.next;
			else
			{
				head = head.next;
			}

			return head;
		}

		//public class ListNode
		//{
		//	public int val;
		//	public ListNode next;
		//	public ListNode(int val = 0, ListNode next = null)
		//	{
		//		this.val = val;
		//		this.next = next;
		//	}
		//}

	}
}
