using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class AddTwoNumbers2
    {
        public static ListNode Run(ListNode l1, ListNode l2)
        {
            var numberOne = 0;
            var numberTwo = 0;
            ListNode current = null;
            ListNode result = null;

            while (l1 != null)
            {
                numberOne = numberOne * 10 + l1.val;

                l1 = l1.next;
            };

            while (l2 != null)
            {
                numberTwo = numberTwo * 10 + l2.val;

                l2 = l2.next;
            };

            var sum = numberOne + numberTwo;

            foreach (var digit in sum.ToString().Reverse())
            {
                var node = new ListNode(int.Parse(digit.ToString()));

                if (result == null)
                {
                    result = node;
                    current = result;
                }
                else
                {
                    current.next = node;
                    current = current.next;
                }
            }

            return result;
        }
    }
}
