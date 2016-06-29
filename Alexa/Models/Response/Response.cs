namespace Alexa.Models.Response
{
    public class Response
    {
        public OutputSpeech OutputSpeech { get; set; }
        public bool ShouldEndSession { get; set; }
        public Response()
        {
            OutputSpeech = new OutputSpeech();
            ShouldEndSession = false;
        }
    }
}