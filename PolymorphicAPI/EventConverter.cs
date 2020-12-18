using Newtonsoft.Json.Linq;
using PolymorphicAPI.Models;
using System;

namespace PolymorphicAPI
{
    public class EventConverter : JsonCreationConverter<EventCommand>
    {
        protected override EventCommand Create(Type objectType, JObject jObject)
        {
            var eventType = jObject["EventType"].Value<string>();

            switch (eventType)
            {
                case "CreateEvent":
                    return new CreateEventCommand();
                case "CancelEvent":
                    return new CancelEventCommand();
                default:
                    throw new NotSupportedException("Event Type Not Supported");
            }
        }
    }
}
