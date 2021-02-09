namespace Design_Patterns.Decorator
{
    public class ICPPDecorator : TaxCalculationDecorator
    {
        public ICPPDecorator(TaxCalculationDecorator otherTax) : base(otherTax) { }
        public ICPPDecorator() : base() { }

        protected override bool MustUseTheMaximumTax(BudgetDecorator budgetDecorator)
        {
            return budgetDecorator.Value > 500 + CalculateOtherTax(budgetDecorator);
        }
        protected override float MaximumTax(BudgetDecorator budgetDecorator)
        {
            return budgetDecorator.Value * 0.07f + CalculateOtherTax(budgetDecorator);
        }
        protected override float MinimumTax(BudgetDecorator budgetDecorator)
        {
            return budgetDecorator.Value * 0.05f + CalculateOtherTax(budgetDecorator);
        }
    }
}
