using System;
using System.Collections.Generic;
using System.Text;

namespace test1.Solutions
{
    class Agoda
    {
        public static bool checkA(int x, int y)
        {
            //int[] a = new int[] { 936442860, 509389019, 482540391, 623484864, 451717531, 442362118, 351571714 };
            //int counter = 0;
            //var added = new Dictionary<int, int>();
            //for (int i = 0; i < a.Length; ++i)
            //{
            //    for (int j = i + 1; j < a.Length; ++j)
            //    {
            //        int x = a[i];
            //        int y = a[j];
            //        if (checkA(x, y))
            //        {
            //            if (!added.ContainsValue(y))
            //            {
            //                counter++;
            //                added.Add(i, j);
            //            }
            //        }

            //    }
            //}

            if (x.ToString().Length != y.ToString().Length)
            {
                return false;
            }
            else
            {
                char[] c = new char[x.ToString().Length];
                char[] d = new char[y.ToString().Length];
                c = x.ToString().ToCharArray();
                d = y.ToString().ToCharArray();
                int start = 0;
                int end = c.Length - 1;
                while (start < c.Length)
                {
                    if (c[start] != d[end]) return false;
                    else
                    {
                        ++start;
                        --end;
                    }

                }
                return true;
            }
        }
    }
}
