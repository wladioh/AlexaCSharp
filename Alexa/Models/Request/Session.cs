namespace Alexa.Models.Request
{
    public class Session
    {
        public bool New { get; set; }
        public string SessionId { get; set; }
        public Application Application { get; set; }
        public Attributes Attributes { get; set; }
        public User User { get; set; }
    }
}