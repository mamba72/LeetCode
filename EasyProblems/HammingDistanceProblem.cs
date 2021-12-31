using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class HammingDistanceProblem
	{
		//solving this problem: https://leetcode.com/problems/hamming-distance/
		public static void HammingTester()
		{
			int input1 = 1;
			int input2 = 4;
			int diff = HammingDistance(input1, input2);
			Console.WriteLine(diff);
		}

		public static int HammingDistance(int x, int y)
		{
			string binX = Convert.ToString(x,2);
			string binY = Convert.ToString(y,2);

			ZeroExtendStrings(ref binX, ref binY);

			int diffCount = 0;
			for(int i = 0; i < binX.Length; i++)
			{
				if(binX[i] != binY[i])
					diffCount++;
			}

			return diffCount;
		}

		public static void ZeroExtendStrings(ref string binX, ref string binY)
		{
			if(binX.Length != binY.Length)
			{
				if(binX.Length < binY.Length)
				{
					binX = (new string('0', binY.Length - binX.Length)) + binX;
				}else
				{
					binY = (new string('0', binX.Length - binY.Length)) + binY;
				}
			}
		}
	}
}
