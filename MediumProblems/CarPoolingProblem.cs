using System;
using System.Collections.Generic;
using System.Linq;

namespace MediumProblems
{
	internal class CarPoolingProblem
	{
		//solving this problem: https://leetcode.com/problems/car-pooling/
		public static void CarPoolingTester()
		{
			int[][] tripsInput = new int[][] {new int[] { 2, 1, 5 }, new int[] { 3, 3, 7 } };
			Console.WriteLine(CarPooling_NetChangeSet(tripsInput, 4));
		}

		

		public static bool CarPooling_NetChangeSet(int[][] trips, int capacity)
		{
			Dictionary<int, int> stopChange = new Dictionary<int, int>();

			for(int i = 0; i < trips.Length; ++i)
			{
				if(stopChange.ContainsKey(trips[i][1]))
				{
					stopChange[trips[i][1]] += trips[i][0];
				}else
				{
					stopChange.Add(trips[i][1], trips[i][0]);
				}

				if (stopChange.ContainsKey(trips[i][2]))
				{
					stopChange[trips[i][2]] -= trips[i][0];
				}
				else
				{
					stopChange.Add(trips[i][2], -1 * trips[i][0]);
				}
			}

			int curCarPool = 0;

			int[] stopsSorted = stopChange.Keys.OrderBy(x => x).ToArray();

			foreach(int stop in stopsSorted)
			{
				curCarPool += stopChange[stop];
				if(curCarPool > capacity || curCarPool < 0)
					return false;
			}

			return true;
		}
	}
}
