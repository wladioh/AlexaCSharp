namespace Alexa.Models.Request
{
    public class Item<T>
    {
        public string Name { get; set; }
        public T Value { get; set; }
    }
}