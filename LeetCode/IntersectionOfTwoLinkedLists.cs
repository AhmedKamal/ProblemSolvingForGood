using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    public class  IntersectionOfTwoLinkedLists{
        static Dictionary<int, short> dic;


        //using Hashtable
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            dic = new Dictionary<int, short>();
            TraverseLL(headA);
            TraverseLL(headB);

            ListNode intersect = null;
            bool found = false;
            while (headA != null)
            {
                if (dic[headA.val] == 2 & !found)
                {
                    intersect = headA;
                    found = true;
                }
                if (dic[headA.val] == 1)
                    found = false;

                headA = headA.next;
            }

            if (!found) return null;
            return intersect;
        }

        public static void TraverseLL(ListNode n)
        {
            ListNode head = n;
            while (head != null)
            {
                if (dic.ContainsKey(head.val))
                    dic[head.val]++;

                else
                    dic.Add(head.val, 1);
                head = head.next;
            }
        }

        //solve the problem using parallel traversing
        public static ListNode GetIntersectionNode2(ListNode headA, ListNode headB)
        {
            int lenA = CountLL(headA);
            int lenB = CountLL(headB);

            int diff = Math.Abs(lenA - lenB);
            if (lenA > lenB)
            {
                headA = NavigateToStart(headA , diff);
            }
            else
            {
                headB = NavigateToStart(headB , diff);
            }

            ListNode intersecNode = null;
            bool found = false;
            while (headA != null)
            {
                if (headA.val == headB.val && !found)
                {
                    intersecNode = headA;
                    found = true;
                }
                else if (headB.val != headB.val)
                {
                    found = false;
                }
                headA = headA.next;
                headB = headB.next;
            }

            if (!found)
            {
                return null;
            }
            return intersecNode;
        }

        public static ListNode NavigateToStart(ListNode head, int step)
        {
            while (step != 0)
            {
                step--;
                head = head.next;
            }

            return head;
        }
        public static int CountLL(ListNode headA)
        {
            int cnt = 0;
            ListNode current = headA;
            while (current != null)
            {
                current = current.next;
                cnt++;
            }
            return cnt;
        }

    }
}
