using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.BinaryTree
{
    public class PostOrderTraversal
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            List<int> lst = new List<int>();
            postorder(root, lst);
            return lst;

            //List<int> output = new List<int>();
            //Stack<TreeNode> stack = new Stack<TreeNode>();

            //while (root != null || stack.Count>0)
            //{
            //    // push nodes: right -> node -> left
            //    while (root != null)
            //    {
            //        if (root.right != null)
            //        {
            //            stack.Push(root.right);
            //        }
            //        stack.Push(root);
            //        root = root.left;
            //    }

            //    root = stack.Pop();

            //    // if the right subtree is not yet processed
            //    if (stack.Count>0 && root.right == stack.Peek())
            //    {
            //        stack.Pop();
            //        stack.Push(root);
            //        root = root.right;
            //        // if we're on the leftmost leaf  
            //    }
            //    else
            //    {
            //        output.Add(root.val);
            //        root = null;
            //    }
            //}

            //return output;

        }

        public void postorder(TreeNode root, List<int> lst)
        {
            if (root == null) return;
            postorder(root.left, lst);
            postorder(root.right, lst);
            lst.Add(root.val);

        }




    }
}
