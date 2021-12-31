using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
	class NumberToEnglishWordsProblem
	{
		//solving this problem: https://leetcode.com/problems/integer-to-english-words/
		public static void NumberToWordsTester()
		{
			int num = 123456;
			Console.WriteLine("Number: " + NumberToWords(num));
		}

		public static string NumberToWords(int num)
		{
			if (num == 0)
				return "Zero";

			//StringBuilder words = new StringBuilder();
			List<string> words = new List<string>();

			string[] onesWords = { "", "One", "Two", "Three", "Four","Five","Six","Seven","Eight","Nine"};
			string[] tensWords = { "", "Ten", "Twenty","Thirty","Forty","Fifty","Sixty","Seventy","Eighty","Ninety" };
			string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen","Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Nineteen" };
			string[] magnitiudes = { "", "Thousand", "Million", "Billion", "Trillion", "Quadrillion" };

			//divide the number in to chunks of 3
			int[] intArray = getChunks(num); //digitArr2(num);


			//iterate through those chunks of three from left to right
			for(int i = 0; i < intArray.Length; ++i)
			{
				//if the chunk is just zeros, skip it
				if(intArray[i] == 0)
					continue;

				int hundreds = 0;
				if(intArray[i] >= 100)
					hundreds = intArray[i]/100 % 10;

				//remove the hundreds place
				if (hundreds > 0)
				{
					words.Add(onesWords[hundreds] + " Hundred");
					intArray[i] -= hundreds * 100;
				}
				//check if its between 10 and 19, inclusive
				if(intArray[i] <= 19 && intArray[i] >= 10)
				{
					words.Add(teens[intArray[i] - 10]);
				}
				else //otherwise, do the normal with tens and ones
				{
					if(intArray[i] >= 10)
					{
						int tensIndex = intArray[i] / 10 % 10;
						if (tensIndex != 0)
						{
							words.Add(tensWords[tensIndex]);
							intArray[i] -= (intArray[i] / 10 % 10) * 10;
						}
							
					}
					if(intArray[i] != 0)
						words.Add(onesWords[intArray[i]]);
				}

				words.Add(magnitiudes[intArray.Length - i - 1]);
			}

			
			return String.Join(" ", words).Trim();
		}

		//take the advice from the first hint and break it into chunks of three
		public static int[] getChunks(int num)
		{
			string numStr = num.ToString();
			int[] arr = new int[(int)Math.Ceiling((float)(numStr.Length) / 3f)];

			int startingPoint = numStr.Length % 3;

			if (startingPoint != 0)
				arr[0] = int.Parse(numStr.Substring(0, numStr.Length % 3));
			else
			{
				arr[0] = int.Parse(numStr.Substring(0, 3));
				startingPoint = 3;
			}
				
			

			//iterate through array adding string
			for (int i = 1; i < arr.Length; ++i)
			{
				arr[i] = int.Parse(numStr.Substring(startingPoint + (3*(i-1)), 3));
			}

			return arr;
		}

		public static int numDigits(int n)
		{
			if (n < 0)
			{
				n = (n == Int32.MinValue) ? Int32.MaxValue : -n;
			}
			if (n < 10) return 1;
			if (n < 100) return 2;
			if (n < 1000) return 3;
			if (n < 10000) return 4;
			if (n < 100000) return 5;
			if (n < 1000000) return 6;
			if (n < 10000000) return 7;
			if (n < 100000000) return 8;
			if (n < 1000000000) return 9;
			return 10;
		}

		public static int[] digitArr2(int n)
		{
			var result = new int[numDigits(n)];
			for (int i = result.Length - 1; i >= 0; i--)
			{
				result[i] = n % 10;
				n /= 10;
			}
			return result;
		}

	}
}
