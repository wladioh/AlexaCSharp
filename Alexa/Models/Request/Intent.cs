namespace Alexa.Models.Request
{
    public class Intent
    {
        public string Name { get; set; }
        public Slot Slots { get; set; }

        public bool HaveExit()
        {
            return Slots.Exit != null;
        }

        public OrderItem GetOrderItem()
        {
            var orderItem = new OrderItem
            {
                Name = Slots.ItemName.Value,
                Quantity = Slots.Quantity.Value
            };
            return orderItem;
        }
    }
}