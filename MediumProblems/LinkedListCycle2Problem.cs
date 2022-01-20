using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class LinkedListCycle2Problem
	{
		//solving this problem: https://leetcode.com/problems/linked-list-cycle-ii/

		public static ListNode DetectCycle(ListNode head)
		{

			if(head == null)
				return null;

			//Dictionary<ListNode, ListNode> nodePrevMap = new Dictionary<ListNode, ListNode>();
			HashSet<ListNode> visited = new HashSet<ListNode>();

			//ListNode prevNode = head;
			//ListNode curNode = head.next;
			ListNode curNode = head;

			//if (prevNode.Equals(curNode))
				//return head;

			//nodePrevMap.Add(curNode, prevNode);
			visited.Add(curNode);

			while(curNode.next != null)
			{
				//prevNode = curNode;
				curNode = curNode.next;

				//if (nodePrevMap.ContainsKey(curNode))
				//	return curNode;
				//else
				//	node

				if(visited.Contains(curNode))
					return curNode;
				else
					visited.Add(curNode);
			}

			return null;
		}

		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x)
			{
				val = x;
				next = null;
			}
		}
	}
}
