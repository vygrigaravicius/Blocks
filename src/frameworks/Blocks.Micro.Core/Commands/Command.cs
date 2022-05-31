namespace Blocks.Micro.Core.Commands
{
    public abstract record Command<TResponse>:
        IRequest<TResponse>
    {
        public Command() { }

        public Command(CommandId id, DateTime timeOfCreation)
        {
            Id = id;
            TimeOfCreation = TimeOfCreation;
        }

        public CommandId Id { get; private init; }

        public DateTime TimeOfCreation { get; init; }
    }
}
