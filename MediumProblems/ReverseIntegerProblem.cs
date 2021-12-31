using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
    internal class ReverseIntegerProblem
    {
        //solving this problem: https://leetcode.com/problems/reverse-integer/
        public static void ReverseIntegerTester()
        {
            int testInput = 123;
            int testOutput = Reverse(testInput);
            Console.WriteLine(testOutput);
        }

        public static int Reverse(int x)
        {
            if(x == int.MinValue)
                return 0;

            bool isNegative = false;
            if(x < 0)
            {
                isNegative = true;
                x *= -1;
            }

            char[] tempChar = x.ToString().ToCharArray();
            Array.Reverse(tempChar);
            string reversed = new string(tempChar);

            bool canParse = int.TryParse(reversed, out x);

            if(canParse)
            {
                if (isNegative)
                    return x * -1;
                else
                    return x;
            }
            else
            {
                return 0;
            }

        }
    }
}
