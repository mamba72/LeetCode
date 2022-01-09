using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class IsPalindromeLinkedListProblem
	{
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

		//solving this problem: https://leetcode.com/problems/palindrome-linked-list/

		public static bool IsPalindrome(ListNode head)
		{
			StringBuilder sb = new StringBuilder();


			while(head != null)
			{
				sb.Append(head.val);
				head = head.next;
			}

			return sb.ToString().Equals(new string(sb.ToString().Reverse().ToArray()));
		}
	}
}
