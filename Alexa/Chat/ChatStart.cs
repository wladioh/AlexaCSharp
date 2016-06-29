using Alexa.Models.Request;
using Alexa.Models.Response;

namespace Alexa.Chat
{
    public class ChatStart : IChat
    {
        public ResponseAlexa Action(Request requestBase)
        {
            var response = new ResponseAlexa();
            response.Speak("Welcome to Mc Donald\'s, How can I help you?");
            return response;
        }
    }
}