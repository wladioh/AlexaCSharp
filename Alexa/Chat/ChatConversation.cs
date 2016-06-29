using Alexa.Models.Request;
using Alexa.Models.Response;

namespace Alexa.Chat
{
    public class ChatConversation : IChat
    {
        public ResponseAlexa Action(Request requestBase)
        {
            var request = (RequestIntent)requestBase;

            if (request.IsExit())
                return new ChatEnd().Action(requestBase);

            var intent = request.Intent;
            var item = intent.GetOrderItem();

            var response = new ResponseAlexa();

            response.Speak($"Ok, {item.Quantity} {item.Name}, anything else?");

            if (!item.IsValid())
                response.Speak("Sorry, Can you repeat please?");

            return response;
        }
    }
}