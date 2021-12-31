using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class MergeTwoSortedArraysProblem
	{
		//solving this problem: https://leetcode.com/problems/merge-sorted-array/
		public static void MergeTester()
		{

		}


		public static int[] nums1;
		public static int m;
		public static int[] nums2;
		public static int n;

		public static Dictionary<int, int> frequencyMap1 = new Dictionary<int, int>();
		public static Dictionary<int, int> frequencyMap2 = new Dictionary<int, int>();

		public static bool thread1Done = false;
		public static bool thread2Done = false;

		public static void Merge(int[] ogNums1, int ogM, int[] ogNums2, int ogN)
		{
			if (ogM == 0)
			{
				Array.Copy(ogNums2, ogNums1, ogN);
				return;
			}else if(ogN == 0)
			{
				return;
			}
				



			nums1 = ogNums1;
			m = ogM;
			nums2 = ogNums2;
			n = ogN;

			ThreadPool.QueueUserWorkItem(ThreadFunct, 1);
			ThreadPool.QueueUserWorkItem(ThreadFunct, 2);

			while(!thread1Done && !thread2Done)
			{
				Thread.Sleep(1);
			}
			foreach(int key in frequencyMap1.Keys)
			{
				if (frequencyMap2.ContainsKey(key))
					frequencyMap2[key] += frequencyMap1[key];
				else
					frequencyMap2.Add(key, frequencyMap1[key]);
			}

			//threads are done now.
			//build the final array
			int[] sortedKeys = frequencyMap2.Keys.ToArray();
			Array.Sort(sortedKeys);
			int curIndex = 0;
			foreach(int key in sortedKeys)
			{
				for(int i = 0; i < frequencyMap2[key]; i++)
				{
					nums1[curIndex] = key;
					curIndex++;
				}
			}
		}

		static void ThreadFunct(Object stateInfo)
		{
			int arrayNum = (int)stateInfo;
			Dictionary<int, int> freqMap;
			int arrLength;
			int[] arr;
			
			if (arrayNum == 1)
			{
				arrLength = m;
				arr = nums1;
				freqMap = frequencyMap1;
			}
			else
			{
				arrLength = n;
				arr = nums2;
				freqMap = frequencyMap2;
			}
				
			for(int i = 0; i < arrLength; i++)
			{
				if(freqMap.ContainsKey(arr[i]))
				{
					freqMap[arr[i]]++;
				}else
				{
					freqMap.Add(arr[i], 1);
				}
			}

			if(arrayNum == 1)
				thread1Done = true;
			else
				thread2Done = true;
		}



		public static void Merge_NonCrazySolution(int[] ogNums1, int ogM, int[] ogNums2, int ogN)
		{
			Array.Copy(ogNums2, 0, ogNums1, ogM, ogN);
			Array.Sort(ogNums1);
		}

	}
}
