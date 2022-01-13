using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class VariableAfterOperationsProblem
	{
		//solving this problem: https://leetcode.com/problems/final-value-of-variable-after-performing-operations/

		public static int FinalValueAfterOperations(string[] operations)
		{
			int x = 0;

			foreach (string operation in operations)
			{
				if (operation[2] == '+' || operation[0] == '+')
				{
					x++;
				}
				else
				{
					x--;
				}
			}
			return x;
		}
	}
}
