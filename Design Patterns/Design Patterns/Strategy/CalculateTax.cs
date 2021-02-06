using System;

namespace Design_Patterns.Strategy
{
    public class CalculateTax
    {
        public void CalculateTaxes(Budget budget, Tax tax)
        {
            float calculate = tax.tax(budget);
            Console.WriteLine(calculate);
        }
    }
}
