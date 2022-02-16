using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class MinStackProblem
	{
		//solving this problem: https://leetcode.com/problems/min-stack/
		public class MinStack
		{

			List<int> stack;
			int min = int.MaxValue;

			public MinStack()
			{
				stack = new List<int>();
			}

			public void Push(int val)
			{
				stack.Add(val);
				if(val < min)
					min = val;
			}

			public void Pop()
			{
				int removed = stack[stack.Count - 1];
				stack.RemoveAt(stack.Count - 1);
				if (removed == min)
					min = stack.Min();
				
			}

			public int Top()
			{
				return stack[stack.Count - 1];
			}

			public int GetMin()
			{
				return min;
			}
		}

	}
}
