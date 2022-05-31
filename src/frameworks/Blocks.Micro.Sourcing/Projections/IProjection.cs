namespace Blocks.Micro.Sourcing.Projections
{
    public interface IProjection<TKey>
        where TKey : notnull
    {
        TKey AggregateId { get; }
    }
}
