using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
	internal class LongestValidParenthesesProblem
	{

		public static void Tester()
		{
			var s = ")()())";
			var result = LongestValidParentheses(s);
			Console.WriteLine(result);
		}

		private static int LongestValidParentheses(string s)
		{
			var stack = new Stack<int>();
			stack.Push(-1);
			var max = 0;
			for (var i = 0; i < s.Length; i++)
			{
				if (s[i] == '(')
				{
					stack.Push(i);
				}
				else
				{
					stack.Pop();
					if (stack.Count == 0)
					{
						stack.Push(i);
					}
					else
					{
						max = Math.Max(max, i - stack.Peek());
					}
				}
			}
			return max;
		}
	}
}
