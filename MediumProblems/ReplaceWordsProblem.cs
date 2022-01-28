using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class ReplaceWordsProblem
	{
		//solving this problem: https://leetcode.com/problems/replace-words/
		public string ReplaceWords(IList<string> dictionary, string sentence)
		{
			string[] words = sentence.Split(' ');

			for(int i = 0; i < words.Length; ++i)
			{
				var root = dictionary.Select(x => x).Where(y => words[i].StartsWith(y)).ToArray();

				if(root.Length > 0)
				{
					var minLength = root.Min(x => x.Length);
					words[i] = root.FirstOrDefault(x => x.Length == minLength);
				}
			}

			return string.Join(" ", words);
		}
	}
}
