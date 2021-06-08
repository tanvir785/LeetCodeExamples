using System;
using System.Collections.Generic;
using System.Text;

namespace test1.Solutions
{
    class FindPalindrome
    {
        //        string s = NearestPalindromic(n);
        public static string NearestPalindromic(string n)
        {
            try
            {
                long x = long.Parse(n);
                if (n.Length == 1) return (x - 1).ToString();
                else
                {
                    long leftPal = (x - 1);
                    long rightPal = x + 1;

                    while (leftPal > 0)
                    {

                        bool isLeftPal = Palindrome(leftPal.ToString());
                        bool isRightPal = Palindrome(rightPal.ToString());

                        if (isLeftPal && isRightPal) return leftPal.ToString();
                        else
                        {
                            if (isLeftPal) return leftPal.ToString();
                            else if (isRightPal) return rightPal.ToString();
                        }
                        Console.WriteLine(leftPal + "   " + rightPal);

                        leftPal--;
                        rightPal++;
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.StackTrace;
            }
            return "";

        }

        public static bool Palindrome(string x)
        {
            int start = 0;
            int end = x.Length - 1;

            char[] chars = x.ToCharArray();


            while (start < end)
            {
                if (chars[start] != chars[end]) return false;
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
