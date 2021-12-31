using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	class ThreeSum
	{
		//solving this problem: https://leetcode.com/problems/3sum/
		public static void ThreeSumTester()
		{
			int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };

			ThreeSumFunct(nums);
		}

		public static IList<IList<int>> ThreeSumFunct(int[] nums)
		{
			List<IList<int>> endingList = new List<IList<int>>();
			HashSet<HashSet<int>> endingHash = new HashSet<HashSet<int>>();

			for(int i = 0; i < nums.Length; ++i)
			{
				for(int j = i + 1; j < nums.Length; ++j )
				{
					for(int k = j + 1; k < nums.Length; ++k)
					{
						if (nums[i] + nums[j] + nums[k] == 0)
						{
							HashSet<int> midSet = new HashSet<int>(new int[] { nums[i], nums[j], nums[k] });
							if (!endingHash.Contains(midSet))
							{
								endingList.Add(new List<int>(new int[] { nums[i], nums[j], nums[k] }));
								endingHash.Add(new HashSet<int>(new int[] { nums[i], nums[j], nums[k] }));
							}
						}
							
					}
				}
			}

			return endingList;
		}
	}
}
