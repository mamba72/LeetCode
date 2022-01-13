using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class AddBinaryProblem
	{
		//solving this problem: https://leetcode.com/problems/add-binary/
		public static void AddBinaryTester()
		{
			string input1 = "11";
			string input2 = "1";

			Console.WriteLine(AddBinary(input1,input2));
		}

		public static string AddBinary(string a, string b)
		{
			a = new string( a.Reverse().ToArray());
			b = new string( b.Reverse().ToArray());


			string EndBinary = "";
			bool carry = false;
			char tempChar;

			//int i = 0;
			for (int i = 0; i < Math.Min(a.Length,b.Length); ++i)
			{

				if(a[i] == '1' && b[i] == '1')
				{
					tempChar = '0';
					carry = true;
					EndBinary += tempChar;
					continue;
				}

				else if (a[i] == '1' && b[i] == '0')
				{
					tempChar = '1';
				}

				else if (a[i] == '0' && b[i] == '1')
				{
					tempChar = '1';
				}
				else
				{
					tempChar = '0';
				}

				if(carry == true && tempChar == '0')
				{
					tempChar = '1';
					carry = false;
				}
					

				EndBinary += tempChar;

			}//end for loop. done nearly all adding



			string longString = "";

			if(a.Length > b.Length)
			{
				longString = a;
			}
			else
			{
				longString = b;
			}

			//EndBinary += longString.Substring(i);

			for(int i = EndBinary.Length; i < longString.Length; i++)
			{
				if(carry)
				{
					if(longString[i] == '1')
					{

					}
				}

				if(longString[i] == '0' && carry)
				{
					EndBinary += '1';
					carry = false;
				}
				//else if()
				//{
					
				//}

			}



			return EndBinary;
		}


		// 9951
		//  +12
		// 9963

		//1599
		//21+
		//3699




		public static string AddBinary_Stolen(string a, string b)
		{
			// First, create result name string and intially it is empty & in the end we gonna return it as our aswer
			StringBuilder res = new StringBuilder();
			int i = a.Length - 1; // we crete i pointer for string a and we have to start adding from right to left 
			int j = b.Length - 1; // similar pointer j for string b
			int carry = 0; // we create a carry, as we have to consider it as well
			// iterate over the loop until the both condition become false
			while (i >= 0 || j >= 0)
			{
				int sum = carry; // intialise our sum with carry;

				// Now, we subtract by '0' to convert the numbers from a char type into an int, so we can perform operations on the numbers
				if (i >= 0) sum += a[i--] - '0';
				if (j >= 0) sum += b[j--] - '0';
				// taking carry;
				carry = sum > 1 ? 1 : 0; // getting carry depend on the quotient we get by dividing sum / 2 that will be our carry. Carry could be either 1 or 0 
										 // if sum is 0 res is 1 & then carry would be 0;
										 // if sum is 1 res is 1 & carry would be 0
										 // if sum is 2 res is 0 & carry would be 1
										 // if sum is 3 res is 1 & carry would be 1
				res.Append(sum % 2); // just moduling the sum so, we can get remainder and add it into our result
			}

			if (carry != 0) res.Append(carry); // we gonna add it into res until carry becomes 0;
				return new string(res.ToString().Reverse().ToArray()); // revese the answer we get & convt to string and return by the help of result;


		}

	}
}
