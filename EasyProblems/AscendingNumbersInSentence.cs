using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
    internal class AscendingNumbersInSentence
    {
        //solving this problem: https://leetcode.com/problems/check-if-numbers-are-ascending-in-a-sentence/
        public static void AscendingNumTester()
        {
            string inputString = "";
            bool output = AreNumbersAscending(inputString);
            Console.WriteLine(output);
        }

        public static bool AreNumbersAscending(string s)
        {
            string[] splitArr = s.Split(" ");

            int previousNum = int.MinValue;

            int curNum;

            for (int i = 0; i < splitArr.Length; i++)
            {
                if(int.TryParse(splitArr[i], out curNum))
                {
                    if (curNum <= previousNum)
                        return false;
                    previousNum = curNum;
                }
            }
            return true;
        }
    }
}
