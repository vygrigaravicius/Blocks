namespace Blocks.Micro.Sourcing.Projections
{
    public interface IProjectionProvider<TProjection, TKey>
        where TProjection: notnull, IProjection<TKey>
        where TKey: notnull
    {

    }
}
