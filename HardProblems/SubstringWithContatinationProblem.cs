using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
	internal class SubstringWithContatinationProblem
	{
		//solving this problem: https://leetcode.com/problems/substring-with-concatenation-of-all-words/
		public static void FindSubstringTester()
		{
			string inputString = "barfoothefoobarman";
			string[] inputWords = new string[] { "foo","bar" };

			FindSubstring(inputString, inputWords);
		}

		private static HashSet<string> UsedCombination;

		public static IList<int> FindSubstring(string s, string[] words)
		{
			IList<int> positions = new List<int>();

			//foreach (string word in words)
			//{
			//	int firstIndex = s.IndexOf(word);

			//	if (firstIndex == -1)
			//		continue;
			//	else if (s.IndexOf(word, firstIndex) == -1)
			//		positions.Add(firstIndex);
			//	else
			//		continue;

			//}

			//go through the words finding the minimum index,
			//if there is a word with a negative index, just return an empty list

			int minIndex = s.Length;

			foreach(string word in words)
            {
				minIndex = Math.Min(minIndex, s.IndexOf(word));
            }
			//if one of the words was not found, there will be no valid concatenation, so return nothing
			if(minIndex == -1)
				return new List<int>();

			for(int i = minIndex; i < s.Length; i += words.First().Length)
            {
				
            }



			return positions;
		}

		

		//check if the given index is the beginning of a valid substring
		private static bool IsValidSubstringStartIndex(int index, string s, List<string> words)
		{
			string curSubstring = s.Substring(index);
			//iterate through the words trying to see if they occur uninterrupted.
			while(words.Count > 0)
			{
				bool foundAWord = false;
				foreach(string word in words)
                {
					if (word.StartsWith(curSubstring))
                    {
						index += word.Length;
						curSubstring = s.Substring(index);
						words.Remove(word);
						foundAWord = true;
						break;
                    }
                }

				if (foundAWord == false)
                {
					return false;
                }
					
			}

			return true;
		}

	}
}
