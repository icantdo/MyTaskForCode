using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNthNodeFromEndOfList
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int length = 0;
            ListNode node = head;
            while (node != null)
            {
                length++;
                node = node.next;
            }
            
            int tillLength = length - n - 1;
            node = head;
            for (int i = 0; i < tillLength; i++)
            {
                node = node.next;
            }

            if (tillLength == -1)
            {
                return head.next;
            }
            else
            {
                node.next = node.next.next;
                return head;
            }
        }
    }
    public class ListNode {
        public int val;
        public ListNode next;
         public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
         }
    }

}
