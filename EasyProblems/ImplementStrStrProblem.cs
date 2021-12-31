using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class ImplementStrStrProblem
	{
		//solving this problem: https://leetcode.com/problems/implement-strstr/
		public static int StrStr(string haystack, string needle)
		{
			if(needle.Length == 0)
				return 0;
			if (haystack.Length == 0)
				return -1;
			if (haystack.Equals(needle))
				return 0;

			for(int i = 0; i <= haystack.Length - needle.Length; i++)
			{
				if(haystack[i] == needle[0])
				{
					for(int j = 1; j < needle.Length; j++)
					{
						if(haystack[i + j] != needle[j])
						{
							break;
						}else if (j == needle.Length - 1)
						{
							return i;
						}
					}

					//for the cases when needle length is 1
					if (needle.Length == 1 && haystack[i].Equals(needle[0]))
						return i;
				}

			}

			return -1;
		}
	}
}
