using System;
using System.Collections.Generic;
using System.Text;

namespace test1.Solutions
{
    class AltitudeGain
    {
        /*
        There is a biker going on a road trip.The road trip consists of n + 1 points at different altitudes.The biker starts his trip on point 0 with altitude equal 0.


          You are given an integer array gain of length n where gain[i] is the net gain in altitude between points i​​​​​​ and i + 1 for all (0 <= i<n). Return the highest altitude of a point.



        Example 1:

        Input: gain = [-5,1,5,0,-7]
                Output: 1
        Explanation: The altitudes are[0, -5, -4, 1, 1, -6]. The highest is 1.
        Example 2:

        Input: gain = [-4,-3,-2,-1,4,3,2]
                Output: 0
        Explanation: The altitudes are[0, -4, -7, -9, -10, -6, -3, -1]. The highest is 0.



        Constraints:

        n == gain.length
        1 <= n <= 100
        -100 <= gain[i] <= 100
        Accepted


                        int[] nums = { -5, 1, 5, 0, -7 };
            int x = LargestAltitude(nums);

        */
        public static int LargestAltitude(int[] gain)
        {
            int alt = 0;
            int maxAlt = alt;
            for (int i = 0; i < gain.Length; ++i)
            {
                alt += gain[i];
                if (alt > maxAlt)
                {
                    maxAlt = alt;
                }
            }
            return maxAlt;
        }
    }
}
