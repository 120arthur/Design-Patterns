namespace Design_Patterns.Chain_Of_Responsibility
{
    public class CalculateDiscount
    {

        public float Discount(BudgetDiscount budget)
        {
            Discont d1 = new MorthanFiveItens();
            Discont d2 = new MoreThanFiveHundredDolars();
            Discont d3 = new WithoutDiscount();

            d1.NextVerification = d2;
            d2.NextVerification = d3;

            return d1.DiscountValue(budget);

        }

    }

}
