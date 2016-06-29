namespace Alexa.Models.Request
{
    public class RequestIntent: Request
    {
        public Intent Intent { get; set; }

        public bool IsExit()
        {
            return Intent.HaveExit();
        }
    }
}