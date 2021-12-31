using System;

namespace TwoSums
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
            int[] testInput = new int[] { -3, 4, 3, 90 };
            int target = 0;

            //Console.WriteLine("Test Input: " + testInput.ToString());
            Console.WriteLine("Input: " + String.Join(", ", testInput));
            Console.WriteLine("Target: " + target);
            int[] output = TwoSum(testInput, target);

            //Console.WriteLine("Output: " + output.ToString());
            Console.WriteLine("Output: " + String.Join(", ", output));
		}

        public static int[] TwoSum(int[] nums, int target)
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
