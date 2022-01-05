using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class MaximumWealthProblem
	{
		//solving this problem:https://leetcode.com/problems/richest-customer-wealth/

		public static int MaximumWealth(int[][] accounts)
		{
			var vals = from account in accounts
					   select account.Sum();

			return vals.Max();
		}
	}
}
