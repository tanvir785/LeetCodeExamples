using System;
using System.Collections.Generic;
using System.Text;

namespace test1.Solutions
{
    class CalculateTax
    {
        public static string calculateTax(float income)
        {
            float tax = 0;

            if (income < 1) return "0.00";
            else if (income < 18201) return "0.00";

            else if (income > 18200 && income <= 37000)
            {
                tax = float.Parse(((income - 18200) * 0.19).ToString());
            }

            else if (income > 37000 && income <= 87000)
            {
                tax = float.Parse((((18800) * 0.19) + ((income - 37000) * 0.325)).ToString());
            }
            else if (income > 87000 && income <= 180000)
            {
                tax = float.Parse((((18800) * 0.19) + (50000 * 0.325) + ((income - 87000) * 0.37)).ToString());
            }
            else if (income > 180000)
            {
                tax = float.Parse((((18800) * 0.19) + (50000 * 0.325) + (93000 * 0.37) + ((income - 180000) * 0.45)).ToString());
            }

            return tax.ToString("0.00");
        }
    }
}
