namespace Blocks.Micro.Core.Events
{
    public abstract record Event:
        INotification
    {
        public Event() { }

        public Event(
            EventId id, DateTime timeOfCreation)
        {
            Id = id;
            TimeOfCreation = timeOfCreation;
        }

        public EventId Id { get; private init; }

        public DateTime TimeOfCreation { get; init; }
    }
}
