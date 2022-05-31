namespace Blocks.Micro.Core.Queries
{
    public abstract record Query<TResult>:
        IRequest<TResult>
    {
        public Query()
        {

        }

        public Query(QueryId id, DateTime timeOfCreation)
        {
            Id = id;
            TimeOfCreation = TimeOfCreation;
        }

        public QueryId Id { get; private init; }

        public DateTime TimeOfCreation { get; init; }
    }
}
