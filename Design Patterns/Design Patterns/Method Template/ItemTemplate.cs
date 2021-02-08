namespace Design_Patterns.Method_Template
{
    public class ItemTemplate
    {
        public string Name { get; private set; }
        public float Price { get; private set; }

       public ItemTemplate(string name, float price)
        {
            Name = name;
            Price = price;
        }
    }

}
