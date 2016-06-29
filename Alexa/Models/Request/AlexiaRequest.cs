namespace Alexa.Models.Request
{
    public class AlexiaRequest
    {
        public string Version { get; set; }
        public Session Session { get; set; }
        public Request Request { get; set; }
    }
}