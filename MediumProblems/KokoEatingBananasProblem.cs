using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class KokoEatingBananasProblem
	{
		//solving this problem: https://leetcode.com/problems/koko-eating-bananas/
		public static void Tester()
		{
			int[] piles = new int[] { 3, 6, 7, 11 };
			int hours = 8;

			piles = new int[] { 30, 11, 23, 4, 20 };
			hours = 5;

			piles = new int[] { 4 };
			hours = 1;

			//piles = new int[] { 312884470 };
			//hours = 968709470;

			//piles = new int[] { 873375536, 395271806, 617254718, 970525912, 634754347, 824202576, 694181619, 20191396, 886462834, 442389139, 572655464, 438946009, 791566709, 776244944, 694340852, 419438893, 784015530, 588954527, 282060288, 269101141, 499386849, 846936808, 92389214, 385055341, 56742915, 803341674, 837907634, 728867715, 20958651, 167651719, 345626668, 701905050, 932332403, 572486583, 603363649, 967330688, 484233747, 859566856, 446838995, 375409782, 220949961, 72860128, 998899684, 615754807, 383344277, 36322529, 154308670, 335291837, 927055440, 28020467, 558059248, 999492426, 991026255, 30205761, 884639109, 61689648, 742973721, 395173120, 38459914, 705636911, 30019578, 968014413, 126489328, 738983100, 793184186, 871576545, 768870427, 955396670, 328003949, 786890382, 450361695, 994581348, 158169007, 309034664, 388541713, 142633427, 390169457, 161995664, 906356894, 379954831, 448138536 };
			//hours = 943223529;

			piles = new int[]{1000000000, 1000000000};
			hours = 3;

			MinEatingSpeed(piles, hours);
		}

		private static long TotalBananas = -1;

		public static int MinEatingSpeed(int[] piles, int h)
		{
			TotalBananas = SumArray(piles);
			int k = Math.Max((int)(TotalBananas / h) - 1, 0);
			bool ableToFinish = false;

			int increaseOffset = 10;

			//for(k = 1; k < piles.Length; ++k)
			while (ableToFinish == false)
			{
				k += increaseOffset;
				//++k;
				ableToFinish = CanFinishBananas(piles, h, k);	
			}

			for(int i = increaseOffset - 1; i > 0; --i)
			{
				if (CanFinishBananas(piles, h, k - i))
					return k - i;
			}
			
			
			return k;
			
		}

		private static bool CanFinishBananas(int[] piles, int h, int k)
		{

			if(TotalBananas / k > h)
				return false;

			//int curHour = 0;
			int hourDelta;

			int[] testPiles = new int[piles.Length];

			Array.Copy(piles, testPiles, testPiles.Length);

			int i = 0;
			while(i < piles.Length)
			//for(int i = 0; i < piles.Length; i++)
			{
				//testPiles[i] -= k;
				hourDelta = testPiles[i] / k;
				if (testPiles[i] % k != 0)
					++hourDelta;

				h -= hourDelta;

				++i;


				//if (testPiles[i] <= 0)
				//	++i;

				//++curHour;
				//--h;

				if (h < 0)
					return false;
			}

			return true;
		}

		private static long SumArray(int[] piles)
		{
			long sum = 0;
			foreach (int i in piles)
				sum += i;
			return sum;
		}
	}
}
