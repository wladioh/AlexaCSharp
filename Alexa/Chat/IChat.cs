using Alexa.Models.Request;
using Alexa.Models.Response;

namespace Alexa.Chat
{
    public interface IChat
    {
        ResponseAlexa Action(Request requestBase);
    }
}