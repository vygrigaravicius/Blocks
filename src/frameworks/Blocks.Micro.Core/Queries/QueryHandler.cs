namespace Blocks.Micro.Core.Queries
{
    public abstract class QueryHandler<TQuery, TResult> :
        IRequestHandler<TQuery, TResult>
        where TQuery : Query<TResult>
    {
        public async Task<TResult> Handle(
            TQuery query, CancellationToken cancellationToken = default)
                => await ExecuteAsync(query, cancellationToken);

        protected abstract Task<TResult> ExecuteAsync(
            TQuery query, CancellationToken cancellationToken);
    }
}
