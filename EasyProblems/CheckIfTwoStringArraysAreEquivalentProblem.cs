using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class CheckIfTwoStringArraysAreEquivalentProblem
	{
		//solving this problem: https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
		private static bool ArrayStringsAreEqual(string[] word1, string[] word2)
		{
			string word1Str = string.Empty;
			string word2Str = string.Empty;
			StringBuilder word2Total = new StringBuilder();


			var task1 = Task.Run(() =>
			{
				StringBuilder word1Total = new StringBuilder();
				foreach (string word in word1)
					word1Total.Append(word);
				word1Str = word1Total.ToString();
			});

			var task2 = Task.Run(() =>
			{
				StringBuilder word2Total = new StringBuilder();
				foreach (string word in word2)
					word2Total.Append(word);
				word2Str = word2Total.ToString();
			});

			//task1();
			//task2.Start();

			task1.Wait();
			task2.Wait();

			return word1Str.Equals(word2Str);
		}
	}
}
