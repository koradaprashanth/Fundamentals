using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Company.FB
{
    public class CycleDetection
    {
        public bool hasCycle(SinglyLinkedListNode head)
        {
            //HashSet<SinglyLinkedListNode> lst = new HashSet<SinglyLinkedListNode>();

            //SinglyLinkedListNode curr = head;

            //while (curr != null)
            //{
            //    if (lst.Contains(curr))
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        lst.Add(curr);
            //    }
            //    curr = curr.next;
            //}
            //return false;

            if (head == null) return false;
            SinglyLinkedListNode fast = head.next;
            SinglyLinkedListNode slow = head;
            while(fast!=null && fast.next !=null && slow != null)
            {
                if(slow == fast)
                {
                    return true;
                }
                fast = fast.next.next;
                slow = slow.next;
            }

            return false;


        }
    }
}
