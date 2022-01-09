using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class LinkedListRandomNodeProblem
	{
		//solving this problem: https://leetcode.com/problems/linked-list-random-node/
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

		//actual parts of the problem:

		private ListNode head;
		private int length = 0;
		public LinkedListRandomNodeProblem(ListNode head)
		{
			this.head = head;
			ListNode curNode = head;
			while(curNode != null)
			{
				length++;
				curNode = curNode.next;
			}
		}


		public int GetRandom()
		{
			if(length == 1)
			{
				return head.val;
			}

			Random random = new Random();

			int index = random.Next(length);

			ListNode curNode = head;
			for(int i = 0; i < index; i++)
			{
				curNode = curNode.next;
			}

			return curNode.val;
		}
	}
}
