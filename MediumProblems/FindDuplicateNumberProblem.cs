using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeHelperFunctions;

namespace MediumProblems
{
	internal class FindDuplicateNumberProblem
	{
		//solving this problem: https://leetcode.com/problems/find-the-duplicate-number/
		public static void Tester()
		{
			int[] input = InputReadingFuncts.ReadMassiveInput_Array("\\MassiveInputs\\DuplicateNumberInput.txt");
			Console.WriteLine(FindDuplicate_ParallelBruteForce(input));
		}

		public static int FindDuplicate(int[] nums)
		{
			int[] numCount = new int[nums.Length + 1];

			for(int i = 0; i < nums.Length; i++)
			{
				if(numCount[nums[i]] != 0)
					return nums[i];
				else
					numCount[nums[i]]++;
			}



			return -1;
		}




		private static int FindDuplicate_BruteForceConstantSpace(int[] nums)
		{
			int curInt;
			for(int i = 0; i < nums.Length; i++)
			{
				curInt = nums[i];

				for(int j = i + 1; j < nums.Length; j++)
				{
					if (curInt == nums[j])
						return curInt;
				}
			}

			return 0;
		}

		private static int FindDuplicate_ParallelBruteForce(int[] nums)
		{
			int duplicate = -1;

			Parallel.For(0, nums.Length, i => 
			{ 
				for(int j = i + 1; j < nums.Length; j++)
				{
					if (nums[j] == nums[i])
					{
						duplicate = nums[i];
						break;
					}
					else if (duplicate != -1)
						break;
				}
			});

			return duplicate;
		}
	}
}
