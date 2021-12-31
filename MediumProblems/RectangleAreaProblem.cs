using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace MediumProblems
{
	internal class RectangleAreaProblem
	{
		//solving this problem: https://leetcode.com/problems/rectangle-area/
		public static void ComputeAreaTester()
		{

			Console.WriteLine("Area: " + ComputeArea(-3, 0, 3, 4, 0, -1, 9, 2));

		}

		public static int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
		{
			Rectangle rect1 = new Rectangle(ax1,ay1, ax2,ay2);
			Rectangle rect2 = new Rectangle(bx1, by1, bx2, by2);

			int totalArea = 0;

			//Console.WriteLine("Is in rectangle: " + IsPointInside(rect1.bottomRight, rect2));

			//Rectangle areaRect = new Rectangle();

			//check all the sides of one rectangle if they're inside the other
			//if(IsPointInside(rect1.topLeft, rect2))
			//{
			//	areaRect.topLeft = rect1.topLeft;
			//}

			int intersectionArea = Max(0, Min(ax2, bx2) - Max(ax1, bx1)) * Max(0, Min(ay2, by2) - Max(ay1, by1));
			//SI =				   Max(0, Min(XA2, XB2) - Max(XA1, XB1)) * Max(0, Min(YA2, YB2) - Max(YA1, YB1))

			totalArea = rect1.Area + rect2.Area - intersectionArea;

			return totalArea;
		}

		


		//public static bool IsPointInside(int[] point, Rectangle rect)
		//{
		//	int[] vectAM = GetVector(rect.topLeft, point);
		//	int[] vectAB = GetVector(rect.topLeft, rect.topRight);
		//	int[] vectAD = GetVector(rect.topLeft, rect.bottomLeft);

		//	int dotAMAB = DotProduct(vectAM, vectAB);
		//	int dotAMAD = DotProduct(vectAM, vectAD);

		//	if(dotAMAB > 0 && dotAMAD > 0)
		//	{
		//		if(dotAMAB < DotProduct(vectAB, vectAB) && dotAMAD < DotProduct(vectAD, vectAD))
		//		{
		//			return true;
		//		}
		//	}
		//	return false;
		//}

		//public static int DotProduct(int[] point1, int[] point2)
		//{
		//	return (point1[0] * point2[0]) + (point1[1] * point2[1]);
		//}

		//public static int[] GetVector(int[] point1, int[] point2)
		//{
		//	return new int[] { point1[0] - point2[0], point1[1] - point2[1] };

		//}

		public struct Rectangle
		{
			//public int[] bottomLeft;
			//public int[] bottomRight;
			//public int[] topLeft;
			//public int[] topRight;
			public int Width;
			public int Height;
			public int Area;

			public Rectangle(int x1,int y1, int x2, int y2)
			{
				//bottomLeft = new int[] {x1,y1};
				//topRight = new int[] {x2,y2};
				//topLeft = new int[] { x1, y2 };
				//bottomRight = new int[] { x2, y1 };

				Width = x2 - x1;
				Height = y2 - y1;
				Area = Width * Height;
			}
		}
	}
}
