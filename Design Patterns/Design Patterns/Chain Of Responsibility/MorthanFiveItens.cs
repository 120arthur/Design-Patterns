namespace Design_Patterns.Chain_Of_Responsibility
{
    public class MorthanFiveItens : Discont
    {
        public Discont NextVerification { get; set; }

        public float DiscountValue(BudgetDiscount budget)
        {
            if (budget.itens.Count >= 5)
            {
                return budget.Value * 0.1f;
            }
            else
            {
                return NextVerification.DiscountValue(budget);
            }
        }
    }

}
