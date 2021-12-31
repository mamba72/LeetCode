using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	class IntegerToRomanProblem
	{
		//solving this problem: https://leetcode.com/problems/integer-to-roman/
		//got this answer from here: https://www.industrian.net/tutorials/converting-numbers-to-roman-numerals/
		public static void IntToRomanTester()
		{

		}

		public static string IntToRoman(int num)
		{
			//Dictionary<int, char> numeralKey = new Dictionary<int, char>();
			//numeralKey.Add(1, 'I');
			//numeralKey.Add(5, 'V');
			//numeralKey.Add(10, 'X');
			//numeralKey.Add(50, 'L');
			//numeralKey.Add(100, 'C');
			//numeralKey.Add(500, 'D');
			//numeralKey.Add(1000, 'M');

			string[] hundreds = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
			string[] tens = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
			string[] ones = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

			StringBuilder roman = new StringBuilder();

			for(int i = 0;  i < num / 1000; ++i)
			{
				roman.Append("M");
			}

			// Hundreds
			//Create an index for the above "hundreds" field by dividing the value by 100.
			int hundredsIndex = (num / 100);
			// Set hundredsIndex as the remainder of hundredsIndex divided by 10.
			hundredsIndex %= 10;
			// Add the value from hundreds using hundredsIndex.
			roman.Append( hundreds[hundredsIndex]);

			// Tens
			// Create an index for the above "tens" field by dividing the value by 10.
			int tensIndex = (num / 10);
			// Set tensIndex as the remainder of tensIndex divided by 10.
			tensIndex %= 10;
			// Add the value from tens using the tensIndex.
			roman.Append(tens[tensIndex]);

			// Ones
			//Create an index for the above "ones" field by getting the remainder of the value divided by 10.
			int onesIndex = (num % 10);
			// Add the value from ones using the onesIndex.
			roman.Append(ones[onesIndex]);

			return roman.ToString();
		}
	}
}
