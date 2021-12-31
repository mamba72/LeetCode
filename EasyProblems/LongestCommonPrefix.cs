using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	class LongestCommonPrefix
	{
		//solving this problem:https://leetcode.com/problems/longest-common-prefix/
		public static void Tester()
		{
			string[] testInput = new string[] { "flower", "flower", "flower", "flower"};
			Console.WriteLine("Common Prefix: " + CommPrefix(testInput));
		}

		public static string CommPrefix(string[] strs)
		{

			if (strs.Length == 1)
				return strs[0];

			StringBuilder builder = new StringBuilder();

			string prefix = "";

			for (int i = 0; i < strs[0].Length; ++i)
			{
				builder.Append(strs[0][i]);
				prefix = builder.ToString();

				//if not all start with the same thing, then return the prefix
				if (!strs.All(str => str.StartsWith(prefix)))
				{
					if (i == 0)
						return "";
					return prefix.Substring(0,prefix.Length-1);
				}
			}
			//if none of the strings have a similar prefix
			return prefix;
		}


	}
}
