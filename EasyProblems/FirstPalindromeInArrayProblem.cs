using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class FirstPalindromeInArrayProblem
	{
		//solving this problem: https://leetcode.com/problems/find-first-palindromic-string-in-the-array/

		public static string FirstPalindrome(string[] words)
		{
			bool[] palindromes = new bool[words.Length];

			Parallel.For(0, words.Length, index =>
			{
				palindromes[index] = isPalindrome(words[index]);
			});

			for(int i = 0; i < palindromes.Length; i++)
			{
				if(palindromes[i])
					return words[i];
			}

			return "";
		}


		public static bool isPalindrome(string s)
		{
			int left = 0;
			int right = s.Length - 1;

			while (left < right)
			{
				if (s[left] != s[right])
				{
					return false;
				}

				left++;
				right--;
			}


			return true;
		}
	}
}
