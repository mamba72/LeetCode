using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeHelperFunctions.InputReadingFuncts;

namespace EasyProblems
{
	internal class RemoveDuplicatesFromSortedListProblem
	{
		//solving this problem: https://leetcode.com/problems/remove-duplicates-from-sorted-list/
		
		private ListNode DeleteDuplicates(ListNode head)
		{
			if(head == null)
				return null;
			else if(head.next == null)
				return head;

			ListNode curNode = head.next;
			ListNode prevNode = head;

			while(curNode != null)
			{
				if(curNode.val == prevNode.val)
				{
					prevNode.next = curNode.next;

				}else
				{
					prevNode = curNode;
				}
				curNode = curNode.next;
			}

			return head;
		}

		//solving this problem: https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/
		private ListNode DeleteDuplicates2(ListNode head)
		{
			if(head==null)
				return null;
			if (head.next == null)
				return head;
			//ListNode uniqeHead = new ListNode(head.val);

			Dictionary<int, int> numCounter = new Dictionary<int, int>();
			//numCounter.Add(head.val, 1);

			while(head != null)
			{
				if (numCounter.ContainsKey(head.val))
					numCounter[head.val]++;
				else
					numCounter.Add(head.val, 1);

				head = head.next;
			}

			//int[] sortedKeys = numCounter.Keys;
			ListNode uniqueHead = null;
			ListNode curNode = uniqueHead;
			bool firstVal = true;

			foreach(var pair in numCounter)
			{
				if(pair.Value == 1)
				{
					if (!firstVal)
					{
						curNode.next = new ListNode(pair.Key);
						curNode = curNode.next;
					}
					else
					{
						uniqueHead = new ListNode(pair.Key);
						curNode = uniqueHead;
						firstVal = false;
					}
				}
				
			}

			return uniqueHead;
		}
	}
}
