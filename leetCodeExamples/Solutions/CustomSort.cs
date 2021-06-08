using System;
using System.Collections.Generic;
using System.Text;

namespace test1.Solutions
{
    public  class CustomSort
    {
        public static void sort()
        {
            List<string> test = new List<string>();


            test.Add("bcbb");
            test.Add("abc");
            test.Add("bbaa");
            test.Add("aa");

            /*
             * bcbb abc bbaa aa
             * 
             * 
             * 
             * 
             */ 

            //test.Sort();

            for (int i=0; i<test.Count;++i)
            {
                for (int j = 0; j < test.Count; ++j)
                {
                    char[] c = test[i].ToCharArray();
                    char[] d = test[j].ToCharArray();
                    if ("a".CompareTo("b") < -1)
                    {

                    }
                }
            }

            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
            //return 0;
        }
    }
}
