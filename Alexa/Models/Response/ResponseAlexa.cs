namespace Alexa.Models.Response
{
    public class ResponseAlexa
    {
        public string Version { get; set; }
        public Response Response { get; set; }


        public ResponseAlexa()
        {
            Response = new Response { OutputSpeech = { Type = "PlainText" } };
            Version = "1.0";
        }

        public void EndConversation(string phrase)
        {
            Response.OutputSpeech.Text = "Ok, go to the next booth, Thanks!";
            Response.ShouldEndSession = true;
        }

        public void Speak(string speech)
        {
            Response.OutputSpeech.Text = speech;
        }
    }
}