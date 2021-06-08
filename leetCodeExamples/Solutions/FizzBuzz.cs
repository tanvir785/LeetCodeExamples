using System;
using System.Collections.Generic;
using System.Text;

namespace test1.Solutions
{
    class FizzBuzz
    {
        public static void spicychicken(int min, int max)
        {
            for (int i = min; i <= max; ++i)
            {

                if ((i % 3 == 0) && (i % 5 == 0)) Console.WriteLine("SpicyChicken!");
                else if ((i % 3 == 0) && !(i % 5 == 0)) Console.WriteLine("Spicy");
                else if ((i % 5 == 0) && !(i % 3 == 0)) Console.WriteLine("Chicken");
                else if (!(i % 3 == 0) && !(i % 5 == 0)) Console.WriteLine(i);
            }
        }
    }
}
