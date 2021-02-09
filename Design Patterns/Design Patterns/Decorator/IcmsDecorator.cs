namespace Design_Patterns.Decorator
{
    public class IcmsDecorator : TaxDecorator
    {
        public IcmsDecorator(TaxDecorator otherTax) : base(otherTax) {}
        public IcmsDecorator() :base() {}
    
        public override float Tax(BudgetDecorator budget)
        {
            return budget.Value * 0.05f + CalculateOtherTax(budget);
        }
    }
}
