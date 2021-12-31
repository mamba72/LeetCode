using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
	class AddTwoNumbers_LinkedList
	{
        public static void AddTwoNumbers_Tester()
		{
            //ListNode testInput1 = new ListNode(2);
            //testInput1.next = new ListNode(4);
            //testInput1.next.next = new ListNode(3);
            //testInput1.next.next = new ListNode(9);

            ListNode testInput1 = CreateListFromNumber(9999999);
            ListNode testInput2 = CreateListFromNumber(9999);
            //ListNode testInput2 = new ListNode(5);
            //testInput2.next = new ListNode(6);
            //testInput2.next.next = new ListNode(4);

            
            //int[] expectedOutput = new int[] { 0, 2 };

            //Console.WriteLine("Test Input: " + testInput.ToString());
            //Console.WriteLine("Input: " + String.Join(", ", testInput));
            //Console.WriteLine("Target: " + target);
            ListNode outputNode = AddTwoNumbers_Carry1Trick(testInput1, testInput2);

            //Console.WriteLine("Output: " + output.ToString());
            //Console.WriteLine("Output: " + String.Join(", ", output));
            //Console.WriteLine("Expected Output: " + String.Join(", ", expectedOutput));
            //if (Array.Equals(output, expectedOutput))
            //    return true;
            //else
            //    return false;

        }


        //Definition for singly-linked list.
        public class ListNode
		{
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
			{
				this.val = val;
				this.next = next;
            }
        }


		public static ListNode AddTwoNumbers_StringBased(ListNode l1, ListNode l2)
        {
            string num1Str = "";
            string num2Str = "";

            ListNode temp = l1;
            while (temp.next != null)
            {
                num1Str += temp.val;
                temp = temp.next;
            }
            return null;
        }

		public static ListNode AddTwoNumbers_Carry1Trick(ListNode l1, ListNode l2)
		{
            ListNode answer = null;

			ListNode temp1 = l1;
			ListNode temp2 = l2;
            bool isCarry = false;

            ListNode curNode = answer;
			while (temp1 != null && temp2 != null)
			{
                int total = temp1.val + temp2.val;
                if (isCarry)
                    total += 1;

                if(total > 9)
				{
                    isCarry = true;
                    total -= 10;
				}else
				{
                    isCarry = false;
				}
				
				temp1 = temp1.next;
                temp2 = temp2.next;

                if(answer == null)
				{
                    answer = new ListNode(total);
                    curNode = answer;
				}
                else
				{
                    curNode.next = new ListNode(total);
                    curNode = curNode.next;
				}
			}

            //now ensure i continue to carry if needed
            if(isCarry)//check if I need to carry at all
			{
                ListNode newTemp;
                if (temp1 != null)
                    newTemp = temp1;
                else if (temp2 != null)
                    newTemp = temp2;

                //while I still have to carry, keep stepping through nodes
                do
                {

                    curNode.val += 1;

                    if (curNode.val > 9)
                    {
                        isCarry = true;
                        curNode.val = curNode.val - 10;

                        if (curNode.next != null)
                            curNode = curNode.next;
                        else
                            curNode.next = new ListNode(0);
                    }
                    else
                    {
                        isCarry = false;
                    }
                } while (isCarry);

            }

            //now just start adding the remaining values to the end 

            return answer;
		}

        public static ListNode CreateListFromNumber(int num)
		{
            string numStr = "" + num;
            char[] numArray = numStr.ToArray();
            
            Array.Reverse(numArray);

            ListNode head = new ListNode(int.Parse(numArray[0].ToString()));

            ListNode temp = head;
            for(int i = 1; i < numArray.Length; ++i)
			{
                temp.next = new ListNode(int.Parse(numArray[i].ToString()));
                temp = temp.next;
			}

            return head;
		}


		//public string GetNodes(ListNode l1, string nums)
		//{

		//    if (l1.next != null)
		//    {

		//    }
		//}
	}
}
