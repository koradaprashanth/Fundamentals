using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.LinkedLists
{
    public class IntersectionOfTwoLinkedLists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null) return null;

            ListNode a_Pointer = headA;
            ListNode b_Pointer = headB;

            while(a_Pointer != b_Pointer)
            {
                if (a_Pointer == null)
                {
                    a_Pointer = headB;
                }
                else
                {
                    a_Pointer = a_Pointer.next;
                }

                if(b_Pointer== null)
                {
                    b_Pointer = headA;
                }
                else
                {
                    b_Pointer = b_Pointer.next;
                }
            }

            return a_Pointer;
        }
    }
}
