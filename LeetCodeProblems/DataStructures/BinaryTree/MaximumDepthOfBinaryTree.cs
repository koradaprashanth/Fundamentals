﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.BinaryTree
{
    public class MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int left_height = MaxDepth(root.left);
                int right_height = MaxDepth(root.right);
                return Math.Max(left_height, right_height) + 1;
            }

          
        }
    }
}
