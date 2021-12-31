using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class FirstAndLastPositionProblem
	{
		//solving this problem: https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
		public static void SearchRangeTester()
		{

		}

		public static int[] SearchRange(int[] nums, int target)
		{
			List<int> numsList = new List<int>(nums);
			
			return new int[] { numsList.IndexOf(target), numsList.LastIndexOf(target)};


		}
	}
}
