using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;
            if (list1.val <= list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }else
            {
                list2.next = MergeTwoLists(list2.next, list1);
                return list2;
            }
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val, ListNode next)
        {
            this.val = val;
            this.next = next;
        }
    }
}
