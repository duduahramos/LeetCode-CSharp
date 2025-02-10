using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class TwoSum1
    {
        public static int[] Run(int[] nums, int target)
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
}
