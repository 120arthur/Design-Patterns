namespace Design_Patterns.Strategy
{
    public class Icms : Tax
    {
        public float tax(Budget budget)
        {
            return budget.Value * 0.5f;
        }
    }
}
