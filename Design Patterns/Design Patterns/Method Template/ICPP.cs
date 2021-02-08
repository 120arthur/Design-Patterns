namespace Design_Patterns.Method_Template
{
    public class ICPP : TaxCalculationTemplate
    {
        protected override bool MustUseTheMaximumTax(BudgetTax budgetTax)
        {
            return budgetTax.Value > 500;
        }
        protected override float MaximumTax(BudgetTax budgetTax)
        {
            return budgetTax.Value * 0.07f;
        }
        protected override float MinimumTax(BudgetTax budgetTax)
        {
            return budgetTax.Value * 0.05f;
        }
    }
}
