namespace Blocks.Micro.Core.Events
{
    public abstract class EventHandler<TEvent>:
        INotificationHandler<TEvent>
            where TEvent: Event
    {
        public async Task Handle(
            TEvent @event, CancellationToken cancellationToken = default)
        => await HandleAsync(@event, cancellationToken);

        protected abstract Task HandleAsync(
            TEvent @event, CancellationToken cancellationToken);
    }
}
