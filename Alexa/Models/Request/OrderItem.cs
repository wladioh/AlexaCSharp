namespace Alexa.Models.Request
{
    public class OrderItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public bool IsValid()
        {
            return Quantity > 0;
        }
    }
}