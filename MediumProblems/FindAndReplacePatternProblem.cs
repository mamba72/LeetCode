using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class FindAndReplacePatternProblem
	{
		//solving this problem: https://leetcode.com/problems/find-and-replace-pattern/
		public static IList<string> FindAndReplacePattern(string[] words, string pattern)
		{

			List<string> result = new List<string>(words.Length);


			for (int i = 0; i < words.Length; i++)
			{
				if(IsIsomorphic_SuperFast(pattern, words[i]))
					result.Add(words[i]);
			}

			return result;
		}

		public static bool IsIsomorphic_SuperFast(string s, string t)
		{
			if (s.Length == 1)
			{
				return true;
			}
			int[] first = new int[256];
			int[] second = new int[256];
			for (int i = 0; i < s.Length; i++)
			{
				if (first[s[i]] != second[t[i]]) return false;

				first[s[i]] = i + 1;
				second[t[i]] = i + 1;
			}

			return true;
		}


		public static bool IsIsomorphic(string s, string t)
		{

			if (s.Length == 1)
				return true;

			Dictionary<char, char> letterMapping = new Dictionary<char, char>();

			for (int i = 0; i < s.Length; i++)
			{
				if (letterMapping.ContainsKey(s[i]))
				{
					if (!letterMapping[s[i]].Equals(t[i]))
					{
						return false;
					}
				}
				else
				{
					if (letterMapping.ContainsValue(t[i]))
						return false;
					else
						letterMapping.Add(s[i], t[i]);
				}
			}

			return true;
		}


		public static bool WordPattern(string pattern, string s)
		{

			string[] splitWords = s.Split(' ');

			if (pattern.Length > splitWords.Length)
				return false;

			if (pattern.Distinct().Count() > splitWords.Distinct().Count())
				return false;

			if (splitWords.Length % pattern.Length != 0)
				return false;

			Dictionary<char, string> letterWordLink = new Dictionary<char, string>();

			for (int i = 0; i < pattern.Length; i++)
			{
				if (!letterWordLink.ContainsKey(pattern[i]))
					letterWordLink.Add(pattern[i], splitWords[i]);
				else
				{
					if (letterWordLink[pattern[i]] != splitWords[i])
						return false;
				}

			}


			int wordIndex = 0;
			int patternIndex = 0;

			while (wordIndex < splitWords.Length)
			{
				if (splitWords[wordIndex] != letterWordLink[pattern[patternIndex]])
					return false;
				else
				{
					wordIndex++;

					patternIndex = (patternIndex + 1) % pattern.Length;
				}
			}


			return true;
		}
	}
}
