using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class LengthOfLastWordProblem
	{
		//solving this problem: https://leetcode.com/problems/length-of-last-word/

		public static int LengthOfLastWord(string s)
		{
			s = s.Trim();

			if(!s.Contains(" "))
				return s.Length;

			int starterIndex = 0;
			//go backwards through the string
			for(int i = s.Length - 1; i >= 0; --i)
			{
				if(s[i] == ' ')
				{
					starterIndex = i;
					break;
				}
			}

			return s.Length - 1 - starterIndex;
		}
	}
}
