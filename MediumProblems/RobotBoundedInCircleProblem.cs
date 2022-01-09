using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class RobotBoundedInCircleProblem
	{
		//solving this problem: https://leetcode.com/problems/robot-bounded-in-circle/
		public static void BoundedRobotTester()
		{
			string instructions = "GRRRR";

			Console.WriteLine(IsRobotBounded(instructions));
		}

		public static bool IsRobotBounded(string instructions)
		{

			int[] deltaVector = VectorChange(instructions);

			if (deltaVector[0] == 0 && deltaVector[1] == 0)
				return true;
			else if (deltaVector[2] != 90)
				return true;
			else
				return false;

		}

		private static int[] VectorChange(string instructions)
		{
			//								  x, y, angle
			//int[] initialPoint = new int[3] { 0, 0, 90 };
			int[] curVector = new int[3] { 0, 0, 90 };

			foreach(char letter in instructions)
			{
				switch(letter)
				{
					case 'G':
						curVector = GoForward(curVector);
						break;
					case 'L':
						curVector[2] = (curVector[2] + 90) % 360; 
						break;

					case 'R':
						curVector[2] = (curVector[2] - 90) % 360;
						if(curVector[2] < 0)
							curVector[2] = 360 + curVector[2];
						break;

					default:
						break;
				}
			}

			return curVector;
		}

		private static int[] GoForward(int[] curVector)
		{
			switch(curVector[2])
			{
				case 0:
					curVector[0]++;
					return curVector;
				case 90:
					curVector[1]++;
					return curVector;
				case 180:
					curVector[0]--;
					return curVector;
				case 270:
					curVector[1]--;
					return curVector;

				default:
					return curVector;

			}
		}
	}
}
