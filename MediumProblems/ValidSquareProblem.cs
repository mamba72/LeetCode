using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class ValidSquareProblem
	{
		//solving this problem:https://leetcode.com/problems/valid-square/
		public static void ValidSquareTester()
		{
			ValidSquare(new int[]{ 0,0}, new int[] {1,1}, new int[] {1,0}, new int[] {0,1});
		}


		static Dictionary<double, short> sideLengths = new Dictionary<double, short>();
		public static bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4)
		{
			//check if there are 4 equal side lengths

			//get the distance between all the points
			Distance(p1, p2);
			Distance(p1, p3);
			Distance(p1, p4);
			Distance(p2, p3);
			Distance(p2, p4);
			Distance(p3, p4);
			//Distance();

			//there should only be two distances if its a square. the sides and disagonals.
			if(sideLengths.Keys.Count != 2)
			{
				return false;
			}
			foreach(var pair in sideLengths)
			{
				if (!(pair.Value != 4 && pair.Value != 2))
					return false;
			}






			return true;
		}

		public static double Distance(int[] p1, int[] p2)
		{
			double distance = Math.Sqrt(Math.Pow(p1[0] - p2[0], 2) + Math.Pow(p1[1] - p2[1], 2));
			if(sideLengths.ContainsKey(distance))
				sideLengths[distance]++;
			else
				sideLengths[distance] = 1;

			return distance;
		}

		//public static double GetAngle(double length1, double length2, double angle)
		//{

		//}
	}
}
