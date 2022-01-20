using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class MaxScoreAfterSplittingProblem
	{
		//solving this problem: https://leetcode.com/problems/maximum-score-after-splitting-a-string/

		public static int MaxScore(string s)
		{
			int maxScore = int.MinValue;

			int leftScore = 0;

			if (s[0] == '0')
				leftScore = 1;

			int rightScore = 0;

			//get right score
			for(int i = 1; i < s.Length; i++)
			{
				if (s[i] == '1')
					rightScore++;
			}

			maxScore = Math.Max(maxScore, rightScore);
			//iterate through the string again getting max scores n stuff

			for(int i = 1; i < s.Length; i++)
			{
				if(s[i] == '1')
					rightScore--;
				else
					leftScore++;

				maxScore = Math.Max(maxScore, leftScore + rightScore);
			}

			return maxScore;
		}
	}
}
