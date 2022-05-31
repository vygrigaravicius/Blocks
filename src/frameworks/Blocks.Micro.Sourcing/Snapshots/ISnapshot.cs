namespace Blocks.Micro.Sourcing.Snapshots
{
    public interface ISnapshot<TKey>
        where TKey: notnull
    {
        TKey AggregateId { get; }

        int Version { get; init; }
    }
}
