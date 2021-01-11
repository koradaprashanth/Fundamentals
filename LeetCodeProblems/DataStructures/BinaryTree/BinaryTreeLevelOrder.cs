using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.BinaryTree
{
    public class BinaryTreeLevelOrder
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            // 1->2->5->3->6->4
            if (root == null)
                return new List<IList<int>>();

            int sizeInLevel = 0;
            IList<IList<int>> results = new List<IList<int>>();
            IList<int> resultInLevel = null;
            Queue<TreeNode> level = new Queue<TreeNode>();
            TreeNode currentNode = null;

            level.Enqueue(root);

            while (level.Count != 0)
            {
                sizeInLevel = level.Count;
                resultInLevel = new List<int>();

                while (sizeInLevel != 0)
                {
                    currentNode = level.Dequeue();

                    if (currentNode.left != null)
                        level.Enqueue(currentNode.left);
                    if (currentNode.right != null)
                        level.Enqueue(currentNode.right);

                    resultInLevel.Add(currentNode.val);
                    sizeInLevel--;
                }

                results.Add(resultInLevel);
            }

            return results;
        }


        //Recursive
        //List<List<Integer>> levels = new ArrayList<List<Integer>>();

        //public void helper(TreeNode node, int level)
        //{
        //    // start the current level
        //    if (levels.size() == level)
        //        levels.add(new ArrayList<Integer>());

        //    // fulfil the current level
        //    levels.get(level).add(node.val);

        //    // process child nodes for the next level
        //    if (node.left != null)
        //        helper(node.left, level + 1);
        //    if (node.right != null)
        //        helper(node.right, level + 1);
        //}

        //public List<List<Integer>> levelOrder(TreeNode root)
        //{
        //    if (root == null) return levels;
        //    helper(root, 0);
        //    return levels;
        //}
    }
}
