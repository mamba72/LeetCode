using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MediumProblems
{
	class LongestSubstring_Nonrepeating
	{
		/// <summary>
		/// Testing this: https://iditect.com/guide/csharp/csharp_howto_count_occurrences_of_a_string_within_a_string.html#:~:text=%20Count%20the%20occurrences%20of%20single%20character%20within,all%20the%20search%20char%20in%20the...%20More%20
		/// </summary>
		public static void LengthOfLonestSubstring_Tester()
		{
			//string testString = "abcabcbb";
			string testString = "bfalhbgirabvianafnruagbriapvbesivbaieahfefjuafuirauqwertyuioplkjhgfdsa";

			int length =  LengthOfLongestSubstring(testString);

			Console.WriteLine("Longest Substring Length: " + length);
		}


		/// <summary>
		/// Given a string s, find the length of the longest substring without repeating substrings.
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public static int LengthOfLongestSubstring(string s)
		{
			//if the string is only 1 char or empty, then it cannot possibly repeat chars
			if (s.Length <= 1)
				return s.Length;

			//check if the set itself is a pair of unique chars. this is because at the moment, it cannot handle strings 

			int maxLength = 1;
			//iterate through the string with gradually increasing window sizes
			for(int windowSize = 2; windowSize <= s.Length; ++windowSize)
			{

				int subLength = AnyValidSubstrings(ref s, ref windowSize);

				//if subLength is valid, then update the max...
				if(subLength != -1)
				{
					maxLength = Math.Max(maxLength, subLength);
				}
				else //...otherwise probably quit since there isn't a substring with nonrepeating chars
				{
					return maxLength;
				}
			}

			return maxLength;

		}

		public static bool HasNoRepeatingChars(ref string s)
		{
			HashSet<char> charSet = new HashSet<char>(s);

			if (charSet.Count == s.Length)
				return true;
			else
				return false;
		}

		public static int AnyValidSubstrings(ref string s, ref int windowSize)
		{
			for(int index = 0; index <= s.Length - windowSize; ++index)
			{
				string curString = s.Substring(index, windowSize);

				if (HasNoRepeatingChars(ref curString))
					return curString.Length;
			}

			return -1;
		}
	}
}
