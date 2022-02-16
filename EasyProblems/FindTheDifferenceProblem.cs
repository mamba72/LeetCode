using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class FindTheDifferenceProblem
	{
		//solving this problem: https://leetcode.com/problems/find-the-difference/
		private static char FindTheDifference(string s, string t)
		{
			if (s.Length == 0)
				return t[0];
			Dictionary<char, int> letterCount = new Dictionary<char, int>();

			foreach (char c in s)
			{
				if (letterCount.ContainsKey(c))
					letterCount[c]++;
				else
					letterCount.Add(c, 1);
			}

			Dictionary<char, int> newLetterCount = new Dictionary<char, int>();

			foreach (char c in t)
			{
				if (newLetterCount.ContainsKey(c))
				{
					newLetterCount[c]++;
					if (newLetterCount[c] > letterCount[c])
						return c;
				} else
				{
					if (letterCount.ContainsKey(c) == false)
						return c;
					newLetterCount.Add(c, 1);
				}
			}

			return '?';
		}


		private static char FindTheDifference_ListVersion(string s, string t)
		{
			List<char> sList = new List<char>(s);

			foreach (char c in t)
			{
				if (sList.Remove(c) == false)
					return c;
			}

			return '?';
		}
	}
}
