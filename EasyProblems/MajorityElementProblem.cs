using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class MajorityElementProblem
	{
		//solving this problem: https://leetcode.com/problems/majority-element/
		private static int MajorityElement(int[] nums)
		{
			int neededAmount = nums.Length / 2;
			Dictionary<int, int> counts = new Dictionary<int, int>();

			foreach(int num in nums)
			{
				if (counts.ContainsKey(num))
					counts[num]++;
				else counts.Add(num, 1);

				if(counts[num] > neededAmount)
					return num;
			}

			return -1;
		}
	}
}
