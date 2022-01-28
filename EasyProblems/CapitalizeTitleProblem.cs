using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeHelperFunctions;

namespace EasyProblems
{
	internal class CapitalizeTitleProblem
	{
		//solving this problem: https://leetcode.com/problems/capitalize-the-title/
		public static void Tester()
		{
			string harryPotter = InputReadingFuncts.ReadMassiveInput_Text("\\MassiveInputs\\HarryPotterStone.txt");
			harryPotter = harryPotter.Trim();
			harryPotter = harryPotter.Replace("\n", "");
			harryPotter = harryPotter.Replace("\r", "");
			
			StringBuilder hpSb = new StringBuilder();

			foreach(char c in harryPotter)
			{
				if(Char.IsLetter(c) || Char.IsWhiteSpace(c))
					hpSb.Append(c);
			}
			for(int i = 0; i < 3; ++i)
				hpSb = hpSb.Replace("  ", " ");

			harryPotter = hpSb.ToString();

			CapitalizeTitle(harryPotter);

			//Console.WriteLine();
		}

		public static string CapitalizeTitle(string title)
		{
			string[] words = title.Split(' ');

			StringBuilder sb = new StringBuilder(words.Length);

			foreach (string word in words)
			{
				if(word.Length <= 2)
					sb.Append(word.ToLower());
				else
				{
					sb.Append(char.ToUpper(word[0]) + word.Substring(1).ToLower());
				}

				sb.Append(' ');
			}

			sb.Remove(sb.Length - 1, 1);
			return sb.ToString();
		}
	}
}
