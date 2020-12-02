using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.LinkedLists
{
    public class RemoveElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            //Input: 1->2->6->3->4->5->6, val = 6
            //Output: 1->2->3->4->5
            ListNode sento = new ListNode(0);
            sento.next = head;


            ListNode prev = sento;
            ListNode curr = head;
            while(curr != null)
            {
                if (curr.val == val)
                    prev.next = curr.next;
                else
                    prev = curr;

                curr = curr.next;
            }

            return sento.next;
                
        }
    }
}
