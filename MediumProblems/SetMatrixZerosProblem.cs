using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class SetMatrixZerosProblem
	{
		//solving this problem: https://leetcode.com/problems/set-matrix-zeroes/
		private static void SetZeroes(int[][] matrix)
		{

			//List<int> skipRows = new List<int>();
			//List<int> skipCols = new List<int>();

			List<int[]> zeros = new List<int[]>();

			for(int i = 0; i < matrix.Length; i++)
			{
				for (int j = 0; j < matrix[0].Length; ++j)
				{
					if(matrix[i][j] == 0)
						zeros.Add(new int[] { i, j });
				}
			}

			foreach(int[] pos in zeros)
			{
				InsertZeros(ref matrix, pos[0], pos[1]);
			}


		}

		private static void InsertZeros(ref int[][] matrix, int row, int col)
		{

			for(int i = 0; i < matrix.Length; i++)
			{
				matrix[i][col] = 0;
			}

			for(int i = 0; i < matrix[0].Length; ++i)
			{
				matrix[row][i] = 0;
			}

		}
	}
}
