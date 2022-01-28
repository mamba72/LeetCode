using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class AddAndSearchWordsProblem
	{
		//solving this problem: https://leetcode.com/problems/design-add-and-search-words-data-structure/
		public static void Tester()
		{
			WordDictionary dict = new WordDictionary();
			dict.AddWord("bad");
			dict.AddWord("dad");
			dict.AddWord("mad");
			dict.Search("pad");
			dict.Search(".ad");
			dict.Search(".earch");
			dict.Search("s.d");

		}

		public class WordDictionary
		{
			HashSet<string> dict;
			int maxLength;
			int minLength;

			public WordDictionary()
			{
				dict = new HashSet<string>();
				maxLength = 0;
				minLength = int.MaxValue;
			}

			public void AddWord(string word)
			{
				dict.Add(word);
				maxLength = Math.Max(maxLength, word.Length);
				minLength = Math.Min(minLength, word.Length);
			}

			//var availableWords = dict.Select(x => x).Where(y => y.Length == word.Length).ToArray(); //.Where(y => y.StartsWith(word.Substring(0, dotIndex)))

			public bool Search(string word)
			{
				if (word.Length > maxLength || word.Length < minLength)
					return false;

				if(word.Contains("."))
				{
					//all available words are of the correct length
					foreach (string avail in dict)
					{
						if (avail.Length != word.Length)
							continue;

						bool fullMatch = true;
						for(int i = 0; i < word.Length; i++)
						{
							if(word[i] == '.')
							{
								continue;
							}
							else if (avail[i] != word[i])
							{
								fullMatch = false;
								break;
							}
						}

						if (fullMatch)
							return true;
					}

					return false;
				}
				else
				{
					return dict.Contains(word);
				}
			}
		}

		
	}
}
