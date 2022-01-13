using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class MaxLengthOfPairChainProblem
	{
		//solving this problem: https://leetcode.com/problems/maximum-length-of-pair-chain/

		public static int FindLongestChain(int[][] pairs)
		{

			List<int[]> listPairs = new List<int[]>(pairs.OrderBy(x => x[0]));

			int prevRight = int.MinValue;
			


			while(listPairs.Count > 0)
			{

				var availablePairs = listPairs.Select(x => x).Where(x => x[0] > prevRight).Min();

				if(!availablePairs.Any())
                {
					break;
                }
				

			}


			return 0;
		}

		
	}
}
