namespace Blocks.Libraries.StrongIDs
{
    public interface IStronglyTypedID<TValue>
        where TValue: notnull
    {
        public TValue Value { get; init; }
    }
}
