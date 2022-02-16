using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class SquareRootProblem
	{
		//solving this problem: https://leetcode.com/problems/sqrtx/
		public static void Tester()
		{
			int x = 89;
			x = int.MaxValue;
			MySqrt(x);
		}

		private static int MySqrt(int x)
		{
			//int counter = 0;

			//trying babylonean method
			if(x == 0)
				return 0;
			else if (x == 1)
				return 1;

			double guess = x / 2;
			double root;

			bool keepGuessing = true;
			while(keepGuessing)
			{
				root = x / guess;
				guess = (guess + root) / 2;

				if((int)guess == (int)root)
				{
					keepGuessing = false;
				}
				//counter++;
			}
			//Console.WriteLine(counter);
			return (int)guess;
		}
	}
}
