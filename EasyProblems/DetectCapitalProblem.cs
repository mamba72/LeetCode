using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class DetectCapitalProblem
	{
		//solving this problem: https://leetcode.com/problems/detect-capital/
		public static void Tester()
		{
			string word = "FlaG";
			word = "hgslibfgaslibyYVyuivuvuTvtuVtuVtuivtVicfVtFVluFyulFtuKVtuCtoFtuFtuoFtfvofvotuFtoufvtuofvOLfvsidosfhjniougdfjhnduohndfguohn";

			DetectCapitalUse(word);
		}

		public static bool DetectCapitalUse(string word)
		{

			if(word.Equals(word.ToUpper()))
				return true;
			else if(word.Equals(word.ToLower()))
				return true;
			else
			{
				return DetectSingleCapital(word);
			}



		}

		public static bool DetectSingleCapital(string word)
		{
			bool isGood = false;
			if(Char.IsUpper(word[0]))
				isGood = true;


			int left = 1;
			int right = word.Length - 1;

			while(left <= right)
			{
				if(Char.IsUpper(word[left]) || Char.IsUpper(word[right]))
				{
					isGood = false;
					break;
				}

				left++;
				right--;
			}
			
			return isGood;
		}
	}
}
