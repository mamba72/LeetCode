using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class FindAllAnagramsProblem
	{
		//solving this problem: https://leetcode.com/problems/find-all-anagrams-in-a-string/
		public static void Tester()
		{
			string text = "cbaebabacd", word = "abc";
			text = "nytjpnwtqmpereunznadzpjnjzbvtjktvujbwiauxrriytnqnucngwazvehcpupjtzwrqyaeaimdibjuuqfkfzaniqqyvuhparapfdrarfebhwcgptbhqvhnudaburqeeewyefvxnftdnfbytadkgxirewagcfvamekkvrndagdcqbtfhchgmffhrdndqezrkdchxkjcdiyyfkeetaukvrdavjvyquyefjtqbunmtizvqycwmpztrgfjmhhhhwikzbukbxcavckhbwyizmpvxabaqewqwccvfzivnzdvjgcgqjdguevdgufahzqvuznkmeyffnreyfcvewzpkyafcwfdhqgmttkzvgfritpkvghpyapndzhyvrjwwdwnqgmkbkzkndzetazwqcbwhwdvcwghvqwwrijdptzezzaexqdwjdieprvcgivdzdxcgyxxbvygnximarzdwafwtppduxndmxccbaagzgndnycpwxxaqthmqhcrbfmcbqkfetetduexqbcxavundeabuaqutvxmhjrxrjgvfejgwrekmfhgrrkfdjmydfwwdfuniguahhugkbbzkmccfjeugdtdxduqqvgpazbqqdhfncziapemhctqufhexbmvpcakexitcgqdekuzwbetnhqtncizwkfbncruezwhqgputtfmhvykxnzzkqwaihmwhwuwydzendmvemvqjhivxchugggcgwzixujkjrjjruvqnhzutqagcntkxvyzxiibxmdffnuvzryhifknzqpchduikkwkcqawmytzrvrtxudpmuvrwihnbrtwdtnnejfbtdvnnzuvyaywegrkzxwwidxjkdimnbruwmmiupjkiiryaakuzbutvxtvnbqguzrgcnptxvtpyubfdpnpraeumhemzjuhyzvfjffxqzeqiavbhyrtzupehkwrnxrjumuhbbavfahfirmuyqvecifngmimjwweddnacbkavqacqmrbzjmbzbmrcgeqnwbrcerwzkephxafjcprjyjcxbbzrbwaqcuxhtrfwcivizvkxjpgaccunxmhpxwcyewbuwjjpiexuawcfjakbuxyadfrhjwwvmwhkvwvkmhpacxmwwgxvmarfzcfkhfffzmcyigmhadmaqyamuckxpjzuqqxddtbkzwtgiwfpqmenhpmarzehhqziqwczdwcteikjjaycandtfnivqgrcgwprnaxigdnkmcccffxrpxwvgrcfgkqrjrtaapuyeuwkwkhjabepgtxzwibpertufdgxznhaekrarimbnfrvkzpnxdicgwrnayqvbmifuiqmgkpuiqjukawudptyecpwvbtvkebacnemtcwxkhcbzemtzwabkvxfpjkxhurafnvahkzmtrkzewiurfdkbtuvcefhcbwidduvtcitkcbueuqywmytucnhtrajvirjcxxetapnfeghtxuzbvcewuwihahrtamiytxxmvxywedxhnzuczmywtckxhkwpbbvijhbjjjfpmevchfrcijczuebhftdbjewbgjygavapcrahrjkqdknhvrjmfhzzbrvmipqmnftvynyiewjhqpjtwijhtaqapcetzkdaymgncgunhpvkacpedbywzdbvduahgqekyiyacexfcmjabxaucxevajakpyyeccbdnchjhehpmrhfarpzuruvpyrdyewbmjvqjnbumpeydjjvqacuzniecgkqzpgxhupnzptuwqfduwxmyytbntmwvnqzrznqukcxzkxarfgbtdjaqtchxzmamvwgmaazfztppfkukzvibfrvfvtqjbezwbdvzceifueqgpeyejznffbyakpiqbvhcmjjirtgwyxitpwbextmampheawdbctmcpxwkrhzwwzrefehbmzqwzipvnxyfnctifxirmqiermupcpmcrxixgzructdfjjwfigtqkttbyxbybpmzccrcdktvfpenxeywfyrdejxdvnprmuwybjnmjyqzmpjiybkzwqdhqyfxiwizryvauyhxudyzerqweuptchgajjkcrqtvmyaumtrcuxexdivbzwhrgzdicjtvjjzemdihbpdkbduwkbmhcfdmizbzdpwrcvatippwubtqxyztpvidaqqgnqxjicjqubuqimqfitghixdbxdtmfipeguhykiiwmpttpdbnckgbkpznnqdpzeqcbwhgpjeivbzrfhbbxdvxyxqfmwhgdtwjhtzpzbdceqfybwaqefagcxxhnfwcnnywdekcdyiviugiayirdxqvdpbjevapjvyayrnfnebbxmdiwzadfdminmxxfrfcmfnnhfdddudcydiftgdzgxpuapumciwnxynqyzbxgthewkgidhmaawycvrbvwpgavnyinehgrkemmmymfixyydexrcbdujdvfgdfuaheuqtdapywcmcczkudqxaekndfdfbedemauypqrnjitmeykcpjvnivpyztjjtxmujwwjpkdyqwfmqqdhmbihifymzhxvqpkmthgcezppkwikgeykvhvptpceakecvfuxbzbbxwzujcgtvqvxxnjczqjtiyjwjmxpirtzittyaaidpzdivpypfyxzixwmkenqdetbxvhcexkfxnnifdeuedirhycutjerhgmxpybbhkzbnmpkurmqpczxcvhhijqeeivakbbcayaqvnbtjrtkxgvpuqcrxtjeyzxawyacbbinaivegbkutjrkyvedtwhruyjjxieptwapuhftftaqzpzvfkkhnxepnxniveryfupcpmjfgurhhpjtxtwuwdrkakxeufndmtgmxtipxkatbbkxctyjavgzueppbbmrehicnncftahqqtqyezukmnzkapdhezqtvvvkfbdgahiirxufipicpgbyfzaxhxefegxbvzrrxxprwrdmzjiuttyjxwbgepjhmydawndqcqvibkweathgvywgdayqqwjegfecdjd";
			word = "tj";
			FindAnagrams(text, word);
		}


		private static IList<int> FindAnagrams(string s, string p)
		{
			if(p.Length > s.Length)
				return new List<int>();
			else if(p.Length == 1)
			{
				List<int> dumbList = new List<int>();
				for(int i = 0; i < s.Length; i++)
				{
					if(s[i] == p[0])
					{
						dumbList.Add(i);
					}
				}
				return dumbList;
			}


			HashSet<string> prevAnagrams = new HashSet<string>();
			int wordLength = p.Length;

			//get the number of letters in the given word
			Dictionary<char, int> numLetters = new Dictionary<char, int>();
			foreach (char letter in p)
			{
				if (numLetters.ContainsKey(letter))
					numLetters[letter]++;
				else
					numLetters.Add(letter, 1);
			}

			string tempWord;
			List<int> result = new List<int>();
			//iterate through the original word 
			for (int i = 0; i <= s.Length - wordLength; ++i)
			{
				if(!p.Contains(s[i]))
				{
					continue;
				}

				tempWord = s.Substring(i, wordLength);
				if(prevAnagrams.Contains(tempWord))
					result.Add(i);
				else
				{
					if(CheckAnagram(tempWord,numLetters))
					{
						prevAnagrams.Add(tempWord);
						result.Add(i);
					}
				}
			}
			return result;
		}

		private static bool CheckAnagram(string text, Dictionary<char,int> numLetters)
		{

			Dictionary<char,int> textNums = new Dictionary<char,int>();

			foreach(char letter in text)
			{
				if (textNums.ContainsKey(letter))
					textNums[letter]++;
				else if(numLetters.ContainsKey(letter))
					textNums.Add(letter, 1);
				else
					return false;
			}

			if(textNums.Count != numLetters.Count)
				return false;
			
			foreach(var pair in textNums)
			{
				if(numLetters.ContainsKey(pair.Key))
				{
					if(numLetters[pair.Key] != pair.Value)
						return false;

				}else
				{
					return false;
				}

			}
			return true;
		}
	}
}
