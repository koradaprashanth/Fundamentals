using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class FindDuplicateSubtree
    {
        //1,2,3,4,null,2,4,null,null,4
        Dictionary<string, int> count;
        List<TreeNode> ans;
        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            count = new Dictionary<string, int>();
            ans = new List<TreeNode>();

            Count(root);

            return ans;

        }

        public string Count(TreeNode node)
        {
            if (node == null) return "#";
            string serial = node.val + Count(node.left) + Count(node.right);


            if (!count.ContainsKey(serial))
            {
                count.Add(serial, 1);
            }
            else
            {
                count[serial] = count[serial] + 1;
            }

            if(count[serial] == 2)
            {
                ans.Add(node);
            }

            return serial;
        }

    }
}
