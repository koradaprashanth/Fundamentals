using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.BinaryTree
{
    public class BinaryTreePreOrder
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            //Input [1,null,2,3]
            //Output: [1,2,3]

            List<int> lst = new List<int>();
            Stack<TreeNode> st = new Stack<TreeNode>();
            if(root == null)
            {
                return lst;
            }

            st.Push(root);
            while (st.Count > 0)
            {
                TreeNode curr = st.Pop();
                if (curr != null)
                {
                    lst.Add(curr.val);
                    st.Push(curr.right);
                    st.Push(curr.left);
                }
            }
            return lst;
            //while (root != null)
            //{
            //    lst.Add(root.val);
            //    if (root.right != null)
            //    {
            //        st.Push(root.right);
            //    }
            //    root = root.left;
            //    if (root == null && st.Count>0)
            //    {
            //        root = st.Pop();
            //    }
            //}
        }
    }


}
