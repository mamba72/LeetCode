using System.IO;
namespace LeetCodeHelperFunctions
{
	public class InputReadingFuncts
	{
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


		public static int[][] ReadMassiveInput_2DArray(string fileName)
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
	}
}