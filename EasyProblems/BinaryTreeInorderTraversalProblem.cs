using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeHelperFunctions.InputReadingFuncts;

namespace EasyProblems
{
	internal class BinaryTreeInorderTraversalProblem
	{
		//solving this problem: https://leetcode.com/problems/binary-tree-inorder-traversal/
		private static IList<int> InorderTraversal(TreeNode root)
		{
			List<int> myList = new List<int>();

			if(root == null)
				return myList;

			if(root.left != null)
			{
				myList.AddRange(InorderTraversal(root.left));
			}
			myList.Add(root.val);

			if(root.right != null)
			{
				myList.AddRange(InorderTraversal(root.right));
			}

			return myList;
		}

		//solving this problem: https://leetcode.com/problems/binary-tree-preorder-traversal/
		private static LinkedList<int> myList = new LinkedList<int>();
		private static IList<int> PreorderTraversal(TreeNode root)
		{
			PreorderTraverseRecursive(root);
			return myList.ToList();
		}

		private static void PreorderTraverseRecursive(TreeNode node)
		{
			myList.AddLast(node.val);
			if(node.left != null)
				PreorderTraversal(node.left);
			if(node.right != null)
				PreorderTraversal(node.right);
		}
	}
}
