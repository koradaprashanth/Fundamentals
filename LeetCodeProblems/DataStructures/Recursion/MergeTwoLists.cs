using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Recursion
{
    public class MergeTwoLists
    {
        public ListNode MergeTwoListsMethod(ListNode l1, ListNode l2)
        {
            //recursive
            if (l1 == null){
                return l2;
            }else if(l2== null){
                return l1;
            }else if (l1.val < l2.val){
                l1.next = MergeTwoListsMethod(l1.next, l2);
                return l1;
            }else{
                l2.next = MergeTwoListsMethod(l1, l2.next);
                return l2;
            }
            //  O(n+m)


            ////Iterative
            //ListNode prehead = new ListNode(-1);

            //ListNode prev = prehead;
            //while (l1 != null && l2 != null)
            //{
            //    if (l1.val <= l2.val)
            //    {
            //        prev.next = l1;
            //        l1 = l1.next;
            //    }
            //    else
            //    {
            //        prev.next = l2;
            //        l2 = l2.next;
            //    }
            //    prev = prev.next;
            //}

            //// exactly one of l1 and l2 can be non-null at this point, so connect
            //// the non-null list to the end of the merged list.
            //prev.next = l1 == null ? l2 : l1;

            //return prehead.next;

            //O(n+m) , O(1)
        }
    }
}
