using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class MaximumNumberOfWordsProblem
	{
		//solving this problem: https://leetcode.com/problems/maximum-number-of-words-found-in-sentences/
		public static int MostWordsFound_Linq(string[] sentences)
		{

			Dictionary<string, int> result = new Dictionary<string, int>();

			var parSent = sentences.AsParallel();
			parSent.ForAll(delegate(string sentence) {
				result.Add(sentence, sentence.Split(" ").Length);
			});


			return result.Max(kvp => kvp.Value);
		}

		public static int MostWordsFound_Iterate(string[] sentences)
		{
			int max = int.MinValue;

			foreach (string sentence in sentences)
			{
				max = Math.Max(max, sentence.Split(" ").Length);
			}

			return max;
		}
	}
}
