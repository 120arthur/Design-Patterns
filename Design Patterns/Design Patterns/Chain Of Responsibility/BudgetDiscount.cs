using System.Collections.Generic;

namespace Design_Patterns.Chain_Of_Responsibility
{
    public class BudgetDiscount
    {
        public float Value { get; private set; }
        public List<Item> itens;
        public BudgetDiscount(float value)
        {
            Value = value;
            itens = new List<Item>();
        }
       public void AddItemToList(Item item)
        {
            itens.Add(item);
        }
    }

}
