using System;
using Alexa.Models.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.Converters
{
    public abstract class BaseConverter<T> : JsonConverter
    {
        protected abstract T Create(Type objectType, JObject jObject);
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Request);
        }
        public override bool CanRead => true;

        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);

            // Create target object based on JObject
            var target = Create(objectType, jObject);

            // Populate the object properties
            serializer.Populate(jObject.CreateReader(), target);

            return target;
        }
    }
}