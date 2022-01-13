using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
    internal class SubrectangleQueriesProblem
    {
        //solving this problem: https://leetcode.com/problems/subrectangle-queries/

        public class SubrectangleQueries
        {
            int[][] rectangle;

            public SubrectangleQueries(int[][] rectangle)
            {
                this.rectangle = rectangle;
            }

            public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
            {
                for (int row = row1; row <= row2; ++row)
                {
                    for (int col = col1; col <= col2; ++col)
                    {
                        rectangle[row][col] = newValue;
                    }
                }
            }

            public int GetValue(int row, int col)
            {
                return rectangle[row][col];
            }
        }
    }
}
