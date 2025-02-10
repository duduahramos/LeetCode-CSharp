namespace LeetCode;

public class Program
{
    public static void Main(string[] args)
    {
        var program = new Program();

        var twoSumResult1 = program.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
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
}