# PolymorphicAPI

POST https://localhost:port/api/events

## Create Event
{
    "eventType": "CreateEvent",
    "name": "This is a create event",
    "quantity": 100
}

## Cancel Event

{
    "eventType": "CancelEvent",
    "id": 100,
    "reason": "Didn't like it."
}
