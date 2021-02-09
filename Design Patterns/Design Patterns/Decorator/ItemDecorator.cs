namespace Design_Patterns.Decorator
{
    public class ItemDecorator
    {
        public string Name { get; private set; }
        public float Price { get; private set; }

       public ItemDecorator(string name, float price)
        {
            Name = name;
            Price = price;
        }
    }

}
