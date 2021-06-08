using System;
using System.Collections.Generic;
using System.Text;

namespace test1.Solutions
{
    class PivotIndex
    {

        //int[] nums = { 1, 7, 3, 6, 5, 6 };
        //int x = PivotIndex(nums);
        public static int PivotIndexes(int[] nums)
        {
            int leftSum = 0;
            int rightSum = 0;
            int pivot = 0;

            bool found = false;

            for (int i = 0; i < nums.Length; ++i)
            {
                rightSum = 0;
                for (int j = i + 1; j < nums.Length; ++j)
                {
                    rightSum += nums[j];
                }

                if (leftSum == rightSum)
                {
                    found = true;
                    return pivot;

                }
                else
                {
                    pivot++;
                    leftSum += nums[i];
                }
            }
            return (!found ? -1 : pivot);
        }
    }
}
