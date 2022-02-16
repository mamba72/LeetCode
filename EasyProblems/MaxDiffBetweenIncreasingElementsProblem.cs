using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class MaxDiffBetweenIncreasingElementsProblem
	{
		//solving this problem: https://leetcode.com/problems/maximum-difference-between-increasing-elements/
		public static void Tester()
		{

		}

		private static int MaximumDifference(int[] nums)
		{
			int maxDiff = -1, minNum = nums[0];

			foreach (int num in nums)
			{
				if (num < minNum)
					minNum = num;

				int diff = num - minNum;

				if (diff > maxDiff)
					maxDiff = diff;
			}

			return maxDiff;
		}

		//public static int[] RegexMatcher(string text, string searchWord)
		//{
		//	int wordIndex = 0;
		//	List<int> matches = new List<int>();

		//	for(int i = 0; i < text.Length; i++)
		//	{
		//		if (text[i] == searchWord[wordIndex])
		//			wordIndex++;
		//		else
		//			wordIndex = 0;

		//		if (wordIndex == searchWord.Length)
		//			matches.Add(i);
		//	}
		//	return matches.ToArray();
		//}

		//public static int[] RegMatcher_async(string text, string searchWord)
		//{
		//	int wordIndex = 0;
		//	ConcurrentQueue<int> matches = new ConcurrentQueue<int>();
		//	List<Task> tasks = new List<Task>();
		//	char firstChar = searchWord[0];
		//	for (int i = 0; i < text.Length; i++)
		//	{
		//		if(text[i] == firstChar)
		//		{
		//			tasks.Add(Task.Run(() => {
						
		//			}));
		//		}
		//		if (text[i] == searchWord[wordIndex])
		//		{
		//			wordIndex++;
		//		}
		//	}
		//}
	}
}
