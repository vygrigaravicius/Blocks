namespace Blocks.Micro.Core.Commands
{
    public abstract class CommandHandler<TCommand, TResponse> :
        IRequestHandler<TCommand, TResponse>
            where TCommand : Command<TResponse>
    {
        public async Task<TResponse> Handle(
            TCommand command, CancellationToken cancellationToken = default)
                => await ExecuteAsync(command, cancellationToken);

        protected abstract Task<TResponse> ExecuteAsync(
            TCommand command, CancellationToken cancellationToken);
    }
}
