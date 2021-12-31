using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class WordSearchProblem
	{
		//solving this problem: https://leetcode.com/problems/word-search/
		public static void WordSearchTester()
		{
			List<char[]> boardList = new List<char[]>();
			boardList.Add(new char[] { 'A', 'B', 'C', 'E' });
			boardList.Add(new char[] { 'S', 'F', 'C', 'S' });
			boardList.Add(new char[] { 'A', 'D', 'E', 'E' });

			string inputWord = "ABCB";

			bool FoundWord = Exist(boardList.ToArray(), inputWord);
			Console.WriteLine(FoundWord);
		}


		public static string word;
		public static char[][] board;
		public static HashSet<int[]> usedPositions;
		public static bool Exist(char[][] ogBoard, string ogWord)
		{
			usedPositions = new HashSet<int[]>();
			word = ogWord;
			board = ogBoard;
			int[] curPos = {0,0};
			int curWordIndex = 0;
			int totalNumSquares = board.Length * board[0].Length;
			
			//iterate through the board trying to find the first letter
			while(totalNumSquares > 0)
			{
				//we found the first letter
				if(board[curPos[0]][curPos[1]] == word[curWordIndex])
				{
					AddPosToUsed(curPos);
					bool found = SearchAround(board, curPos, ++curWordIndex);
					if (found)
						return true;
					else
						usedPositions.Remove(curPos);
				}
				//that position didnt end up having a valid word
				curPos = NextSquare(curPos);
				--totalNumSquares;
			}

			return SearchAround(board, curPos, curWordIndex);

		}

		private static int[] NextSquare(int[] curPos)
		{
			int row = curPos[0];
			int col = curPos[1];

			++col;
			if (col >= board[0].Length)
			{
				col = 0;
				++row;
			}
			return new int[]{row, col};
		}

		private static void AddPosToUsed(int[] curPos)
		{
			usedPositions.Add(new int[] {curPos[0], curPos[1]});
		}

		private static bool SearchAround(char[][] board, int[] curPos, int curWordIndex)
		{
			//if we have passed the length of the word, that means we have found all the letters
			if (curWordIndex == word.Length)
				return true;


			//check right
			//make sure not already at edge
			if(curPos[1] < board[0].Length - 1)
			{
				if(!(usedPositions.Contains(new int[] { curPos[0], curPos[1] + 1 })) && board[curPos[0]][curPos[1] + 1] == word[curWordIndex])
				{
					++curPos[1];
					AddPosToUsed(curPos);
					bool found = SearchAround(board, curPos, ++curWordIndex);
					if (found)
						return true;
					else
						usedPositions.Remove(curPos);
				}
			}
			//check left
			//make sure not already at edge
			if (curPos[1] > 0)
			{
				if (!(usedPositions.Contains(new int[] { curPos[0], curPos[1] - 1 })) && board[curPos[0]][curPos[1] - 1] == word[curWordIndex])
				{
					--curPos[1];
					AddPosToUsed(curPos);
					bool found = SearchAround(board, curPos, ++curWordIndex);
					if (found)
						return true;
					else
						usedPositions.Remove(curPos);
				}
			}

			//check up
			//make sure not already at edge
			if (curPos[0] > 0)
			{
				if (!(usedPositions.Contains(new int[] { curPos[0] - 1, curPos[1] })) && board[curPos[0] - 1][curPos[1]] == word[curWordIndex])
				{
					--curPos[0];
					AddPosToUsed(curPos);
					bool found = SearchAround(board, curPos, ++curWordIndex);
					if (found)
						return true;
					else
						usedPositions.Remove(curPos);
				}
			}

			//check down
			//make sure not already at edge
			if (curPos[0] < board.Length - 1)
			{
				if (!(usedPositions.Contains(new int[] { curPos[0] + 1, curPos[1]})) && board[curPos[0] + 1][curPos[1]] == word[curWordIndex])
				{
					++curPos[0];
					AddPosToUsed(curPos);
					bool found = SearchAround(board, curPos, ++curWordIndex);
					if (found)
						return true;
					else
						usedPositions.Remove(curPos);
				}
			}

			return false;
		}

		//public static bool Exist_UsingIndexing(char[][] board, string word, int[] curPos, int curWordIndex)
		//{



		//}
	}
}
