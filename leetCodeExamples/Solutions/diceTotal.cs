using System;
using System.Collections.Generic;
using System.Text;

namespace test1.Solutions
{
    class diceTotal
    {
        /*
Enter your query below.
Please append a semicolon ";" at the end of the query
*/

        public static int diceTotals(int total)
        {
            int counter = 0;
            if (total == 0) return 0;
            else
            {
                for (int i = 1; i <= 6; ++i)
                {
                    for (int j = 1; j <= 6; ++j)
                    {
                        if ((i + j) == total)
                        {
                            counter++;
                        }
                    }
                }
            }
            return counter;
        }


        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            Dictionary<int, int> d = new Dictionary<int, int>();

            int counter = 0;
            int result = 1;


            for (int i = 0; i < A.Length; i++)
            {
                if (!d.ContainsKey(A[i]))
                {
                    d.Add(A[i], 0);
                }
            }

            foreach (var item in d)
            {
                if (d.ContainsKey(result) && item.Key > 0)
                {
                    result++;
                }
            }
            return result;

        }
    }
}
