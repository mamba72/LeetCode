using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class RandomPointOnCircleProblem
	{
		//solving this problem:https://leetcode.com/problems/generate-random-point-in-a-circle/
		//this problem was bullshit. no clue how they check if its right
		public class Solution
		{
			public double rad;
			public double x;
			public double y;
			Random rand;
			public Solution(double radius, double x_center, double y_center)
			{
				rand = new Random(DateTime.Now.Second);
				//equation for circle: x^2 + y^2 = r^2
				rad = radius;
				x = x_center;
				y = y_center;
			}

			public double[] RandPoint()
			{
				
				double angle = rand.NextDouble() * 360 * Math.PI / 180;

				int distance = rand.Next((int)rad);

				double randX = Math.Cos(angle) * distance;
				double randY = Math.Sin(angle) * distance;

				


				return new double[] { randX + x, randY + y};
			}
		}
	}
}
