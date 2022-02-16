using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class Search2DMatrixProblem
	{
		//solving this problem: https://leetcode.com/problems/search-a-2d-matrix/
		private static bool SearchMatrix(int[][] matrix, int target)
		{
			int width = matrix[0].Length;
			int height = matrix.Length;

			if(matrix[0][0] > target)
				return false;
			else if(matrix[height-1][width-1] < target) 
				return false;

			if(height == 1)
			{
				return Array.BinarySearch(matrix[0], target) >= 0;
			}

			if(width == 1)
			{
				return matrix.Select(x => x[0]).Where(y => y == target).Count() > 0;
			}


			for(int i = 0; i < height; ++i)
			{

				if(matrix[i][width-1] == target)
					return true;
				else if(matrix[i][width-1] > target)
				{
					return Array.BinarySearch(matrix[i], target) >= 0;
				}
			}
			return false;
		}




		//solving this problem: https://leetcode.com/problems/search-a-2d-matrix-ii/
		//private static bool SearchMatrix_2(int[][] matrix, int target)
		//{
		//	int width = matrix[0].Length;
		//	int height = matrix.Length;


		//	if (matrix[0][0] > target)
		//		return false;
		//	else if (matrix[height - 1][width - 1] < target)
		//		return false;

		//	if (height == 1)
		//	{
		//		return Array.BinarySearch(matrix[0], target) >= 0;
		//	}

		//	if (width == 1)
		//	{
		//		return matrix.Select(x => x[0]).Where(y => y == target).Count() > 0;
		//	}

		//	for(int row = 0; row < height; ++row)
		//	{
		//		if (matrix[row][0] > target)
		//			return false;
		//		else if (matrix[row][0] == target)
		//			return true;


		//		for(int col = 0; col < width; ++col)
		//		{
		//			if()
		//		}
		//	}
		//}
	}
}
