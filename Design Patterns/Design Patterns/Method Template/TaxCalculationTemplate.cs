using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Method_Template
{
    public abstract class TaxCalculationTemplate : Tax
    {
        public float tax(BudgetTax budgetTax)
        {
            if (MustUseTheMaximumTax(budgetTax))
            {
                return MaximumTax(budgetTax);
            }

            return MinimumTax(budgetTax);
        }

        protected abstract bool MustUseTheMaximumTax(BudgetTax budgetTax);
        protected abstract float MaximumTax(BudgetTax budgetTax);
        protected abstract float MinimumTax(BudgetTax budgetTax);
    }
}
