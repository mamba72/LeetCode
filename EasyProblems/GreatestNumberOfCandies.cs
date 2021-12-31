using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	class GreatestNumberOfCandies
	{
		//I am solving this problem:https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/


		public static void GreatestNumberOfCandies_Tester()
		{

		}

		
		public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
		{
			bool[] result = new bool[candies.Length];

			int max = candies.Max();

			for(int i = 0; i < candies.Length; ++i)
			{
				if(candies[i] + extraCandies >= max)
				{
					result[i] = true;
				}
			}

			return result;
		}
	}
}
