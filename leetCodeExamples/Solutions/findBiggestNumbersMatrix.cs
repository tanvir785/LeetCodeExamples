using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace test1.Solutions
{
    public class findBiggestNumbersMatrix
    {
        public int solution(string S)
        {
            string[] words = S.Split(' ');
            List<string> longW = new List<string>();
            foreach (string word in words)
            {
                if (testValidWord(word)) longW.Add(word);
            }
            if (longW.Count > 0 )
            {
            return longW.OrderByDescending(s => s.Length).First().Length;
            }
            else return -1;
        }

        public bool testValidWord (string w)
        {
            if (w.All(x=> char.IsLetterOrDigit(x)))
            {
                int numCount = w.Count(x => char.IsDigit(x));
                if (numCount % 2 == 0) return false;
                else
                {
                    int lettCount = w.Count(x => char.IsLetter(x));
                    if (lettCount % 2 == 1) return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
