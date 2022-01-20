using System;
using System.Diagnostics;

namespace EasyProblems
{
	class EasyMain
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			//TwoSum_SortedArray.TwoSumSortedTester();

			//LongestCommonPrefix.Tester();

			//AtMostOneSegmentOfOnes.Tester();

			//RomanToIntegerProblem.RomanToIntTester();

			//AscendingNumbersInSentence.AscendingNumTester();

			//HammingDistanceProblem.HammingTester();

			//RemoveDuplicatesFromSortedArrayProblem.RemoveTester();

			//MinimumAbsoluteDifferenceProblem.MinimumAbsDiffTester();

			//ValidAnagramProblem.IsValidAnagramTester();

			//FindTargetIndiciesProblem.TargetIndiciesTester();

			//ComplimentOfIntegerProblem.BitwiseComplimentTester();

			//MaximumSubArray.MaxSubArrayTester();

			//IsValidPalindromeProblem.PalindromeTester();

			//'AddBinaryProblem.AddBinaryTester();

			//NumbersSmallerThanCurrentProblem.SmallerNumbersTester();

			//WordPatternProblem.Tester();

			//IsomorphicStringsProblem.Tester();

			UglyNumberProblem.Tester();
		}

		public static Stopwatch stopwatch = new Stopwatch();
		public static void StartStopWatch()
		{
			stopwatch.Reset();
			stopwatch.Start();
		}

		public static string StopStopWatch()
		{
			stopwatch.Stop();
			TimeSpan ts = stopwatch.Elapsed;

			string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000000000000000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

			return elapsedTime;
		}
	}
}
