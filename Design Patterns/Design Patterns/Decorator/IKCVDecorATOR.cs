namespace Design_Patterns.Decorator
{
    public class IKCVDecorator : TaxCalculationDecorator
    {
        protected override bool MustUseTheMaximumTax(BudgetDecorator budgetDecorator)
        {
            return budgetDecorator.Value > 500 && AnyItemWorthMoreThan100Dollars(budgetDecorator) ;
        }
        protected override float MaximumTax(BudgetDecorator budgetDecorator)
        {
            return budgetDecorator.Value * 0.1f;
        }
        protected override float MinimumTax(BudgetDecorator budgetDecorator)
        {
            return budgetDecorator.Value * 0.05f;
        }

        protected bool AnyItemWorthMoreThan100Dollars(BudgetDecorator budgetDecorator)
        {
            foreach (ItemDecorator item in budgetDecorator.Itens)
            {
                if (item.Price >= 100)
                    return true;
            }
            return false;
        }
    }
}
