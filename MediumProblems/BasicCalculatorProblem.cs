using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	internal class BasicCalculatorProblem
	{
		//solving this problem: https://leetcode.com/problems/basic-calculator-ii/
		public static void CalculatorTester()
		{
			string input = "3/2";
			input = MediumMain.ReadMassiveInput("BasicCalculator_MassiveInput.txt");

			Console.WriteLine("Output: " + Calculate(input));
		}


		static char[] Operations = new char[] { '*', '/', '+', '-' };
		public static int Calculate(string s)
		{
			s = s.Trim();
			s = s.Replace(" ", "");

			LinkedList<string> components = BreakIntoComponents(s);
			
			
			//make sure to do PEMDAS

			//do multiplication and division first

			//for(int i = 1; i < components.Count; i += 2)
			//{
			//	//if its multiplication or division, do it.
			//	if(components.ElementAt(i).Equals("*") || components.ElementAt(i).Equals("/"))
			//	{
			//		int val1 = int.Parse(components.ElementAt(i - 1));
			//		int val2 = int.Parse(components.ElementAt(i + 1));
			//		char op = components.ElementAt(i)[0];

			//		int output = DoOperation(val1, op, val2);
			//		components.RemoveRange(i, 2);

			//		components.[i - 1] = output + "";

			//		i -= 2;//might need this to account for the fact that I'm removing items from Components
			//	}
			//}

			//for (int i = 1; i < components.Count; i += 2)
			//{
			//	//if its addition or substraction, do it.
			//	if (components[i].Equals("+") || components[i].Equals("-"))
			//	{
			//		int val1 = int.Parse(components[i - 1]);
			//		int val2 = int.Parse(components[i + 1]);
			//		char op = components[i][0];

			//		int output = DoOperation(val1, op, val2);
			//		components.RemoveRange(i, 2);

			//		components[i - 1] = output + "";

			//		i -= 2;//might need this to account for the fact that I'm removing items from Components
			//	}
			//}

			//foreach (char c in Operations)
			//{
			//	int previousIndex = 0;
			//	while (components.Contains(c + ""))
			//	{
			//		int index = components.IndexOf(c + "", previousIndex);

			//		int val1 = int.Parse(components[index - 1]);
			//		int val2 = int.Parse(components[index + 1]);
			//		char op = components[index][0];

			//		int output = DoOperation(val1, op, val2);
			//		components.RemoveRange(index, 2);

			//		components[index - 1] = output + "";

			//		previousIndex = index - 1;
			//	}
			//}

			//iterate through the linked list doing multiplcation and division
			LinkedListNode<string> curNode = components.First;
			while (curNode.Next != null)
			{
				if(curNode.Next.Value.Equals("*") || curNode.Next.Value.Equals("/"))
				{
					int val1 = int.Parse(curNode.Value);
					char op = curNode.Next.Value[0];
					int val2 = int.Parse(curNode.Next.Next.Value);

					int output = DoOperation(val1, op, val2);

					//reassign the current node's value
					curNode.Value = output + "";
					//remove the following two nodes
					components.Remove(curNode.Next.Next);
					components.Remove(curNode.Next);
				}
				else
				{
					curNode = curNode.Next.Next;
				}
			}

			//iterate through the linked list doing addition and subtraction
			curNode = components.First;
			while (curNode.Next != null)
			{
				if (curNode.Next.Value.Equals("+") || curNode.Next.Value.Equals("-"))
				{
					int val1 = int.Parse(curNode.Value);
					char op = curNode.Next.Value[0];
					int val2 = int.Parse(curNode.Next.Next.Value);

					int output = DoOperation(val1, op, val2);

					//reassign the current node's value
					curNode.Value = output + "";
					//remove the following two nodes
					components.Remove(curNode.Next.Next);
					components.Remove(curNode.Next);
				}
				else
				{
					curNode = curNode.Next.Next;
				}
			}




			return int.Parse(components.First());
			
		}

		public static LinkedList<string> BreakIntoComponents(string s)
		{
			LinkedList<string> components = new LinkedList<string>();
			StringBuilder curComponent = new StringBuilder();

			for(int i = 0; i < s.Length; i++)
			{
				if(Operations.Contains(s[i]))
				{
					if(curComponent.Length != 0)
					{
						components.AddLast(curComponent.ToString());
						curComponent.Clear();
					}
					components.AddLast(s[i] + "");
				}
				else
				{
					curComponent.Append(s[i]);
				}
			}

			if (curComponent.Length != 0)
				components.AddLast(curComponent.ToString());

			return components;
		}

		public static int DoOperation(int val1, char op, int val2)
		{
			return op switch
			{
				'+' => val1 + val2,
				'-' => val1 - val2,
				'*' => val1 * val2,
				'/' => val1 / val2,
				_ => -1,
			};
		}
	}
}
