using Alexa.Models.Request;
using Alexa.Models.Response;

namespace Alexa.Chat
{
    public class ChatEnd : IChat
    {
        public ResponseAlexa Action(Request requestBase)
        {
            var response = new ResponseAlexa();
            response.EndConversation("Ok, go to the next booth, Thanks!");
            return response;
        }
    }
}