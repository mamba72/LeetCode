using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class GrayCodeProblem
	{
		//solving this problem: https://leetcode.com/problems/gray-code/
		public static void Tester()
		{
			int n = 3;
			GrayCode(n);
		}
		private static IList<int> GrayCode(int n)
		{
			if (n == 1)
				return new List<int>(new int[] { 0, 1 });

			List<string> l1 = new List<string>(new string[] { "0", "1" });
			

			List<string> l2;
			for(int i = 1; i < n; i++)
			{
				l2 = new List<string>();
				//prefix all with one
				for (int i2 = l1.Count - 1; i2 >= 0; --i2)
				{
					l2.Add("1" + l1[i2]);
				}

				//prefix all with zero
				for (int i1 = 0; i1 < l1.Count; i1++)
				{
					l1[i1] = "0" + l1[i1];
				}

				

				l1.AddRange(l2);
			}

			List<int> result = new List<int>();

			foreach(string num in l1)
			{
				result.Add(Convert.ToInt32(num, 2));
			}

			//Convert.ToInt32(num,2);
			return result;
		}
	}
}
