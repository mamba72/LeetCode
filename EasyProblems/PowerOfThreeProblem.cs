using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class PowerOfThreeProblem
	{
		//solving this problem: https://leetcode.com/problems/power-of-three/
		public static void Tester()
		{
			int n = 9;

			IsPowerOfThree(n);
		}

		private static bool IsPowerOfThree(int n)
		{
			if(n == 1 || n == -1) return true;
			if(n <= 0) return false;

			int power = 1;
			int absN;
			try
			{
				absN = Math.Abs(n);
			}catch(Exception)
			{
				return false;
			}
			 

			int cube;

			//this is the largest cube root with the cube fitting in int32
			while (power <= 19) 
			{
				cube = (int)Math.Pow(3, power);
				if(cube == absN)
					return true;

				if(cube > absN)
					return false;

				++power;
			}

			return false;
		}

		private static bool IsPowerOfFour(int n)
		{
			
			if (n <= 0) return false;
			if (n == 1) return true;

			int power = 1;

			int cube;

			//this is the largest cube root with the cube fitting in int32
			while (power <= 19)
			{
				cube = (int)Math.Pow(4, power);
				if (cube == n)
					return true;

				if (cube > n)
					return false;

				++power;
			}

			return false;
		}

		private static bool IsPowerOfTwo(int n)
		{

			if (n <= 0) return false;

			return (n & (n - 1)) == 0;
			//if (n == 1) return true;

			//int power = 1;

			//int cube;

			////this is the largest cube root with the cube fitting in int32
			//while (power <= 31)
			//{
			//	cube = (int)Math.Pow(2, power);
			//	if (cube == n)
			//		return true;

			//	if (cube > n)
			//		return false;

			//	++power;
			//}

			//return false;
		}
	}
}
