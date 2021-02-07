namespace Design_Patterns.Chain_Of_Responsibility
{
    public class Item
    {
        public string Name { get; private set; }
        public float Price { get; private set; }

       public Item(string name, float price)
        {
            Name = name;
            Price = price;
        }
    }

}
