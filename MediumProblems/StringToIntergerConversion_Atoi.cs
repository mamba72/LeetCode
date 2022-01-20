using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	class StringToIntergerConversion_Atoi
	{
		//solving this problem: https://leetcode.com/problems/string-to-integer-atoi/
		public static void MyAtoiTester()
		{
			string testerStr = "+1";
			testerStr = "    10522545459";
			testerStr = "  0000000000012345678";
			testerStr = "2147483646";
			int output = MyAtoi_Attempt2(testerStr);
			Console.WriteLine(testerStr + " = " + output);
		}

		public static int MyAtoi_Attempt2(string s)
		{
			Dictionary<char, int> charIntMap = new Dictionary<char, int>
			{
				['0'] = 0,
				['1'] = 1,
				['2'] = 2,
				['3'] = 3,
				['4'] = 4,
				['5'] = 5,
				['6'] = 6,
				['7'] = 7,
				['8'] = 8,
				['9'] = 9
			};

			bool isNegative = false;

			s = s.Trim();

			if(s.Length == 0)
				return 0;
			else if(s.Length == 1)
			{
				if (Char.IsDigit(s[0]))
					return charIntMap[s[0]];
				else
					return 0;
			}

			StringBuilder sb = new StringBuilder();
			int index = 0;

			if (s[index] == '-')
			{
				isNegative = true;
				index++;
			}
			else if (s[index] == '+')
				index++;

			while(index < s.Length && s[index] == '0')
			{
				index++;
			}
			

			while(index < s.Length && Char.IsDigit(s[index]))
			{
				
				sb.Append(s[index]);
				index++;
			}

			int sum = 0;
			string numStr = sb.ToString();
			double tensPlace = 0.1;
			int curNum;

			try
			{
				for (int i = numStr.Length - 1; i >= 0; --i)
				{
					curNum = charIntMap[numStr[i]];

					tensPlace = checked(tensPlace * 10);

					sum = checked(sum + curNum * (int)tensPlace);

					
				}

				if (isNegative)
					sum = checked(-1 * sum);

			}
			catch(OverflowException)
			{
				if(isNegative)
				{
					sum = int.MinValue;
					isNegative = false;
				}
				else
					sum = int.MaxValue;
			}
			
			return sum;
		}


		public static int MyAtoi(string s)
		{
			Dictionary<char, int> charIntMap = new Dictionary<char, int>
			{
				['0'] = 0,
				['1'] = 1,
				['2'] = 2,
				['3'] = 3,
				['4'] = 4,
				['5'] = 5,
				['6'] = 6,
				['7'] = 7,
				['8'] = 8,
				['9'] = 9
			};

			int curTotal = 0;
			int tenMultiplier = 0;

			//check to see if the first char is not a number,
			if(!Char.IsDigit(s[0]) && !Char.IsWhiteSpace(s[0]))
			{
				//if it is not a number and it is not a negative or plus,
				if((s[0].Equals('-') || s[0].Equals('+')))
				{
					//then it must be a word and those are skipped
					return 0;
				}
			}

			//iterate through the string in reverse
			for(int i = s.Length - 1; i >= 0; --i)
			{
				char numChar = s[i];

				//check if it is a numeral
				if(Char.IsDigit(numChar))
				{
					try
					{
						if (tenMultiplier > 0)
							curTotal += charIntMap[numChar] * (int)Math.Pow(10, tenMultiplier);
						else // for the case where it is the ones digit
							curTotal += charIntMap[numChar];
						//increment tenMultiplier
						++tenMultiplier;
					}
					catch (OverflowException)
					{
						return int.MaxValue;
					}
				}
				else
				{
					//check if its white space, if so, end the loop
					//if (Char.IsWhiteSpace(numChar))
						//break;
					//check if it is negative
					if (numChar.Equals('-'))
					{
						curTotal *= -1;
						break;
					}
				}
			}//end for loop


			return curTotal;
		}

		/// <summary>
		/// Taking a new approach
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public static int MyAtoi2(string s)
		{
			int numStartIndex;
			bool isNegative = false;
			if (IsValidString(s, out isNegative, out numStartIndex) == false)
				return 0;

			//if we get to this point, we have a valid string
			int num;
			try
			{
				num = FindNumber(s, numStartIndex);
			}catch (OverflowException)
			{
				if (isNegative)
					num = int.MinValue;
				else
					num = int.MaxValue;

				return num;
			}catch(KeyNotFoundException)//if the number contains a letter or some weird symbol
            {
				return 0;
            }

			if(isNegative)
				num *= -1;

			return num;

		}

		public static int FindNumber(string s, int numStartIndex)
		{
			Dictionary<char, int> charIntMap = new Dictionary<char, int>
			{
				['0'] = 0,
				['1'] = 1,
				['2'] = 2,
				['3'] = 3,
				['4'] = 4,
				['5'] = 5,
				['6'] = 6,
				['7'] = 7,
				['8'] = 8,
				['9'] = 9
			};

			string removeBegin = s.Substring(numStartIndex);
			int endNum = removeBegin.IndexOf(' ') - 1;
			if (endNum < 0)
				endNum = removeBegin.Length - 1;

			int curTotal = 0;
			int tenMultiplier = 0;

			//iterate backwards through the sub string
			for (int i = endNum; i >= 0; i--)
			{
				char numChar = removeBegin[i];

				//if there is a decimal point, flush the current value.
				if (numChar.Equals('.'))
				{
					curTotal = 0;
					tenMultiplier = 0;
					//skip the decimal point
					continue;
				}
				//check if its a letter in the middle of the number, if so, reset the total and multiplier
				if(!Char.IsDigit(numChar))
                {
					curTotal = 0;
					tenMultiplier = 0;
					//skip the letter
					continue;
				}

				if (tenMultiplier > 0)
                {
					int num = charIntMap[numChar];
					if(num != 0)
						curTotal = checked(curTotal + num * (int)Math.Pow(10, tenMultiplier));
				}
					
				else // for the case where it is the ones digit
					curTotal += charIntMap[numChar];
				//if the integer rolls over into the negatives, just return the integer max
				//if (curTotal < 0)
				//	return int.MaxValue;

				//increment tenMultiplier
				++tenMultiplier;
			}

			return curTotal;
		}


		public static bool IsValidString(string s, out bool isNegative, out int numStartIndex)
		{
			numStartIndex = -1;
			isNegative = false;
			//iterate through the string until either a letter or number is reached
			for(int i = 0; i < s.Length; ++i)
			{
				if (Char.IsLetter(s[i]))
					return false;
				//make sure the char is a digit, but not 0, so we ignore initial 0s
				else if (Char.IsDigit(s[i]))
				{
					numStartIndex = i;
					return true;
				}
					
				else if(s[i].Equals('-'))
				{
					//make sure that the negative sign isnt the last character
					if(i + 1 < s.Length)
					{
						if (Char.IsDigit(s[i + 1]))
						{
							numStartIndex = i + 1;
							isNegative = true;
							return true;
						}
						else if (s[i + 1].Equals('+'))
						{
							return false;
						}
						else if (Char.IsWhiteSpace(s[i + 1]))
							return false;
						else
							return false;
					}
					else //this else means the input ends with a dash - 
					{
						return false;
					}
				}

				else if (s[i].Equals('.'))
				{
					//make sure that the negative sign isnt the last character
					if (i + 1 < s.Length)
					{
						if (Char.IsDigit(s[i + 1]))
						{
							numStartIndex = i;
							isNegative = false;
							return true;
						}
					}
					else//this else means that the input ends with a period
					{
						return false;
					}
				}
				//checking if the number starts with +- because this problem is stupid
				else if (s[i].Equals('+'))
				{
					//make sure that the plus sign isnt the last character
					if (i + 1 < s.Length)
					{
						if (s[i + 1].Equals('-'))
						{
							numStartIndex = i;
							isNegative = false;
							return false;
						}
						else if(Char.IsDigit(s[i+1]))
						{ 
							numStartIndex = i+1;
							return true;
						}
						else if (Char.IsWhiteSpace(s[i + 1]))
							return false;
						else
							return false;
					}
					else//this else means that the input ends with a plus sign
					{
						return false;
					}
				}


			}
			//assuming no word or numbers
			return false;
		}
	}
}
