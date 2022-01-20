using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class PrintWordsVerticallyProblem
	{
		//solving this problem: https://leetcode.com/problems/print-words-vertically/
		public static void Tester()
		{
			string input = "HOW ARE YOU";

			var _ = PrintVertically(input);

		}

		public static IList<string> PrintVertically(string s)
		{
			string[] words = s.Split(' ');

			int maxLength = words.Select(x => x.Length).Max();

			StringBuilder[] vertWords = new StringBuilder[maxLength];

			for (int i = 0; i < vertWords.Length; i++)
				vertWords[i] = new StringBuilder(maxLength);

			for(int i = 0; i < words.Length; i++)
			{

				for(int j = 0; j < maxLength; j++)
				{
					if(j < words[i].Length)
						vertWords[j].Append(words[i][j]);
					else
						vertWords[j].Append(' ');
				}
			}

			
			return vertWords.Select(x => x.ToString().TrimEnd()).ToList();
		}
	}
}
