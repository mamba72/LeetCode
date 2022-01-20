using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class RemoveNthNodeFromEndOfListProblem
	{
		//solving this problem: https://leetcode.com/problems/remove-nth-node-from-end-of-list/

		public static ListNode RemoveNthFromEnd(ListNode head, int n)
		{
			ListNode curNode = head;
			ListNode removeParent = curNode;

			int nodeCounter = 0;
			while(curNode.next != null)
			{
				curNode = curNode.next;

				if(nodeCounter >= n - 1)
					removeParent = removeParent.next;
				nodeCounter++;
			}

			removeParent.next = removeParent.next.next;

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
