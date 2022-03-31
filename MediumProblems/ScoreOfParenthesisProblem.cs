using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class ScoreOfParenthesisProblem
	{
		//solving this problem: https://leetcode.com/problems/score-of-parentheses/
		public static void Tester()
		{
			string input = "(()(()))";

			Console.WriteLine(ScoreOfParentheses(input));
		}
		
		private static int ScoreOfParentheses(string s)
		{
			Stack<int> stack = new Stack<int>();
			stack.Push(0);

			for(int i = 0; i < s.Length; i++)
			{
				if(s[i] == '(')
						stack.Push(0);
				else
				{
					int temp = stack.Pop();
					if (temp == 0)
						stack.Push(stack.Pop() + 1);
					else
						stack.Push(stack.Pop() + 2 * temp);
				}
			}

			int sum = stack.Sum();

			return sum;
		}

		//private int ScoreParenRecursive(Stack<char> stack, int index, string s)
		//{
			
		//	switch(stack.Peek())
		//	{ 
		//		case '(':
		//			if(s[index] == ')')
		//			{
		//				stack.Pop();
		//				stack.Push('A');
		//			}
		//			else
		//			{
		//				stack.Push(s[index]);
		//			}
		//			break;
		//		case ')':


		//			break;
		//		case 'A':
		//			break;
		//	}
		//}
	}
}
