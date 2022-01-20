using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class InterleavingStringsProblem
	{
		//solving this problem: https://leetcode.com/problems/interleaving-string/
		public static void Tester()
		{
			string input1 = "aabcc";
			string input2 = "dbbca";
			string input3 = "aadbbcbcac";
			Console.WriteLine(IsInterleave_ListBased(input1, input2, input3));
		}

		private static bool IsInterleave(string s1, string s2, string s3)
		{
			if(s3.Length != s1.Length + s2.Length)
				return false;

			//StringBuilder sb1 = new StringBuilder();
			//StringBuilder sb2 = new StringBuilder();
			int s1Index = 0;
			int s2Index = 0;

			for(int i = 0; i < s3.Length; i++)
			{
				if(s1Index < s1.Length && s3[i] == s1[s1Index])
					s1Index++;
				else if(s2Index < s2.Length && s3[i] == s2[s2Index])
					s2Index++;
				else
				{
					Console.WriteLine("Found char that was not next in either string");
					return false;
				}	
			}

			if (s1Index == s1.Length - 1 && s2Index == s2.Length - 1)
				return true;
			else
				return false;
				
		}

		public static bool IsInterleave_ListBased(string s1, string s2, string s3)
		{
			if (s3.Length != s1.Length + s2.Length)
				return false;

			List<char> s3List = new List<char>(s3);

			for(int i = 0; i < s1.Length; ++i)
			{
				if (!s3List.Remove(s1[i]))
					return false;
			}

			for(int i = 0; i < s2.Length; ++i)
			{
				if (!s3List.Remove(s2[i]))
					return false;
			}

			if (s3List.Count() > 0)
				return false;
			else
				return true;
		}
	}
}
