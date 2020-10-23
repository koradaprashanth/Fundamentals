using System;
using System.Collections.Generic;
using System.Text;

namespace Concepts
{
    public class BinaryTree
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            if (root == null)
            {
                return res;
            }
            preOrder(root, res);
            return res;


        }

        private void preOrder(TreeNode root, List<int> res)
        {
            if (root == null)
                return;

            res.Add(root.val);
            preOrder(root.left, res);
            preOrder(root.right, res);
        }

        //public IList<int> InorderTraversal(TreeNode root)
        //{
        //    List<int> res = new List<int>();
        //    if (root == null)
        //    {
        //        return res;
        //    }
        //    inOrderTraversal(root, res);

        //    return res;
        //}
        //private void inOrderTraversal(TreeNode root, List<int> res)
        //{
        //    if (root == null)
        //        return;

        //    inOrderTraversal(root.left, res);
        //    res.Add(root.val);
        //    inOrderTraversal(root.right, res);
        //}

        public List<int> inorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode curr = root;
            while (curr != null || !(stack.Count==0))
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                curr = stack.Pop();
                res.Add(curr.val);
                curr = curr.right;
            }
            return res;
        }

    }

    
    //Definition for a binary tree node.
    public class TreeNode {
       public int val;
       public TreeNode left;
       public TreeNode right;
       public TreeNode(int x) { val = x; }
    }
 
}
