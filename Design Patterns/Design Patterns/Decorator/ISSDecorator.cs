namespace Design_Patterns.Decorator
{
    public class ISSDecorator : TaxDecorator
    {
        public ISSDecorator(TaxDecorator otherTax) : base(otherTax) { }
        public ISSDecorator() : base() {}

        public override float Tax(BudgetDecorator budgetDecorator)
        {
            return budgetDecorator.Value * 0.06f + CalculateOtherTax(budgetDecorator);
        }
    }
}
