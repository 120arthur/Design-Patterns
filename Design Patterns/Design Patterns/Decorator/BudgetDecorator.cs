using System.Collections.Generic;
namespace Design_Patterns.Decorator
{
    public class BudgetDecorator
    {
        public float Value { get; private set; }
        public List<ItemDecorator> Itens { get; private set; }

        public BudgetDecorator(float value)
        {
            Itens = new List<ItemDecorator>();
            Value = value;
        }

        public void AddItemToList(ItemDecorator itemDecorator)
        {
            Itens.Add(itemDecorator);
        }
    }
}
