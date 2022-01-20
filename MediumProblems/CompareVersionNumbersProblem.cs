using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class CompareVersionNumbersProblem
	{
		//solving this problem: https://leetcode.com/problems/compare-version-numbers/

		public static int CompareVersion(string version1, string version2)
		{
			int[] v1Ints = version1.Split('.').Select(x => int.Parse(x)).ToArray();
			int[] v2Ints = version2.Split('.').Select(x => int.Parse(x)).ToArray();

			if(v1Ints.Length != v2Ints.Length)
			{
				if(v1Ints.Length < v2Ints.Length)
				{
					int[] newInts = new int[v2Ints.Length];
					Array.Copy(v1Ints, newInts, v1Ints.Length);
					v1Ints = newInts;
				}
				else
				{
					int[] newInts = new int[v1Ints.Length];
					Array.Copy(v2Ints, newInts, v2Ints.Length);
					v2Ints = newInts;
				}
			}
			//at this point, i have two arrays of equal length
			// and should be zero-padded

			for(int i = 0; i < v1Ints.Length; i++)
			{
				if (v1Ints[i] < v2Ints[i])
					return -1;
				else if(v1Ints[i] > v2Ints[i])
					return 1;
			}

			return 0;

		}
	}
}
