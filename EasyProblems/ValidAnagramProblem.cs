using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class ValidAnagramProblem
	{
		//solving this problem: https://leetcode.com/problems/valid-anagram/
		public static void IsValidAnagramTester()
		{
			string s = "li3xX3Ft83x9W0hiTk24q9KR7kSbVN9yqpflXzwkq9KR7kSbVN9yqpflXzwkq9KR7kSbVN9yqpflXzwkq9KR7kSbVN9yqpflXzwkli3xX3Ft83x9W0hiTk24q9KR7kSbVN9yqpflXzwkq9KR7kSbVN9yqpflXzwkq9KR7kSbVN9yqpflXzwkq9KR7kSbVN9yqpflXzwk";
			string t = "li3xX3Ft83x9W0hiTk24q9KR7kSbVN9yqpflXzwkq9KR7kSbVN9yqpflXzwkq9KR7kSbVN8yqpflXzwkq9KR7kSbVN9yqpflXzwkli3xX3Ft83x9W0hiTk24q9KR7kSbVN9yqpflXzwkq9KR7kSbVN9yqpflXzwkq9KR7kSbVN9yqpflXzwkq9KR7kSbVN9yqpflXzwk";
			for (int i = 0; i < 10; i++)
			{
				EasyMain.StartStopWatch();

				IsAnagram(s, t);

				Console.WriteLine(EasyMain.StopStopWatch());
			}
		}

		public static bool IsAnagram(string s, string t)
		{
			if(s.Length != t.Length)
				return false;
			else if(s.Equals(t))
				return true;

			Dictionary<char, ushort> mapS = GetCharMapping(s);
			Dictionary<char, ushort> mapT = GetCharMapping(t);
			
			//check if they have the same amount of unique letters
			if(mapS.Count != mapT.Count)
				return false;

			//iterate through the maps, comparing their values, if one doesnt match, return false
			foreach(char c in mapS.Keys)
			{
				if(!mapT.ContainsKey(c))
					return false;
				if(mapS[c] != mapT[c])
					return false;
			}

			return true;

		}

		private static Dictionary<char, ushort> GetCharMapping(string myStr)
		{
			Dictionary<char,ushort> map = new Dictionary<char,ushort>();

			foreach (char c in myStr)
			{
				if (map.ContainsKey(c))
					map[c]++;
				else
					map[c] = 1;
			}

			return map;
		}

	}
}
