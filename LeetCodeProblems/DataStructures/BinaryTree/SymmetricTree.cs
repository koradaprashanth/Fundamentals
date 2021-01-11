using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.BinaryTree
{
    public class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            return isMirror(root, root);

            //Iterative way;
            //Queue<TreeNode> q = new LinkedList<>();
            //q.add(root);
            //q.add(root);
            //while (!q.isEmpty())
            //{
            //    TreeNode t1 = q.poll();
            //    TreeNode t2 = q.poll();
            //    if (t1 == null && t2 == null) continue;
            //    if (t1 == null || t2 == null) return false;
            //    if (t1.val != t2.val) return false;
            //    q.add(t1.left);
            //    q.add(t2.right);
            //    q.add(t1.right);
            //    q.add(t2.left);
            //}
            //return true;
        }

        public bool isMirror(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return true;
            if (t1 == null || t2 == null) return false;

            return t1.val == t2.val && isMirror(t1.left, t2.right) && isMirror(t1.right, t2.left);
        }
    }
}
