namespace Alexa.Models.Request
{
    public class Slot
    {
        public Item<string> ItemName { get; set; }
        public Item<int> Quantity { get; set; }
        public Item<string> Exit { get; set; }
    }
}