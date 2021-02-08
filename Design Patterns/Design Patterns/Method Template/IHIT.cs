using System;
using System.Collections.Generic;

namespace Design_Patterns.Method_Template
{
    public class IHIT : TaxCalculationTemplate
    {

        protected override bool MustUseTheMaximumTax(BudgetTax budgetTax)
        {
            List<string> inBudget = new List<string>();
            foreach (ItemTemplate item in budgetTax.itens)
            {
                if (inBudget.Contains(item.Name))
                {
                    return true;
                }
                else
                    inBudget.Add(item.Name);
            }
            return false;
        }
        protected override float MaximumTax(BudgetTax budgetTax)
        {
            return (budgetTax.Value * 0.13f) + 100.0f;
        }
        protected override float MinimumTax(BudgetTax budgetTax)
        {
            return budgetTax.Value * (0.01f * budgetTax.itens.Count);
        }
    }
}
