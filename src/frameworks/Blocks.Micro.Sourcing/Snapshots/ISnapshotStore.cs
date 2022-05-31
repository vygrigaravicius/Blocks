namespace Blocks.Micro.Sourcing.Snapshots
{
    public interface ISnapshotStore<TSnapshot, TKey>
        where TSnapshot: ISnapshot<TKey>
        where TKey: notnull
    {

    }
}
