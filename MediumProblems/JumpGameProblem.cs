using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
    internal class JumpGameProblem
    {
        //solving this problem: https://leetcode.com/problems/jump-game/
        public static void JumpGameTester()
        {
            int[] input = { 3,2,1,0,4};
            CanJump_Iterative(input);
        }

        public static bool CanJump_Skipper(int[] nums)
        {
            int curIndex = 0;
            int nextIndex = 0;
            int nextStep;
            while (curIndex < nums.Length)
            {
                nextStep = nums[curIndex];
                if (nextStep == 0)

                    nextIndex = +curIndex;


                if (nextIndex == curIndex)
                    break;

                curIndex = nextIndex;

            }

            if (curIndex >= nums.Length)
                return true;
            else
                return false;
        }

        public static bool CanJump_Iterative(int[] nums)
        {
            //int curIndex = 0;
            int maxReachIndex = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if(i > maxReachIndex)
                    return false;

                maxReachIndex = Math.Max(maxReachIndex, nums[i] + i);


            }

            return true;
        }
    }
}
