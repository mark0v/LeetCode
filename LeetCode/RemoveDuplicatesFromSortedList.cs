using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head) 
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode node1 = head,
                node2 = head.next;
        
            while (node2 != null)
            {
                if (node1.val == node2.val)
                {
                    node1.next = node2.next;
                    node2.next = null;
                    node2 = node1.next;
                }
                else
                {
                    node1 = node2;
                    node2 = node2?.next;
                }
            }

            return head;
        }   
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
