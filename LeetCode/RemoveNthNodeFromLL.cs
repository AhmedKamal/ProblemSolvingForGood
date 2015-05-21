using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class RemoveNthFromEndProblem
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode current = head;
            ListNode traverser = head;

            int k = n;

            while (k != 0)
            {
                traverser = traverser.next;
                k--;
            }

            if (traverser == null)
                return head.next;

            while (traverser.next != null)
            {
                current = current.next;
                traverser = traverser.next;

            }
            current.next = current.next.next;
            return head;
        }
    }
}
