using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Company.FB
{
    public class InsertANodeAtSpecificPosition
    {
        // Complete the insertNodeAtPosition function below.




        public SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
        {
            //1->2->3
            //1->2->4->3
            //pos =2 and data =4
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
            SinglyLinkedListNode curr_node = head;

            int index = 0;
            while (index < position - 1)
            {
                curr_node = curr_node.next;
                index++;
            }

            newNode.next = curr_node.next;
            curr_node.next = newNode;

            return head;

        }
    }

    
}
