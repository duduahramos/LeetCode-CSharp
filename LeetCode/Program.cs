namespace LeetCode;

public class Program
{
    public static void Main(string[] args)
    {
        var program = new Program();

        int[] twoSumResult = TwoSum1.Run(new int[] { 2, 7, 11, 15 }, 9);

        ListNode addTwoNumbersResult = AddTwoNumbers2.Run(
            new ListNode(2, new ListNode(4, new ListNode(3))),
            new ListNode(5, new ListNode(6, new ListNode(4)))
        );

        var isPalindrome = PalindromeNumber9.Run(121);

        var romanToInteger = RomanToInteger13.Run("XIV");
    }
}