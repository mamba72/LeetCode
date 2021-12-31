using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class LetterCombincationsOfPhoneNumberProblem
	{
		//solving this problem: https://leetcode.com/problems/letter-combinations-of-a-phone-number/
		public static IList<string> LetterCombinations(string digits)
		{
			Dictionary<char, string> numLetterMap = new Dictionary<char, string>();
			numLetterMap.Add('2', "abc");
			numLetterMap.Add('3', "def");
			numLetterMap.Add('4', "ghi");
			numLetterMap.Add('5', "jkl");
			numLetterMap.Add('6', "mno");
			numLetterMap.Add('7', "pqrs");
			numLetterMap.Add('8', "tuv");
			numLetterMap.Add('9', "wxyz");

			LinkedList<string> combos = new LinkedList<string>();

			string curCombo;
			foreach(char num in digits)
			{
				curCombo = "";
				foreach(char letter in numLetterMap[num])
				{
					//cur

				}
				

			}


			return (IList<string>)combos;
		}
	}
}
