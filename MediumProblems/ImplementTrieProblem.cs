using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class ImplementTrieProblem
	{
        //solving this problem: https://leetcode.com/problems/implement-trie-prefix-tree/
        public static void Tester()
		{
            Trie_HashSet trie = new Trie_HashSet();

            string[] words = { "hello", "giuskrbhsiubgalbdslbfgslbfdslg", "fslhrehiurslbs", "stephen" };
            foreach (string word in words)
                trie.Insert(word);

            trie.Search("hello");

            trie.StartsWith("giuskrbhsiubgalbdslbfgsl");
		}


        public class Trie_HashSet
        {
            HashSet<string> words;
            HashSet<string> prefixes;

            public Trie_HashSet()
            {
                words = new HashSet<string>();
                prefixes = new HashSet<string>();
            }

            public void Insert(string word)
            {
                words.Add(word);
                StringBuilder prefix = new StringBuilder();

                for(int i = 0; i < word.Length - 1; ++i)
				{
                    prefix.Append(word[i]);
                    prefixes.Add(prefix.ToString());
				}
            }

            public bool Search(string word)
            {
                return words.Contains(word);
            }

            public bool StartsWith(string prefix)
            {
                return prefixes.Contains(prefix) || words.Contains(prefix);
            }
        }
    }
}
