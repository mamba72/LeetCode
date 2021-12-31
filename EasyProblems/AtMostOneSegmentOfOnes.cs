using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	class AtMostOneSegmentOfOnes
	{
		//solving this problem: https://leetcode.com/problems/check-if-binary-string-has-at-most-one-segment-of-ones/
		public static void Tester()
		{
			string testInput = "110";
			Console.WriteLine("Is One Segment: " + CheckOnesSegment(testInput));
		}

		public static bool CheckOnesSegment(string s)
		{
			//s0 is always a 1.

			//for(int i = 1; i < s.Length; ++i)
			//{

			//}


			//int intVal = s.Select(digit => int.Parse(digit.ToString())).ToArray().Sum();


			//int lastIndex = s.LastIndexOf('1');

			//string subStr = s.Substring(0, lastIndex);
			//int subStrSum = subStr.Select(digit => int.Parse(digit.ToString())).ToArray().Sum();

			//if (intVal == subStrSum)
			//	return true;
			//else
			//	return false;


			int firstZero = -1;
			int lastOne = -1;

			for(int i = 0; i < s.Length; ++i)
			{
				if (s[i].Equals('1'))
					lastOne = i;
				else if (firstZero != -1)
					firstZero = i;
			}

			if (lastOne > firstZero)
			{
				return false;
			}
			else
				return true;


		}
	}
}
