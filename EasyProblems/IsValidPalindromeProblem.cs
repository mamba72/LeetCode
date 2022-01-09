using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class IsValidPalindromeProblem
	{
		//solving this problem: https://leetcode.com/problems/valid-palindrome/
		public static void PalindromeTester()
		{
			string input = CreatePalindrome(200000);
			Console.WriteLine(input);
			Console.WriteLine(IsPalindrome(input));
		}

		public static bool IsPalindrome(string s)
		{
			//s = s.Trim();
			s = s.ToLower();

			StringBuilder sb = new StringBuilder();
			
			for(int i = 0; i < s.Length; i++)
			{
				if (char.IsLetter(s[i]) || char.IsDigit(s[i]))
					sb.Append(s[i]);
			}

			//sb = sb.Replace(" ", "");
			s = sb.ToString();

			if(s.Length == 1)
				return true;


			int left = 0;
			int right = s.Length - 1;

			while(left < right)
			{
				if(s[left] != s[right])
				{
					return false;
				}

				left++;
				right--;
			}


			return true;
		}


		public static string CreatePalindrome(int length)
		{
			Random random = new Random();

			StringBuilder sb = new StringBuilder();

			for(int i =0; i<length / 2; i++)
			{
				sb.Append(((char)random.Next(32, 123)).ToString());
			}

			string outStr = sb.ToString();
			string revStr = new(outStr.Reverse().ToArray());

			return outStr + revStr;
		}
	}
}
