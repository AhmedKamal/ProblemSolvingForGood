using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    public class  IntersectionOfTwoLinkedLists{
        static Dictionary<int, short> dic;

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


    }
}
