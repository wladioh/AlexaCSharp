using System;
using System.Collections.Generic;

namespace Alexa.Chat
{
    public static class ChatFactory
    {
        private static readonly IDictionary<string, Func<IChat>> Mapper = new Dictionary<string, Func<IChat>>(StringComparer.InvariantCultureIgnoreCase)
        {
            { "IntentRequest", CreateIntentRequest },
            { "SessionEndedRequest", CreateEndSession },
            { "LaunchRequest", CreateLaunchRequest }
        };


        public static IChat GetChat(string intentType)
        {
            if (!Mapper.Keys.Contains(intentType)) return DefaultIntentRequest();
            var action = Mapper[intentType];
            return action();
        }

        private static IChat DefaultIntentRequest()
        {
            return new DefaultSpeech();
        }

        private static IChat CreateIntentRequest()
        {
            return new ChatConversation();
        }

        private static IChat CreateEndSession()
        {
            return new ChatEnd();
        }

        private static IChat CreateLaunchRequest()
        {
            return new ChatStart();
        }
    }
}