using System.Collections.Generic;

namespace Design_Patterns.Method_Template
{
    public class BudgetTax
    {
        public float Value { get; private set; }
        public List<ItemTemplate> itens;
        public BudgetTax(float value)
        {
            Value = value;
            itens = new List<ItemTemplate>();
        }
       public void AddItemToList(ItemTemplate item)
        {
            itens.Add(item);
        }
    }

}
