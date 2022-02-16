using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeHelperFunctions;

namespace EasyProblems
{
	internal class BestTimeToBuyAndSellStockProblem
	{
		//solving this problem: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
		public static void Tester()
		{
			int[] prices = InputReadingFuncts.ReadMassiveInput_Array("\\MassiveInputs\\StockPrices.txt");
			int profit = MaxProfit_Attempt2Faster(prices);
			Console.WriteLine(profit);
		}

		private static int MaxProfit(int[] prices)
		{
			int max = 0;

			for(int buy = 0; buy < prices.Length - 1; ++buy)
			{
				int profit;
				int buyPrice = prices[buy];
				for(int sell = buy + 1; sell < prices.Length; ++sell)
				{
					profit = prices[sell] - buyPrice;
					if(profit > max)
						max = profit;
				}
			}
			return max;
		}

		private static int MaxProfit_Attempt2Faster(int[] prices)
		{
			int maxProfit = 0, minPrice = prices[0];

			foreach(int price in prices)
			{
				if (price < minPrice)
					minPrice = price;

				int profit = price - minPrice;

				if (profit > maxProfit)
					maxProfit = profit;
			}

			return maxProfit;

		}
	}
}
