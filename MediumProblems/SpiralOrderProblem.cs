using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class SpiralOrderProblem
	{
		//solving this problem: https://leetcode.com/problems/spiral-matrix/

		public static IList<int> SpiralOrder(int[][] matrix)
		{

			int rightMax = matrix[0].Length - 1;
			int leftMax = 0;
			int downMax = matrix.Length - 1;
			int upMax = downMax - 1;

			LinkedList<int> list = new LinkedList<int>();

			int[] nextPos = new int[2] { 0, 0 };


			while(list.Count < matrix.Length * matrix[0].Length)
			{
				//list.AddLast(matrix[nextPos[0]][nextPos[1]]);

				for(int x = 0; x < rightMax; x++)
				{

				}



			}


			return (IList<int>)list;
		}
	}
}
