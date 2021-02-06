namespace Design_Patterns.Strategy
{
    public class ISS : Tax
    {
        public float tax(Budget budget)
        {
            return budget.Value * 0.6f;
        }
    }
}
