using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeHelperFunctions.InputReadingFuncts;

namespace EasyProblems
{
	internal class MaxDepthOfBinaryTreeProblem
	{
		//solving this problem: https://leetcode.com/problems/maximum-depth-of-binary-tree/
		private static int MaxDepth(TreeNode root)
		{
			if(root == null)
				return 0;

			int maxDepth = 1;


			int rightDepth = MaxDepth(root.right);
			int leftDepth = MaxDepth(root.left);
			maxDepth += Math.Max(rightDepth, leftDepth);
			return maxDepth;
		}

		//solving this problem: https://leetcode.com/problems/minimum-depth-of-binary-tree/
		private static int MinDepth(TreeNode root)
		{
			if (root == null)
				return 0;

			int minDepth = 1;


			int rightDepth = MinDepth(root.right);
			int leftDepth = MinDepth(root.left);
			minDepth += Math.Min(rightDepth, leftDepth);
			return minDepth;
		}
	}
}
