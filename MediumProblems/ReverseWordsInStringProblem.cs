using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class ReverseWordsInStringProblem
	{
		//solving this problem: https://leetcode.com/problems/reverse-words-in-a-string/

		public static string ReverseWords(string s)
		{
			s = s.Trim();
			string[] words = s.Split(' ');

			StringBuilder sb = new StringBuilder();
			for(int i = words.Length - 1; i >= 0; i--)
			{
				if(words[i].Length != 0)
				{
					sb.Append(words[i]);
					sb.Append(' ');
				}
				
			}

			return sb.ToString().TrimEnd();
		}
	}
}
