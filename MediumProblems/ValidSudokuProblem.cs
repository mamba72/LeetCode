using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeHelperFunctions;

namespace MediumProblems
{
	internal class ValidSudokuProblem
	{
		//solving this problem: https://leetcode.com/problems/valid-sudoku/
		public static void Tester()
		{
			char[][] board = InputReadingFuncts.ReadMassiveInput_2DArray_char("\\MassiveInputs\\SudokuBoards.txt");

			IsValidSudoku(board);
		}


		private static bool IsValidSudoku(char[][] board)
		{

			for(int i = 0 ; i < 9; i++)
			{
				if(CheckRow(board, i) == false)
					return false;
			}

			for(int i = 0; i < 9; i++)
			{
				if (CheckColumn(board, i) == false)
					return false;
			}

			for(int i = 0; i <= 6; i += 3)
			{
				for(int j = 0; j <= 6; j += 3)
				{
					if(CheckSquare(board, i, j) == false) return false;
				}
			}

			return true;
		}


		private static bool CheckSquare(char[][] board, int colStart, int rowStart)
		{
			short[] numOccur = new short[9];

			for(int col = colStart; col < colStart + 3; col++)
			{
				for(int row = rowStart; row < rowStart + 3; row++)
				{
					char theVal = (char)(board[col][row] - 49);
					if (theVal == 65533)//the char value for -3
						continue;
					else if (numOccur[theVal] == 0)
						numOccur[theVal]++;
					else
						return false;
				}
			}
			return true;
		}

		private static bool CheckRow(char[][] board, int columnNum)
		{
			short[] numOccur = new short[9];

			for (int i = 0; i < board[columnNum].Length; i++)
			{
				char theVal = (char)(board[columnNum][i] - 49);
				if (theVal == 65533)//the char value for -3
					continue;
				else if (numOccur[theVal] == 0)
					numOccur[theVal]++;
				else
					return false;
			}

			return true;
		}

		private static bool CheckColumn(char[][] board, int rowNum)
		{
			short[] numOccur = new short[9];

			for (int i = 0; i < board.Length; i++)
			{
				char theVal = (char)(board[i][rowNum] - 49);

				if (theVal == 65533)//the char value for -3
					continue;
				else if (numOccur[theVal] == 0)
					numOccur[theVal]++;
				else
					return false;
			}

			return true;
		}
	}
}
