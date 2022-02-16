using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class ValidParenthesesProblem
	{
		//solving this problem: https://leetcode.com/problems/valid-parentheses/
		private static bool IsValid(string s)
		{
			

			for(int i = 0; i < s.Length; i++)
			{
				if(s[i] == s[i+1])
				{
					if(IsValid(s.Substring(i + 1)) == false)
					{
						return false;
					}
				}
				else if(s[i] == '(' && s[i+1] == ')')
				{
					return true;
				}
				else if (s[i] == '[' && s[i + 1] == ']')
				{
					return true;
				}
				else if (s[i] == '{' && s[i + 1] == '}')
				{
					return true;
				}
			}

			return false;
		}

		private static bool IsValid_Stack(string s)
		{
			Stack<char> brackets = new Stack<char>();

			try
			{
				foreach (char c in s)
				{
					if (c == '(' || c == '[' || c == '{')
					{
						brackets.Push(c);
					}
					else
					{
						switch (c)
						{
							case ')':
								if (brackets.Pop() != '(')
									return false;
								break;
							case ']':
								if (brackets.Pop() != '[')
									return false;
								break;
							case '}':
								if (brackets.Pop() != '{')
									return false;
								break;
						}
					}
				}
			}catch(InvalidOperationException)
			{
				return false;
			}
			

			return brackets.Count == 0;
		}
	}
}
