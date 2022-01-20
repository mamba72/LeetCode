using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class IsomorphicStringsProblem
	{
		//solving this problem: https://leetcode.com/problems/isomorphic-strings/
		public static void Tester()
		{
			string s = "badc", t = "baba";

			Console.WriteLine(IsIsomorphic(s,t));
		}

		public static bool IsIsomorphic(string s, string t)
		{

			if(s.Length == 1)
				return true;

			Dictionary<char,char> letterMapping = new Dictionary<char,char>();

			for(int i = 0; i < s.Length; i++)
			{
				if(letterMapping.ContainsKey(s[i]))
				{
					if(!letterMapping[s[i]].Equals(t[i]))
					{
						return false;
					}
				}else
				{
					if(letterMapping.ContainsValue(t[i]))
						return false;
					else
						letterMapping.Add(s[i], t[i]);
				}
			}

			return true;
		}
	}
}
