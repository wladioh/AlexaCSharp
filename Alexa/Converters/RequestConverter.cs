using System;
using Alexa.Models.Request;
using Newtonsoft.Json.Linq;

namespace Alexa.Converters
{
    public class RequestConverter : BaseConverter<Request>
    {
        protected override Request Create(Type objectType, JObject jObject)
        {
            if (FieldExists("intent", jObject))
                return new RequestIntent();
            return FieldExists("reason", jObject) ? new RequestEnd() : new Request();
        }

        private bool FieldExists(string fieldName, JObject jObject)
        {
            return jObject[fieldName] != null;
        }
    }
}