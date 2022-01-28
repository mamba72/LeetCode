using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class CombinationsProblem
	{
		//solving this problem: https://leetcode.com/problems/combinations/

		public static IList<IList<int>> Combine(int n, int k)
		{
			LinkedList<List<int>> combos = new LinkedList<List<int>>();

			int[] prevNums = new int[k];

			for (int j = 0; j < k; j++)
			{
				List<int> list = new List<int>();
				for (int i = 0; i < n; i++)
				{
					

				}
			}

			

			return (IList<IList<int>>)combos.ToList();
		}
	}
}
