using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeHelperFunctions.InputReadingFuncts;

namespace EasyProblems
{
	internal class ReverseLinkedListProblem
	{
		//solving this problem: https://leetcode.com/problems/reverse-linked-list/
		private static ListNode ReverseList(ListNode head)
		{
			if(head == null)
				return null;
			Stack<int> stack = new Stack<int>();

			while(head != null)
			{
				stack.Push(head.val);
				head = head.next;
			}

			ListNode revHead = new ListNode(stack.Pop());

			ListNode curNode = revHead;
			while(stack.Count != 0)
			{
				curNode.next = new ListNode(stack.Pop());
				curNode = curNode.next;
			}	

			return revHead;
		}
	}
}
