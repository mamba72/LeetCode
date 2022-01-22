using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeHelperFunctions;

namespace EasyProblems
{
	internal class TruncateSentenceProblem
	{
		//solving this problem: https://leetcode.com/problems/truncate-sentence/
		public static void Tester()
		{
			string harryPotter = InputReadingFuncts.ReadMassiveInput_Text("\\MassiveInputs\\HarryPotterStone.txt");

			harryPotter = harryPotter.Trim();
			harryPotter = harryPotter.Replace("\n", "");
			harryPotter = harryPotter.Replace("\r", "");

			int numWords = 50000;

			TimingFuncts.StartStopWatch();
			TruncateSentence(harryPotter, numWords);
			Console.WriteLine("With Split: " + TimingFuncts.StopStopWatchElapsedTime().TotalMilliseconds);

			TimingFuncts.StartStopWatch();
			TruncateSentence_NoSplit(harryPotter, numWords);
			Console.WriteLine("No Split: " + TimingFuncts.StopStopWatchElapsedTime().TotalMilliseconds);

		}

		private static string TruncateSentence(string s, int k)
		{

			string[] words = s.Split(' ');

			StringBuilder truncated = new StringBuilder();

			for (int i = 0; i < k; i++)
			{
				truncated.Append(words[i]);

				if(i < k - 1)
					truncated.Append(' ');
			}

			return truncated.ToString();
		}


		private static string TruncateSentence_NoSplit(string s, int k)
		{
			int kthSpaceIndex;
			int spaceCounter = 0;

			for(kthSpaceIndex = 0; kthSpaceIndex < s.Length; kthSpaceIndex++)
			{
				if(s[kthSpaceIndex] == ' ')
					spaceCounter++;
				if(spaceCounter == k)
					break;
			}

			return s.Substring(0, kthSpaceIndex);
		}
	}
}
