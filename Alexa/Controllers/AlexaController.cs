using System.Web.Http;
using Alexa.Chat;
using Alexa.Models.Request;

namespace Alexa.Controllers
{
    public class AlexaController : ApiController
    {
        public IHttpActionResult Post(AlexiaRequest alexiaRequest)
        {
            var request = alexiaRequest.Request;
            var chat = ChatFactory.GetChat(request.Type);
            var response = chat.Action(request);
            return Ok(response);
        }
    }
}