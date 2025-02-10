namespace LeetCode;

public class Program
{
    public static void Main(string[] args)
    {
        var program = new Program();

        int[] twoSumResult = program.TwoSum(new int[] { 2, 7, 11, 15 }, 9);

        ListNode addTwoNumbersResult = program.AddTwoNumbers(
            new ListNode(2, new ListNode(4, new ListNode(3))),
            new ListNode(5, new ListNode(6, new ListNode(4)))
        );
    }

    public int[] TwoSum(int[] nums, int target)
    {
        int index1 = 0;
        int index2 = 0;
        bool exit = false;

        for (index1 = 0; index1 < nums.Length; index1++)
        {
            for (index2 = (index1 + 1); index2 < nums.Length; index2++)
            {
                if ((nums[index1] + nums[index2]) == target)
                {
                    exit = true;
                    break;
                }
            }

            if (exit) break;
        }

        return new int[] { index1, index2 };
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
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