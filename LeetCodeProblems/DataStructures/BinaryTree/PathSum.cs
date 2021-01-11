using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.BinaryTree
{
    public class PathSum
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) return false;

            sum -= root.val;

            if ((root.left == null) && (root.right == null))
                return (sum == 0);

            return HasPathSum(root.left, sum) || HasPathSum(root.right, sum);


            //    if (root == null)
            //        return false;

            //LinkedList<TreeNode> node_stack = new LinkedList<TreeNode>();
            //LinkedList<int> sum_stack = new LinkedList<int>();
            //    node_stack.AddLast(root);
            //    sum_stack.AddLast(sum - root.val);

            //    TreeNode node;
            //    int curr_sum;
            //    while (node_stack.Count>0)
            //    {
            //        node = node_stack.FindLast();
            //        curr_sum = sum_stack.pollLast();
            //        if ((node.right == null) && (node.left == null) && (curr_sum == 0))
            //            return true;

            //        if (node.right != null)
            //        {
            //            node_stack.add(node.right);
            //            sum_stack.add(curr_sum - node.right.val);
            //        }
            //        if (node.left != null)
            //        {
            //            node_stack.add(node.left);
            //            sum_stack.add(curr_sum - node.left.val);
            //        }
            //    }
            //    return false;
            
        }
    }
}
