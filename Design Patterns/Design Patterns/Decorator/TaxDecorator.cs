namespace Design_Patterns.Decorator
{
    public abstract class TaxDecorator
    {
        private TaxDecorator OtherTax { get; set; }

        public TaxDecorator(TaxDecorator otherTax)
        {
            OtherTax = otherTax;
        }
        public TaxDecorator()
        {
            OtherTax = null;
        }

        public abstract float Tax(BudgetDecorator budgetDecorator);

        protected float CalculateOtherTax(BudgetDecorator budget)
        {
            if (OtherTax == null) return 0;
            return OtherTax.Tax(budget);
        }
    }
}
