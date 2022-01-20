using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
	internal class ScrambleStringProblem
	{
		//solving this problem: https://leetcode.com/problems/scramble-string/

		//private static HashSet<string> possibleScrambles;
		public static bool IsScramble(string s1, string s2)
		{
            if (s1.Length != s2.Length)
                return false;

            if (s1.Length == 0 || s1.Equals(s2))
                return true;

            char[] arr1 = s1.ToCharArray();
            char[] arr2 = s2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            if (!new String(arr1).Equals(new String(arr2)))
            {
                return false;
            }

            for (int i = 1; i < s1.Length; i++)
            {
                String s11 = s1.Substring(0, i);
                String s12 = s1.Substring(i, s1.Length - i);
                String s21 = s2.Substring(0, i);
                String s22 = s2.Substring(i, s2.Length - i);
                String s23 = s2.Substring(0, s2.Length - i);
                String s24 = s2.Substring(s2.Length - i, s2.Length - i);

                if (IsScramble(s11, s21) && IsScramble(s12, s22))
                    return true;
                if (IsScramble(s11, s24) && IsScramble(s12, s23))
                    return true;
            }

            return false;
        }

		//private static void GenerateScramble(string s1, string s2 = null)
		//{
		//	if(s1.Length == 1)
		//	{

		//	}
		//}
	}
}
