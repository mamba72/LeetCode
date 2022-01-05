using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class ComplimentOfIntegerProblem
	{
		//solving this problem: https://leetcode.com/problems/complement-of-base-10-integer/
		public static void BitwiseComplimentTester()
		{
			int input = 100000;
			Console.WriteLine(BitwiseCompliment_CharBased(input));
		}

		public static int BitwiseCompliment(int n)
		{
			if(n == 0)
				return 0;

			string s = Convert.ToString(n, 2); //Convert to binary in a string
			
			int[] bits = s.PadLeft(8, '0') // Add 0's from left
						 .Select(c => int.Parse(c.ToString())) // convert each char to int
						 .ToArray(); // Convert IEnumerable from select to Array
			
			int firstIndex = bits.ToList().FindIndex(bit => bit == 1);

			//b = b.Not();

			int sum = 0;
			//int position = 0;
			for(int i = bits.Length - 1; i > firstIndex; i--)
			{

				if (bits[i] == 0)
				{
					sum += (int)Math.Pow(2,bits.Length - 1 - i);
				}

				//position++;
			}

			

			

			//BitArray notB = b.Not();

			//int[] results = new int[1];
			//notB.CopyTo(results, 0);
			//return results[0];

			//string bitsStr = Convert.ToString(n, 2);

			return sum;
		}

		public static int BitwiseCompliment_CharBased(int n)
		{
			if (n == 0)
				return 1;

			string bits = Convert.ToString(n, 2); //Convert to binary in a string
			int sum = 0;
			//int position = 0;
			for (int i = bits.Length - 1; i >= 0 ; --i)
			{
				if (bits[i].Equals('0'))
				{
					sum += (int)Math.Pow(2, bits.Length - 1 - i);
				}
			}

			return sum;
		}
	}
}
