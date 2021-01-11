using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Recursion
{
    public class SearchInABinaryTree
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            //Recursion
            if (root == null || val==root.val) return root;

            return val < root.val ? SearchBST(root.left, val) : SearchBST(root.right, val);

            //TimeComplexity:  O(H), where h is a tree height. That result in O(logN) in the average case, O(N) in worst case.
            //SpaceComplexity: O(H) to keep the recursion stack, i.e O(logN) in the average case, O(N) in worst case.


            //Iterative

            //while(root!=null && val!= root.val)
            //{
            //    root = val < root.val ? root.left : root.right;
            //}
            //return root;

            //TimeComplexity: O(H), where h is a tree height. That result in O(logN) in the average case, O(N) in worst case.
            //SpaceComplexity: O(1) since its constant space solution.


        }
    }
}
