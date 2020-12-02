using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.LinkedLists
{
    public class LinkedListCycle
    {
        //HashTable
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> hash = new HashSet<ListNode>();
            while(head != null)
            {
                if (hash.Contains(head))
                {
                    return true;
                }
                else
                {
                    hash.Add(head);
                }

                head = head.next;

            }
            return false;



            //Time complexity : O(n)O(n)O(n).We visit each of the nnn elements in the list at most once.Adding a node to the hash table costs only O(1)O(1)O(1) time.

            //Space complexity: O(n)O(n)O(n).The space depends on the number of elements added to the hash table, which contains at most nnn elements.


            ////Two Pointer
            //if (head == null)
            //{
            //    return false;
            //}

            //ListNode slow = head;
            //ListNode fast = head.next;
            //while (slow != fast)
            //{
            //    if (fast == null || fast.next == null)
            //    {
            //        return false;
            //    }
            //    slow = slow.next;
            //    fast = fast.next.next;
            //}
            //return true;

            //Space complexity :We only use two nodes(slow and fast) so the space complexity is O(1).
            //Time complexity : Let us denote nnn as the total number of nodes in the linked list.To analyze its time complexity, we consider the following two cases separately.
        }

       
    }


}
