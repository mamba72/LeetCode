using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class SubDomatinVisitCountProblem
	{
		//solving this problem: https://leetcode.com/problems/subdomain-visit-count/
		public static void SubdomainVisitTester()
		{
			string[] input = { "9001 discuss.leetcode.com" };
			Console.WriteLine(SubdomainVisits(input));
		}


		public static IList<string> SubdomainVisits(string[] cpdomains)
		{
			Dictionary<string, int> domainCount = new Dictionary<string, int>();

			foreach (string cpdomain in cpdomains)
			{
				//0 = count, 1 = domain group
				string[] cpSplit = cpdomain.Split(" ");

				int count = int.Parse(cpSplit[0]);

				string[] subDoms = cpSplit[1].Split(".");

				for(int i = 1; i <= subDoms.Length; ++i)
				{
					string subDom = GetSubDomsString(subDoms, i);
					if (domainCount.ContainsKey(subDom))
						domainCount[subDom] += count;
					else
						domainCount.Add(subDom, count);
				}
			}

			//output
			List<string> result = new List<string>();
			foreach (var pair in domainCount)
			{
				result.Add(pair.Value + " " + pair.Key);
			}

			return result;

			//return domainCount.Select(pair => $"{pair.Value} {pair.Key}").ToList();
		}

		public static string GetSubDomsString(string[] subDoms, int numDoms)
		{
			//string result = string.Empty;
			LinkedList<string> domList = new LinkedList<string>();
			for(int i = subDoms.Length - 1; i > subDoms.Length - numDoms - 1; --i)
			{
				domList.AddFirst(subDoms[i]);
			}

			return string.Join(".", domList);
		}
	}
}
