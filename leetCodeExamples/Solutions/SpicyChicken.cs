using System;
using System.Collections.Generic;
using System.Text;

namespace test1.Solutions
{
    class SpicyChicken
    {
        public static void spicychicken(int min, int max)
        {
            for (int i = min; i <= max; ++i)
            {

                if ((i % 3 == 0) && (i % 5 == 0)) Console.WriteLine(i + " SpicyChicken!");
                else if ((i % 3 == 0) && !(i % 5 == 0)) Console.WriteLine(i + " Spicy");
                else if ((i % 5 == 0) && !(i % 3 == 0)) Console.WriteLine(i + " Chicken");
                else if (!(i % 3 == 0) && !(i % 5 == 0)) Console.WriteLine(i);
            }
        }
    }
}
