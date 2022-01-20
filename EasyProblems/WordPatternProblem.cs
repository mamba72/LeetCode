using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class WordPatternProblem
	{
		//solving this problem: https://leetcode.com/problems/word-pattern/
		public static void Tester()
		{
			string pattern = "abba";
			string s = "dog dog dog dog";

			Console.WriteLine(WordPattern(pattern,s));
		}

		public static bool WordPattern(string pattern, string s)
		{

			string[] splitWords = s.Split(' ');

			if (pattern.Length > splitWords.Length)
				return false;

			if(pattern.Distinct().Count() > splitWords.Distinct().Count())
				return false;

			if(splitWords.Length % pattern.Length != 0)
				return false;

			Dictionary<char, string> letterWordLink = new Dictionary<char, string>();

			for(int i = 0; i < pattern.Length; i++)
			{
				if(!letterWordLink.ContainsKey(pattern[i]))
					letterWordLink.Add(pattern[i], splitWords[i]);
				else
				{
					if(letterWordLink[pattern[i]] != splitWords[i])
						return false;
				}

			}


			int wordIndex = 0;
			int patternIndex = 0;

			while(wordIndex < splitWords.Length)
			{
				if(splitWords[wordIndex] != letterWordLink[pattern[patternIndex]])
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
