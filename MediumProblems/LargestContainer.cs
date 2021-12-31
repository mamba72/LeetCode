using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MediumProblems
{
	class LargestContainer
	{
		
		public static void LargestAreaTester()
		{
			string fromFile = MediumMain.ReadMassiveInput("LargestContainer_MassiveInput.txt");
			int[] massiveInputFromFile = fromFile.Split(",").Select(int.Parse).ToArray();


			int[] input = massiveInputFromFile;
			//int[] input = {1,8,6,2,5,4,8,3,7};

			MediumMain.StartStopWatch();
			int largestArea = LargestArea_BruteForce(input);
			string elapsed = MediumMain.StopStopWatch();
			Console.WriteLine(largestArea + ", " + elapsed);
	}

		public static int LargestArea_DataTable(int[] height)
		{
			DataTable table = new DataTable("Heights");
			DataColumn col = new DataColumn("x");
			col.DataType = System.Type.GetType("System.Int32");
			col.Unique = true;

			table.Columns.Add(col);

			col = new DataColumn("y");
			col.DataType = System.Type.GetType("System.Int32");

			table.Columns.Add(col);
			//now iterate through the height array, adding the elements to the datatable
			DataRow row;
			for(int i = 0; i < height.Length; ++i)
			{
				row = table.NewRow();
				row["x"] = i + 1;
				row["y"] = height[i];
				table.Rows.Add(row);
			}

			//all the rows in descending order of height
			DataRow[] rows = table.Select("", "y ASC");

			int maxArea = -1;
			//iterate through the returned rows, checking their area.
			for(int i = 0; i < rows.Length; ++i)
			{
				int[] point1 = new int[] { (int)rows[i]["x"], (int)rows[i]["y"] };

				for (int j = i + 1; j < rows.Length; ++j)
				{
					int[] point2 = new int[] { (int)rows[j]["x"], (int)rows[j]["y"] };
					maxArea = Math.Max(maxArea, GetArea(point1, point2));
				}
			}

			return maxArea;

		}

		public static int GetArea(int[] point1, int[] point2)
		{
			int minHeight = Math.Min(point1[1], point2[1]); //get the min of the heights
			return minHeight * (point2[1] - point1[1]);
		}

		

		public static int LargestArea_BruteForce(int[] height)
		{
			int maxArea = 0;

			//previous container info
			int maxY2 = 0;
			int maxY1 = 0;

			//iterate through the left points
			for(int x1 = 0; x1 < height.Length; ++x1)
			{
				int y1 = height[x1];

				if (y1 <= maxY1 || y1 == 0)
					continue;

				//skip any height that is zero, maybe speeds it up
				//if (y1 == 0)
				//	continue;
				//iterate through the right points
				//go backwards because we will be doing the widest boxes first
				for (int x2 = height.Length - 1; x2 > x1; x2--)
				{
					int y2 = height[x2];

					if (y2 <= maxY2 || y2 == 0)
						continue;

					//skip any height that is zero, maybe speeds it up
					//if (y2 == 0)
					//	continue;
					//get the smaller height because water will flow over if we get the larger height
					int minHeight = Math.Min(y1,y2);

					//now get the area
					int area = minHeight * (x2-x1);

					maxArea = Math.Max(maxArea, area);

					maxY2 = y2;
				}
				maxY1 = y1;
				maxY2 = 0;
			}

			return (maxArea);
		}
	}
}
