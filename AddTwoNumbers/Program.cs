using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode node = new ListNode(2);
            ListNode node1 = new ListNode(4);
            ListNode node2 = new ListNode(3);
            ListNode node3 = new ListNode(5);
            ListNode node4 = new ListNode(6);
            ListNode node5 = new ListNode(4);
            node.next = node1;
            node1.next = node2;
            node3.next = node4;
            node4.next = node5;
            
            Console.WriteLine(AddTwoNumbers(node, node3).val + " " + AddTwoNumbers(node,node3).next.val + " " + AddTwoNumbers(node,node3).next.next.val);
            Console.ReadLine();
        }
        public static ListNode AddTwoNumbers(ListNode l1,ListNode l2, int carry = 0)
        {
            if(l1 == null && l2 == null && carry == 0) { return null; }
            int total = (l1 !=null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
            carry = total / 10;
            return new ListNode(total%10, AddTwoNumbers(l1?.next, l2?.next, carry));
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
