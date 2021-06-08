using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test1.Solutions
{
    public class BinayGap
    {
        public string convertToBinary (int x)
        {
            int remainder = 0;
            if (x == 0)
            {
                return "0";
            }

            else if (x == 1)
            {
                return "1";
            }
            else
            {
                remainder = x % 2;
            }


            //while (remainder != 0)
            //{
            //    int result = x / 2;
            //    convertToBinary(result);
            //}
            return remainder + convertToBinary(x/2);
        }

        public int findMaxBinarygap (string x)
        {
            var binaryGapLengths = new List<int>();

            int counter = 0;
            foreach (char c in x)
            {
                if (c == '1')
                {
                    if (counter > 1)
                    {
                        binaryGapLengths.Add(counter - 1);
                        counter = 0;
                    }
                    if (counter == 0) counter += 1;
                }
                else
                {
                    if (counter > 0) ++counter;
                }
            }

            if(binaryGapLengths.Count > 0)
            {
                return binaryGapLengths.Max();
            }
            else
            {
                return 0;
            }
        }
    }
}
