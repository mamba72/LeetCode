using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class RemoveKDigitsProblem
	{
		//solving this problem: https://leetcode.com/problems/remove-k-digits/

		private static string RemoveKdigits(string num, int k)
		{
			int startIndex = 0;

			for (startIndex = 0; startIndex < k; startIndex++)
			{
				if (num[startIndex] == '0')
					--startIndex;
			}

			while(startIndex < num.Length && num[startIndex] == '0')
			{
				startIndex++;
			}

			string smallNum = num.Substring(startIndex);

			return smallNum;
		}
	}
}
