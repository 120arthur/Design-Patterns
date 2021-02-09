namespace Design_Patterns.Decorator
{
    public abstract class TaxCalculationDecorator : TaxDecorator
    {
        public TaxCalculationDecorator(TaxDecorator outroImposto) : base(outroImposto) { }
        public TaxCalculationDecorator() : base() { }

        public override float Tax(BudgetDecorator budgetDecorator)
        {
            if (MustUseTheMaximumTax(budgetDecorator))
            {
                return MaximumTax(budgetDecorator);
            }

            return MinimumTax(budgetDecorator);
        }

        protected abstract bool MustUseTheMaximumTax(BudgetDecorator budgetDecorator);
        protected abstract float MaximumTax(BudgetDecorator budgetDecorator);
        protected abstract float MinimumTax(BudgetDecorator budgetDecorator);
    }
}
