using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
    internal class ZigZagConversionProblem
    {
        //solving this problem: https://leetcode.com/problems/zigzag-conversion/
        public static void ZigZagTester()
        {
            string testInput = "Paypalishiringcoolandfun";
            int numRows = 9;
            Console.WriteLine(testInput.Length);
        }

        public static string Convert_Array(string s, int numRows)
        {
            int numColumns = s.Length / numRows;
            if(numRows * numRows < numColumns)
                numColumns++;

            char[,] array = new char[numColumns, numRows];

            int curRow = 0;//numRows;
            int curCol = 0;//numColumns;
            bool isZig = true;

            for(int i = 0; i < s.Length; i++)
            {
                array[curCol, curRow] = s[i];

                //isZig means vertical
                if(isZig)
                {
                    curRow++;
                    if(curRow >= numRows)
                        isZig = false;
                }
                else//diagonal
                {
                    curCol++;
                    curRow--;
                    //reverse
                    if (curRow < 0)
                        isZig = true;
                }
            }




            //now convert the array to the string
            string outputStr = "";
            for(int i = 0; i < numRows; ++i)
            {
                for(int j = 0; j < numColumns; ++j)
                {
                    if(Char.IsLetter(array[j, i]))
                        outputStr += array[j, i];
                }
            }

            return outputStr;

        }


        //private static void PrintArray(char[,] array)
        //{
        //    for(int i =0; i<array.Length; i++)
        //    {
        //        for(int j = 0; j < array.GetValue(i).Length; j++)
        //        {
        //            Console.Write(array.GetValue(j,i));
        //        }

        //    }
        //}

        public static string Convert_ArshiasWay(string s, int numRows)
        {
            string outputStr = "";

            int curRow = numRows;

            for (int i = 0; i < s.Length; i++)
            {
                
                outputStr += s[numRows - curRow];

            }

            return outputStr;
        }

    }
}
