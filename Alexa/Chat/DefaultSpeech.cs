using Alexa.Models.Request;
using Alexa.Models.Response;

namespace Alexa.Chat
{
    public class DefaultSpeech : IChat
    {
        public ResponseAlexa Action(Request requestBase)
        {
            var response = new ResponseAlexa();
            response.Speak("Sorry, Can you repeat please?");
            return response;
        }
    }
}