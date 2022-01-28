using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class EveryRowColumnContainsAllNumbersProblem
	{
		//solving this problem: https://leetcode.com/problems/check-if-every-row-and-column-contains-all-numbers/
		public static void Tester()
		{
			int[][] matrix = {new int[] {1,2,3},new int[]{3,1,2},new int[]{2,3,1} };
			CheckValid_AttemptTwo(matrix);
		}

		private static bool CheckValid(int[][] matrix)
		{
			int correctSum = CorrectVal(matrix.Length);

			//check the rows
			foreach(int[] row in matrix)
			{
				if(row.Sum() != correctSum)
					return false;
			}

			//check the columns
			for(int col = 0; col < matrix.Length; col++)
			{
				int curSum = matrix.Select(x => x[col]).Sum();
				if (curSum != correctSum)
					return false;
			}

			return true;
		}

		private static int CorrectVal(int n)
		{
			int sum = 0;

			for(int i = 1; i <= n; i++)
			{
				sum += i;
			}

			return sum;
		}

		private static bool CheckValid_AttemptTwo(int[][] matrix)
		{
			int[] neededNumbers = new int[matrix.Length];

			for(int i = 1; i <= matrix.Length; i++)
				neededNumbers[i - 1] = i;

			List<int> reqNum;
			//check the rows
			foreach (int[] row in matrix)
			{
				reqNum = new List<int>(neededNumbers);
				for(int col = 0;col < matrix.Length; col++)
				{
					if(reqNum.Remove(row[col]) == false)
						return false;
				}

				if (reqNum.Count != 0)
					return false;
			}

			//check columns
			for(int i = 0; i < matrix.Length; i++)
			{
				reqNum = new List<int>(neededNumbers);

				for(int j = 0; j < matrix.Length; j++)
				{
					if (reqNum.Remove(matrix[j][i]) == false)
						return false;
				}

				if (reqNum.Count != 0)
					return false;
			}

			return true;
		}


	}
}
