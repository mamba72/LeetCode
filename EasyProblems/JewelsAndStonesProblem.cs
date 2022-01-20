using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class JewelsAndStonesProblem
	{
		//solving this problem: https://leetcode.com/problems/jewels-and-stones/

		public static int NumJewelsInStones(string jewels, string stones)
		{
			int count = 0;

			Dictionary<char, int> stonesCount = new Dictionary<char, int>();

			for(int i = 0; i < stones.Length; i++)
			{
				if(stonesCount.ContainsKey(stones[i]))
					stonesCount[stones[i]]++;
				else
					stonesCount.Add(stones[i], 1);
			}

			for(int i = 0; i < jewels.Length; i++)
			{
				int numStones;

				if(stonesCount.TryGetValue(jewels[i], out numStones))
					count+= numStones;
			}
			
			return count;
		}
	}
}
