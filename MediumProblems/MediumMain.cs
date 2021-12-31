﻿using System;
using System.Diagnostics;
using System.IO;

namespace MediumProblems
{
	public class MediumMain
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			//AddTwoNumbers_LinkedList.AddTwoNumbers_Tester();

			//Sum_PerfectSquares.PerfectSquare_Tester();

			//LongestSubstring_Nonrepeating.LengthOfLonestSubstring_Tester();

			//ThreeSum.ThreeSumTester();

			//StringToIntergerConversion_Atoi.MyAtoiTester();

			//ImplementingPow.PowTester();

			//ReverseIntegerProblem.ReverseIntegerTester();

			//LargestContainer.LargestAreaTester();

			//ZigZagConversionProblem.ZigZagTester();

			//TotalHammingDistanceProblem.HammingTester();

			//JumpGameProblem.JumpGameTester();

			//WordSearchProblem.WordSearchTester();

			//RemoveDuplicatesFromSortedArrayProblem.RemoveTester();

			//BasicCalculatorProblem.CalculatorTester();

			//RectangleAreaProblem.ComputeAreaTester();

			//ValidSquareProblem.ValidSquareTester();

			SmallestIntDivisibleByKProblem.SmallestIntTester();
		}



		public static string ReadMassiveInput(string fileName)
		{
			string fromFile = File.ReadAllText(fileName);

			fromFile.Trim();

			return fromFile;
		}

		public static Stopwatch stopwatch = new Stopwatch();
		public static void StartStopWatch()
		{
			stopwatch.Start();
		}

		public static string StopStopWatch()
		{
			stopwatch.Stop();
			TimeSpan ts = stopwatch.Elapsed;

			string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

			return elapsedTime;
		}
	}
}