namespace Design_Patterns.Chain_Of_Responsibility
{
    public interface Discont
    {
        float DiscountValue(BudgetDiscount budget);
        Discont NextVerification { get; set; }
    }

}
