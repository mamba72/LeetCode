﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeHelperFunctions;

namespace MediumProblems
{
	internal class MaximumXORTwoNumsInArrayProblem
	{
		//solving this problem: https://leetcode.com/problems/maximum-xor-of-two-numbers-in-an-array/
		public static void Tester()
		{
			int[] nums = { 2005, 9569, 2601, 264, 1855, 5601, 4357, 3524, 2088, 8782, 7135, 6729, 1209, 1965, 4124, 2447, 1415, 1410, 8135, 7960, 7663, 8793, 7180, 9367, 4082, 1720, 4731, 1460, 3084, 4689, 9718, 1086, 6380, 3016, 8254, 5884, 9758, 4635, 2649, 7081, 4058, 9582, 7037, 8139, 9229, 7439, 6691, 8981, 890, 4746, 8544, 71, 1421, 9474, 216, 3330, 1793, 5514, 9891, 2894, 2239, 5035, 4912, 6348, 4196, 8115, 4795, 6885, 3115, 2994, 9317, 6940, 1942, 5051, 6129, 6814, 7226, 6434, 8771, 3481, 9805, 6299, 3856, 6714, 5744, 7108, 1409, 1859, 1077, 9570, 6249, 4647, 938, 7206, 2726, 5107, 9463, 1609, 6927, 2785 };
			//nums = new int[] { 5706, 7961, 8997, 6012, 9503, 2301, 4957, 123, 1733, 1079, 3992, 7068, 7122, 9222, 1368, 2350, 1833, 466, 5989, 994, 4514, 7159, 6221, 6388, 8935, 1450, 436, 5854, 9228, 5460, 5240, 4440, 2715, 2394, 8779, 7410, 4445, 9731, 1541, 2795, 6576, 4275, 7663, 2993, 8488, 9265, 6881, 6169, 2506, 3418, 3028, 4999, 228, 172, 6943, 5418, 1233, 8963, 7301, 6541, 1176, 5992, 306, 6881, 7514, 2229, 3111, 1707, 7880, 3394, 15, 4703, 1707, 3505, 9336, 2774, 5715, 5321, 7210, 2244, 5310, 7902, 1558, 2629, 2480, 103, 4240, 5573, 5086, 2065, 647, 9915, 4111, 4067, 5924, 3908, 2299, 9559, 1956, 9921, 9210, 3723, 4025, 1528, 9903, 6347, 1009, 6071, 9536, 3774, 6249, 3594, 2071, 7726, 3784, 2227, 8183, 9640, 9153, 7391, 5506, 8122, 2652, 7488, 1437, 613, 4692, 3981, 1045, 4967, 9852, 6207, 4963, 7813, 2801, 6361, 1298, 4227, 6256, 1038, 9476, 5123, 816, 1293, 3281, 2501, 3223, 2341, 2487, 7557, 4157, 5208, 7723, 5150, 2622, 3210, 7105, 9435, 2501, 5304, 6878, 7403, 842, 2799, 4453, 9044, 9790, 8825, 5373, 5803, 4208, 2802, 3750, 5831, 7298, 5766, 3233, 5520, 6058, 6246, 3656, 7599, 5197, 5705, 6015, 2941, 2140, 7887, 6914, 6578, 8810, 8713, 9545, 7654, 9800, 6475, 6597, 5165, 8113, 7933, 2663, 3674, 3368, 9555, 1126, 4396, 1321, 8826, 6967, 5048, 9008, 2282, 6569, 1418, 5639, 9856, 512, 6326, 1958, 8710, 8331, 5296, 5850, 1475, 5835, 5758, 2648, 2094, 343, 7625, 81, 8296, 8480, 6190, 9517, 1708, 3137, 1121, 2282, 5057, 586, 5799, 9405, 2324, 5600, 9626, 7469, 7462, 6377, 1184, 859, 657, 6775, 1328, 3392, 4996, 5093, 1205, 7843, 6196, 6184, 5570, 1950, 2477, 2869, 1897, 7622, 2521, 2777, 7485, 982, 3628, 8967, 6736, 3484, 1460, 5584, 838, 1523, 8121, 4628, 4991, 6801, 6378, 75, 2966, 979, 9341, 8641, 9390, 5636, 4950, 9753, 2378, 1054, 622, 3450, 4622, 9069, 8330, 8034, 8466, 2681, 1149, 6595, 6517, 1553, 1263, 4905, 4553, 7104, 3561, 7585, 1700, 2533, 345, 9072, 8276, 755, 7596, 7140, 6798, 1758, 4561, 9354, 3520, 9787, 2001, 6205, 4793, 6623, 6870, 7787, 2704, 3177, 1622, 492, 7263, 6913, 5480, 2469, 6502, 7321, 499, 1088, 3406, 3279, 2510, 6602, 7391, 9696, 5400, 5724, 6699, 6686, 512, 1448, 756, 9598, 3784, 718, 9667, 990, 5154, 5312, 9421, 8993, 5511, 4876, 6299, 7622, 8381, 7236, 5952, 9398, 132, 4074, 3055, 416, 8491, 2947, 6657, 2610, 3942, 3588, 4381, 6091, 8024, 5805, 2860, 1144, 4892, 7134, 2126, 7619, 7058, 2023, 7168, 5660, 4632, 9316, 5650, 6260, 5671, 4829, 3379, 8493, 5972, 342, 5945, 9771, 2627, 8623, 6968, 6075, 7318, 8968, 3630, 2086, 96, 5833, 8243, 5044, 5624, 6921, 9479, 5545, 2078, 7813, 6564, 6356, 4400, 9936, 9953, 7562, 4150, 8179, 6482, 2766, 8229, 5413, 3342, 4906, 9782, 1791, 5262, 871, 8043, 8295, 724, 3502, 4270, 2517, 4347, 976, 1084, 1697, 2214, 9335, 2654, 9815, 3057, 3187, 9831, 8722, 1231, 1979, 5505, 2521, 2203, 452, 80, 532, 4176, 1062, 9081, 5164, 5928, 398, 2365, 6859, 6222, 8706, 4379, 739, 9823, 3933, 9366, 1185, 6156, 5783, 4372, 4898, 5155, 7224, 8945, 5693, 3898, 4437, 8673, 9900, 6379, 6368, 8378, 8537, 6558, 6417, 5020, 5209, 4105, 6777, 8819, 937, 4982, 3471, 399, 9818, 628, 4749, 7197, 7679, 3493, 8332, 9466, 7134, 1969, 6829, 6228, 8019, 7121, 846, 3256, 8490, 7813, 8219, 2410, 2639, 2464, 6709, 7124, 3397, 8992, 6280, 997, 7356, 3022, 7971, 571, 7606, 9912, 6669, 4784, 4946, 5056, 932, 9420, 7315, 9937, 7778, 7962, 9336, 7189, 5487, 2466, 613, 9704, 8031, 4750, 5924, 3104, 5971, 267, 3954, 2467, 4611, 7578, 4846, 9812, 9760, 4180, 3821, 7820, 9559, 5029, 8401, 2123, 7495, 7290, 3051, 7047, 8557, 6985, 5079, 187, 1624, 501, 4062, 3744, 5088, 7601, 1466, 6281, 8072, 5381, 2010, 5701, 8619, 1274, 7568, 9986, 7536, 3210, 3022, 5891, 3036, 9546, 5682, 6907, 4100, 5607, 6092, 2143, 9463, 6569, 8891, 6423, 7256, 4880, 8844, 4526, 1434, 7459, 4787, 5702, 9697, 7083, 491, 2452, 8058, 5342, 5194, 2439, 1624, 1533, 9982, 5337, 677, 6477, 5884, 445, 1078, 3479, 3985, 607, 2514, 5337, 1452, 4190, 9251, 5414, 9339, 8117, 7176, 6949, 9553, 2098, 9624, 6834, 2277, 1707, 5755, 9653, 749, 3983, 679, 3845, 7457, 5832, 7515, 3475, 5654, 5904, 1260, 5537, 9589, 8294, 2232, 8558, 6079, 6083, 826, 4591, 8541, 8924, 670, 6323, 3825, 2668, 3847, 1290, 9619, 1302, 7910, 0, 6169, 4517, 2738, 6088, 9013, 3007, 6957, 4665, 3671, 8866, 404, 8962, 5428, 3437, 2320, 6504, 9262, 4423, 6134, 4941, 9130, 6871, 5309, 9237, 5545, 2349, 4278, 1741, 3837, 1450, 7780, 5405, 3070, 2862, 4803, 7063, 6976, 1825, 2962, 1993, 4085, 5617, 5736, 9940, 4688, 5580, 6671, 8586, 3695, 8329, 9466, 3373, 9273, 5943, 6618, 5012, 3774, 4407, 2086, 2505, 7783, 7197, 5287, 8728, 3635, 7535, 8878, 7529, 4535, 4030, 2381, 2200, 4851, 4176, 8796, 9644, 3862, 3694, 874, 5178, 6476, 9902, 4646, 2563, 3591, 3719, 8839, 9374, 2589, 8291, 2949, 7436, 5786, 2744, 2430, 7735, 3612, 9105, 2241, 7, 9318, 2877, 781, 438, 1098, 2728, 9645, 8165, 8152, 5862, 7643, 4402, 4091, 6885, 6774, 7175, 5806, 6078, 9072, 2382, 1461, 9058, 5704, 3130, 9848, 653, 5302, 9978, 468, 878, 4071, 524, 3473, 7937, 6867, 6600, 1143, 9699, 1009, 377, 5249, 6417, 8357, 4344, 4900, 9681, 277, 8287, 5067, 9812, 5960, 1572, 2181, 5965, 8899, 5444, 3843, 1595, 1577, 3365, 5761, 8053, 7207, 4655, 7052, 7297, 3771, 4996, 6804, 1369, 9708, 6274, 9113, 3751, 8301, 4548, 582, 5539, 7485, 7426, 4633, 4246, 780, 6754, 4410, 5092, 4931, 9478, 9617, 901, 7216, 3651, 106, 5944, 9722, 2439, 7504, 7351, 1917, 2498, 5336, 688, 2723, 9493, 1626, 559, 5041, 3173, 7045, 4067, 1628, 8810, 3314, 5653, 3463, 6985, 1261, 2521, 8183, 747, 9988, 1460, 4264, 9120, 9775, 6940, 1915, 3763, 6975, 2073, 8967, 7799, 648, 9845, 639, 1468, 5151, 8806, 2765, 2810, 5877, 296, 4359, 2402, 4482, 5966, 9575, 3102, 4102, 6100, 1911, 6544, 489, 8846, 2710, 8397, 9235, 8401, 9911, 911, 6565, 2369, 7366, 9210, 6507, 692, 6021, 8952, 9837, 8255, 3378, 7934, 4256, 1950, 6325, 6026, 659, 5114, 6975, 5534, 1510, 5942, 1859, 2793, 1432, 1166, 1162, 5603, 8453, 1227, 5615, 3398, 8746, 2313, 3018, 3489 };

			nums = InputReadingFuncts.ReadMassiveInput_Array("\\MassiveInputs\\MaxXOR.txt");

			int max = FindMaximumXOR(nums);

			Console.WriteLine(max);
		}

		private static int FindMaximumXOR(int[] nums)
		{
			//int[] numSet = new HashSet<int>(nums).ToArray();
			//nums = nums.Distinct().ToArray();
			nums = new HashSet<int>(nums).ToArray();
			int max = int.MinValue;

			//foreach(int num in numSet)
			//{
			//	foreach(int num2 in numSet)
			//	{
			//		if (num == num2)
			//			continue;
			//		else
			//		{
			//			max = Math.Max(max, num ^ num2);
			//		}
			//	}
			//}

			for (int i = 0; i < nums.Length; i++)
			{
				for(int j = i; j < nums.Length; j++)
				{
					int xor = nums[i] ^ nums[j];
					if(xor > max)
						max = xor;
				}
			}

			return max;
		}
	}
}