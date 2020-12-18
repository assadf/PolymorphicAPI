namespace PolymorphicAPI.Models
{
    public class EventCommand
    {
        public string EventType { get; set; }
    }

    public class CreateEventCommand : EventCommand
    {
        public string Name { get; set; }

        public int Quantity { get; set; }
    }

    public class CancelEventCommand : EventCommand
    {
        public int Id { get; set; }

        public string Reason { get; set; }
    }
}
