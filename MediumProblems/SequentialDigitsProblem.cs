using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class SequentialDigitsProblem
	{
		//solving this problem: https://leetcode.com/problems/sequential-digits/
		public static void Tester()
		{
			int low = 100;
			int high = 300;

			low = 58;
			high = 155;

			low = 178546104;
			high = 812704742;


			low = 372591426;
			high = 841554424;

			low = 8511;
			high = 23553;

			SequentialDigits(low, high);
		}

		public static IList<int> SequentialDigits(int low, int high)
		{
			List<int> result = new List<int>();
			string lowStr = low.ToString();
			int firstDigitLow = int.Parse(lowStr[0].ToString());

			if(lowStr.Length == 9 && 123456789 < low)
				return result;

			List<int> curArray = new List<int>(lowStr.Length);//GetListOfVal(low);

			int lowStrLength = lowStr.Length;

			int nextDigit = firstDigitLow;

			short restartCounter = 0;
			//initialize first value
			for (int i = 0; i < lowStrLength; i++)
			{
				if (nextDigit != 9)
				{
					nextDigit = firstDigitLow + i;
					curArray.Add(nextDigit);
				}
				else if(restartCounter < 9)
				{
					restartCounter++;
					i = -1;
					curArray.Clear();

					if(firstDigitLow != 9)
					{
						firstDigitLow++;
						nextDigit = firstDigitLow;
					}
					else
					{
						lowStrLength++;
						firstDigitLow = 1;
						nextDigit = firstDigitLow;
					}

				}else
				{
					return result;
				}
			}//end for loop. Initial value has been assigned.

			int curInt = GetIntVal(curArray);

			if(curInt < low)
			{
				try
				{
					curArray = GetNextValue(curArray);
					curInt = GetIntVal(curArray);
				}catch(OverflowException)
				{
					return result;
				}
			}


			int prevInt = curInt;
			
			while(curInt <= high)
			{
				
				curArray = GetNextValue(curArray);

				try
				{
					curInt = GetIntVal(curArray);
					result.Add(prevInt);
					prevInt = curInt;
				}
				catch(OverflowException)
				{
					result.Add(prevInt);
					break;
				}
			}
			

			return result;
		}

		public static int GetIntVal(List<int> num)
		{
			return int.Parse(string.Join("", num));
			//int sum = 0;
			//int tensVal = 1;
			//for(int i = num.Count - 1; i >= 0; i--)
			//{
			//	sum = num[i] * (tensVal);
			//	tensVal *= 10;
			//}
			//return sum;
		}

		//public static List<int> GetListOfVal(int num)
		//{
		//	LinkedList<int> digits = new LinkedList<int>();

		//	while (num > 0)
		//	{
		//		digits.AddFirst(num % 10);
		//		num /= 10;
		//	}

		//	return digits.ToList();
		//}

		public static List<int> GetNextValue(List<int> num)
		{

			if (num[num.Count - 1] != 9)
			{
				num.RemoveAt(0);
				num.Add(num[num.Count - 1] + 1);
			}
			else //if theres a carryover
			{
				num = new List<int>(num.Count + 1);

				for(int i = 1; i <= num.Capacity; ++i)
				{
					num.Add(i);
				}
			}

			return num;

		}

		


	}
}
