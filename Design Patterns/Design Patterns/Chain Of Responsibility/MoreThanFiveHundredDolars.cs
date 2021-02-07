namespace Design_Patterns.Chain_Of_Responsibility
{
    public class MoreThanFiveHundredDolars : Discont
    {
        public Discont NextVerification { get; set; }

        public float DiscountValue(BudgetDiscount budget)
        {
            if (budget.Value >= 500.0f)
            {
                return budget.Value * 0.07f;
            }
            else
            {
                return NextVerification.DiscountValue(budget);
            }
        }
    }

}
