using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	//solving this problem: https://leetcode.com/problems/roman-to-integer/
	class RomanToIntegerProblem
	{
		public static void RomanToIntTester()
		{
			string testCase = "MCMXCIV".ToUpper();
			Console.WriteLine("Int Version: " + RomanToInt(testCase));
		}

		public static int RomanToInt(string s)
		{
			//my thoughts are to go backwards so then I don't have to look forward.
			//make an array and put in the numerical values and then can just do Array.Sum()

			Dictionary<char, int> numeralKey = new Dictionary<char, int>();
			numeralKey.Add('I', 1);
			numeralKey.Add('V', 5);
			numeralKey.Add('X', 10);
			numeralKey.Add('L', 50);
			numeralKey.Add('C', 100);
			numeralKey.Add('D', 500);
			numeralKey.Add('M', 1000);

			//int[] integers = new int[s.Length];
			int runingTotal = 0;

			bool isNegative = false;
			int prevNum = 0;

			for(int i = s.Length - 1; i >= 0; --i)
			{
				int curNum = numeralKey[s[i]];
				//handle the times when IX = 10-1
				if(curNum < prevNum)
				{
					isNegative = true;
				}
				//handle the case when we go from a smaller number to a bigger number,
				//like CIV, we are going from the I to the C
				else if(curNum > prevNum)
				{
					isNegative = false;
				}

				if (isNegative)
					runingTotal -= curNum;
				else
					runingTotal += curNum;

				prevNum = curNum;
			}

			return runingTotal;
		}
	}
}
