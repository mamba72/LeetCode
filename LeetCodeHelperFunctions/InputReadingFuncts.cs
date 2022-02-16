using System.IO;
namespace LeetCodeHelperFunctions
{
	public class InputReadingFuncts
	{
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x)
			{
				val = x;
				next = null;
			}
		}

		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
			{
				this.val = val;
				this.left = left;
				this.right = right;
			}
		}

		public static ListNode CreateListFromArray(int[] nums)
		{
			ListNode head = new ListNode(nums[0]);
			ListNode curNode = head;
			for(int i = 1; i < nums.Length; ++i)
			{
				curNode.next = new ListNode(nums[i]);
				curNode = curNode.next;
			}

			return head;
		}

		public static int[] CreateArrayFromList(ListNode head)
		{
			List<int> result = new List<int>();

			while(head != null)
			{
				result.Add(head.val);
				head = head.next;
			}

			return result.ToArray();
		}

		public static string ReadMassiveInput_Text(string fileName)
		{
			string fromFile = "";
			try
			{
				fromFile = File.ReadAllText(fileName);
			}catch(DirectoryNotFoundException)
			{
				//Console.WriteLine(e.ToString());

				fromFile = File.ReadAllText(Path.Join(Directory.GetCurrentDirectory(), fileName));
			}
			

			fromFile = fromFile.Trim();

			return fromFile;
		}

		public static int[] ReadMassiveInput_Array(string fileName)
		{

			string fileText = ReadMassiveInput_Text(fileName);

			string[] separated = fileText.Split(',');

			int[] array = new int[separated.Length];

			for(int i = 0; i < separated.Length; i++)
			{
				array[i] = int.Parse(separated[i].Replace("[", "").Replace("]",""));
			}

			return array;
		}


		public static int[][] ReadMassiveInput_2DArray_int(string fileName)
		{
			string fileText = ReadMassiveInput_Text(fileName);

			string[] separated = fileText.Split("],[");

			List<int[]> list = new List<int[]>();

			for(int i = 0; i < separated.Length; ++i)
			{
				if(i == 0)
					separated[0] = separated[0].Replace("[", "");
				else if(i == separated.Length - 1)
					separated[i] = separated[i].Replace("]", "");


				string[] sepSplit = separated[i].Split(',');

				int[] innArray = new int[sepSplit.Length];

				for(int j = 0; j < sepSplit.Length; ++j)
				{
					innArray[j] = int.Parse(sepSplit[j]);
				}

				list.Add(innArray);
			}


			return list.ToArray();
		}

		public static char[][] ReadMassiveInput_2DArray_char(string fileName)
		{
			string fileText = ReadMassiveInput_Text(fileName);

			string[] separated = fileText.Split("],[");

			List<char[]> list = new List<char[]>();

			for (int i = 0; i < separated.Length; ++i)
			{
				if (i == 0)
					separated[0] = separated[0].Replace("[", "");
				else if (i == separated.Length - 1)
					separated[i] = separated[i].Replace("]", "");


				string[] sepSplit = separated[i].Split(',');

				char[] innArray = new char[sepSplit.Length];

				for (int j = 0; j < sepSplit.Length; ++j)
				{
					innArray[j] = sepSplit[j][1];
				}

				list.Add(innArray);
			}


			return list.ToArray();
		}
	}
}