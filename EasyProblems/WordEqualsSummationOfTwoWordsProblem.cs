using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class WordEqualsSummationOfTwoWordsProblem
	{
		//solving this problem: https://leetcode.com/problems/check-if-word-equals-summation-of-two-words/

		public static bool IsSumEqual(string firstWord, string secondWord, string targetWord)
		{
			

			int firstInt = int.Parse(getNumStr(firstWord));
			int secondInt = int.Parse(getNumStr(secondWord));
			int targetInt = int.Parse(getNumStr(targetWord));

			if(firstInt + secondInt == targetInt)
				return true;
			else
				return false;
		}

		public static char[] getNumStr(string word)
		{
			
			char[] numChars = new char[word.Length];

			for(int i = 0; i < numChars.Length; i++)
			{
				numChars[i] = (char)(word[i] - 49);
			}

			return numChars;
		}
	}
}
