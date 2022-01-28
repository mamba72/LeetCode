using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeHelperFunctions;


namespace MediumProblems
{
	internal class NumInterchangeableRectanglesProblem
	{
		//solving this problem: https://leetcode.com/problems/number-of-pairs-of-interchangeable-rectangles/
		public static void InterchangeableRectsTester()
		{
			int[][] input = new int[][] { new int[] { 4, 5 }, new int[] { 7, 8 } };
			Console.WriteLine(InterchangeableRectangles_Dictionary(input));

			input = new int[][] { new int[]{4, 8}, new int[] { 3, 6}, new int[] { 10, 20}, new int[] { 15, 30} };
			Console.WriteLine(InterchangeableRectangles_Dictionary(input));


			input = InputReadingFuncts.ReadMassiveInput_2DArray_int("InterchangeableRectangles_Massive2DArray.txt");
			Console.WriteLine(InterchangeableRectangles_Dictionary(input));


			//input = new int[][] { new int[] { 4, 5 }, new int[] { 7, 8 } };
			//Console.WriteLine(InterchangeableRectangles(input));

			//input = new int[][] { new int[] { 4, 8 }, new int[] { 3, 6 }, new int[] { 10, 20 }, new int[] { 15, 30 } };
			//Console.WriteLine(InterchangeableRectangles(input));


			//input = InputReadingFuncts.ReadMassiveInput_2DArray("InterchangeableRectangles_Massive2DArray.txt");
			//Console.WriteLine(InterchangeableRectangles(input));
		}

		public static long InterchangeableRectangles(int[][] rectangles)
		{
			long count = 0;

			//Dictionary<int, float> rectRatio = new Dictionary<int, float>();
			decimal[] rectRatio = new decimal[rectangles.Length];

			for(int i = 0; i < rectangles.Length; i++)
			{
				rectRatio[i] = rectangles[i][0] / (decimal)rectangles[i][1];
			}

			for(int i = 0; i < rectangles.Length - 1; i++)
			{
				for(int j = i + 1; j < rectangles.Length; j++)
				{
					if(rectRatio[i] == rectRatio[j])
						count++;
				}
			}

			return count;
		}

		public static long InterchangeableRectangles_Dictionary(int[][] rectangles)
		{
			long count = 0;
			
			Dictionary<double, long> rectRatio = new Dictionary<double, long>();
			//float[] rectRatio = new float[rectangles.Length];
			double ratio;
			for (int i = 0; i < rectangles.Length; i++)
			{
				ratio = rectangles[i][0] / (double)rectangles[i][1];

				if(rectRatio.ContainsKey(ratio))
				{
					count += rectRatio[ratio];
					rectRatio[ratio]++;
				}
				else
					rectRatio.Add(ratio, 1);
			}

			//foreach (var pair in rectRatio)
			//{
			//	//count += pair.Value * 2;

			//	count += (pair.Value * (pair.Value - 1)) / 2;
			//}

			return count;
		}
	}
}
