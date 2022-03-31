using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeHelperFunctions
{
	public class TimingFuncts
	{
		public static Stopwatch stopwatch = new Stopwatch();
		public static void StartStopWatch()
		{
			stopwatch.Start();
		}

		public static string StopStopWatch()
		{
			stopwatch.Stop();
			TimeSpan ts = stopwatch.Elapsed;

			string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
			stopwatch.Reset();
			return elapsedTime;
		}

		public static TimeSpan StopStopWatchElapsedTime()
		{
			stopwatch.Stop();
			var ts = stopwatch.Elapsed;
			stopwatch.Reset();
			return ts;
		}

		public static string FormatTime(TimeSpan ts)
		{
			string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
			return elapsedTime;
		}


		public static TimeSpan TestFunction(Func<int, int> function, int functionInput, int timesToRun)
		{
			StartStopWatch();
			for (int i = 0; i < timesToRun; i++)
				function(functionInput);
			return StopStopWatchElapsedTime();
		}

		public static TimeSpan TestFunction(Func<int[], int> function, int[] functionInput, int timesToRun)
		{
			StartStopWatch();
			for (int i = 0; i < timesToRun; i++)
				function(functionInput);
			return StopStopWatchElapsedTime();
		}
	}
}
