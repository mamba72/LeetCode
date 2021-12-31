using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	class LongestPalindromicSubstring
	{
		//solving this problem:https://leetcode.com/problems/longest-palindromic-substring/
		public static void LongestPalindromeTester()
		{

		}

		public static string LongestPalindrome(string s)
		{
			//shortest string cases
			if (s.Length == 1)
				return s;
			else if (s.Length == 2)
				return s[0] + "";



			HashSet<string> previousPalindromes = new HashSet<string>();
			string curLongest = "";

			//string revString = (string)s.Reverse();

			//change the window size
			for(int windowSize = 3; windowSize < s.Length; ++windowSize)
			{
				//change position of the window
				for(int startIndex = 0; startIndex < s.Length - windowSize; ++startIndex)
				{
					string curStr = s.Substring(startIndex, windowSize);
					if(isPalendrome(s, ref previousPalindromes))
					{

					}

				}
			}

			return curLongest;

		}

		public static bool isPalendrome(string s, ref HashSet<string> prevPalendromes)
		{

			//i think char comparison is faster than dictionary access time, so im going to do this first
			//if the first and last letters are not the same, its definitely not a palindrome
			if (s[0].Equals(s[s.Length]))
			{
				if (prevPalendromes.Contains(s))
					return true;
				else
				{
					if (s.CompareTo((string)s.Reverse()) == 0)
					{
						prevPalendromes.Add(s);
						return true;
					}
					else return false;
				}
			}
			else
				return false;
		}

	}
}
