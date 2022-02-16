using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class IsPerfectSquareProblem
	{
		//solving this problem: https://leetcode.com/problems/valid-perfect-square/
		public static void Tester()
		{
			int num = 2000105819;
			IsPerfectSquare(num);
		}
		private static bool IsPerfectSquare(int num)
		{
			if(num == 1)
				return true;

			int root = num;
			int minRoot = num - 1;

			int square;
			while(true)//change this
			{
				//prevRoot = root;
				//root = num / 2;
				square = (int)Math.Pow(root, 2);

				if (square == num)
					return true;
				else if (square > num)
				{
					root = root / 2;
					if(root < minRoot)
						minRoot = root;
					else if(root == minRoot)
					{
						return false;
					}
				}
				else
					root++;
			}
			return false;
		}
	}
}
