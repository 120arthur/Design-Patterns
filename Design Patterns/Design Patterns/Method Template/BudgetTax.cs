using System.Collections.Generic;

namespace Design_Patterns.Method_Template
{
    public class BudgetTax
    {
        public float Value { get; private set; }
        public List<ItemTemplate> Itens;
        public BudgetTax(float value)
        {
            Value = value;
            Itens = new List<ItemTemplate>();
        }
       public void AddItemToList(ItemTemplate item)
        {
            Itens.Add(item);
        }
    }

}
