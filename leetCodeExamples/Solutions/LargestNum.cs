using System;
using System.Collections.Generic;
using System.Text;

namespace test1.Solutions
{
    class LargestNum
    {
        //
        //int[] nums = { 3, 6, 1, 0 };
        // int x = largestNum(nums);
        public static int largestNum(int[] nums)
        {
            // find max
            // if number is not max but greater than this number then it is second max
            // last compare two maxes

            int max = 0;
            int secondMax = 0;
            int index = 0;
            if (nums.Length == 1) return 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    index = i;
                }

            }
            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] > secondMax && nums[i] != max) secondMax = nums[i];

            }
            if (max >= 2 * secondMax || secondMax == 0) return index;
            return -1;
        }
    }
}
