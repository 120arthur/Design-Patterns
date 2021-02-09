namespace Design_Patterns.Method_Template
{
    public class IKCV : TaxCalculationTemplate
    {
        protected override bool MustUseTheMaximumTax(BudgetTax budgetTax)
        {
            return budgetTax.Value > 500 && AnyItemWorthMoreThan100Dollars(budgetTax) ;
        }
        protected override float MaximumTax(BudgetTax budgetTax)
        {
            return budgetTax.Value * 0.1f;
        }
        protected override float MinimumTax(BudgetTax budgetTax)
        {
            return budgetTax.Value * 0.05f;
        }

        protected bool AnyItemWorthMoreThan100Dollars(BudgetTax budgetTax)
        {
            foreach (ItemTemplate item in budgetTax.Itens)
            {
                if (item.Price >= 100)
                    return true;
            }
            return false;
        }
    }
}
