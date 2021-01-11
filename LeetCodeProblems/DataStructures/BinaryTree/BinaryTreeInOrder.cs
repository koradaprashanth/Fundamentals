using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.BinaryTree
{
    public class BinaryTreeInOrder
    {
        public IList<int> InorderTraversal(TreeNode root)
        {

            List<int> lst = new List<int>();
            Stack<TreeNode> st = new Stack<TreeNode>();

            TreeNode curr = root;

            while (curr != null || st.Count>0)
            {

                while (curr != null)
                {
                    st.Push(curr);
                    curr = curr.left;
                }

                if (st.Count > 0)
                {
                    curr = st.Pop();
                    lst.Add(curr.val);
                    curr = curr.right;                    
                }
            }

            return lst;

        }

        //public List<int> inorderTraversal(TreeNode root)
        //{
        //    List<int> res = new List<int>();
        //    helper(root, res);
        //    return res;
        //}

        //public void helper(TreeNode root, List<int> res)
        //{
        //    if (root != null)
        //    {
        //        if (root.left != null)
        //        {
        //            helper(root.left, res);
        //        }
        //        res.Add(root.val);
        //        if (root.right != null)
        //        {
        //            helper(root.right, res);
        //        }
        //    }
    //    //}

    //    Complexity Analysis

    //Time complexity : O(n)O(n)O(n). The time complexity is O(n)O(n)O(n) because the recursive function is T(n)=2⋅T(n/2)+1T(n) = 2 \cdot T(n/2)+1T(n)=2⋅T(n/2)+1.

    //Space complexity : The worst case space required is O(n)O(n)O(n), and in the average case it's O(log⁡n)O(\log n)O(logn) where n nn is number of nodes.


    }

}
