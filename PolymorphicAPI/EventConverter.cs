using Newtonsoft.Json.Linq;
using PolymorphicAPI.Models;
using System;
using System.Collections.Generic;

namespace PolymorphicAPI
{
    public class EventConverter : JsonCreationConverter<EventCommand>
    {
        protected override EventCommand Create(Type objectType, JObject jObject)
        {
            Dictionary<string, object> items = new Dictionary<string, object>(jObject.ToObject<IDictionary<string, object>>(), StringComparer.CurrentCultureIgnoreCase);

            var eventType = items["eventtype"];

            switch (eventType.ToString().ToLowerInvariant())
            {
                case "createevent":
                    return new CreateEventCommand();
                case "cancelevent":
                    return new CancelEventCommand();
                default:
                    throw new NotSupportedException("Event Type Not Supported");
            }
        }
    }
}
