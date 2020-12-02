using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.LinkedLists
{
    public class LinkedListCycleII
    {
        public ListNode DetectCycle(ListNode head)
        {
            //Hashtable
            HashSet<ListNode> hash = new HashSet<ListNode>();
            while (head != null)
            {
                if (hash.Contains(head))
                {
                    return head;
                }
                head = head.next;
            }
            return null;
        }
    }
}
