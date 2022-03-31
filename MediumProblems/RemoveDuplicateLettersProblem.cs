using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class RemoveDuplicateLettersProblem
	{
		//solving this problem: https://leetcode.com/problems/remove-duplicate-letters/
		private string RemoveDuplicateLetters(string s)
		{
			HashSet<char> seenLetters = new HashSet<char>();

			StringBuilder sb = new StringBuilder();

			foreach (char c in s)
			{
				if (!seenLetters.Contains(c))
				{
					sb.Append(c);
					seenLetters.Add(c);
				}
			}

			char[] letters = sb.ToString().ToCharArray();

			Array.Sort(letters);

			return new string(letters);

			//return String.Concat(s.OrderBy(c => c).Distinct());
		}
	}
}
