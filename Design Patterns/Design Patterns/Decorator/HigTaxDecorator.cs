namespace Design_Patterns.Decorator
{
    public class HigTaxDecorator : TaxDecorator
    {
        public HigTaxDecorator() :base() {}
        public HigTaxDecorator(TaxDecorator otherTax) : base(otherTax){}

        public override float Tax(BudgetDecorator budgetDecorator)
        {
            return budgetDecorator.Value * 0.20f + CalculateOtherTax(budgetDecorator);
        }
    }
}
