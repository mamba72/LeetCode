using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	class TwoSum_SortedArray
	{
        public static bool TwoSumSortedTester()
		{
            int[] testInput = new int[] { -3, 4, 3, 90 };
            int target = 0;
            int[] expectedOutput = new int[] { 0, 2 };

            //Console.WriteLine("Test Input: " + testInput.ToString());
            Console.WriteLine("Input: " + String.Join(", ", testInput));
            Console.WriteLine("Target: " + target);
            int[] output = TwoSumSortedArray(testInput, target);

            //Console.WriteLine("Output: " + output.ToString());
            Console.WriteLine("Output: " + String.Join(", ", output));
            Console.WriteLine("Expected Output: " + String.Join(", ", expectedOutput));
            if (Array.Equals(output, expectedOutput))
                return true;
            else 
                return false;
            
        }
        public static int[] TwoSumSortedArray(int[] nums, int target)
        {

            int[] answers = new int[] { -1, -1 };

            for (int i = 0; i < nums.Length; ++i)
            {
                int num1 = nums[i];
                //skip whatever is greater than the target
                //if (num1 <= target)
                //{

                //iterate through the rest of the numbers
                for (int j = i + 1; j < nums.Length; ++j)
                {
                    int num2 = nums[j];
                    //if (num2 <= target)
                    //{
                    if (num1 + num2 == target)
                    {
                        answers[0] = i;
                        answers[1] = j;
                        return answers;
                    }
                    //}

                }
                //}
            }
            return answers;
        }
    }
}
