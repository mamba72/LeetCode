using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class SumOfDigitsAfterConvertProblem
	{
		//solving this problem: https://leetcode.com/problems/sum-of-digits-of-string-after-convert/
		public static void Tester()
		{
			string input = "leetcode";
			int k = 2;

			GetLucky(input, k);
		}

		private static int GetLucky(string s, int k)
		{
			string alphabet = "abcdefghijklmnopqrstuvwxyz";
			//convert to numbers
			StringBuilder sb = new StringBuilder();
			foreach(char c in s)
				sb.Append(alphabet.IndexOf(c) + 1);


			string myStr = sb.ToString();
			int digitSum = 0;
			for (int i = 0; i < k; i++)
			{
				//convert to int array
				digitSum = 0;
				foreach (char c in myStr)
				{
					digitSum += int.Parse(c + "");
				}

				myStr = digitSum + "";
			}

			return digitSum;
		}
	}
}
