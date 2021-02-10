namespace Design_Patterns.Bilder
{
    public class ListItem
    {
        public float Value { get; private set; }
        public string ItemName { get; private set; }

        public ListItem(float value, string itemName)
        {
            Value = value;
            ItemName = itemName;
        }
    }
}