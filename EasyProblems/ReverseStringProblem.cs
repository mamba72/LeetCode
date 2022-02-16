using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class ReverseStringProblem
	{
		//solving this problem: https://leetcode.com/problems/reverse-string/

		private static void ReverseString(char[] s)
		{
			if (s.Length == 1)
				return;

			int left = 0;
			int right = s.Length - 1;

			char tempLeft = s[left];

			while(left < right)
			{
				tempLeft = s[left];

				s[left] = s[right];
				s[right] = tempLeft;
				left++;
				right--;
			}

		}
	}
}
