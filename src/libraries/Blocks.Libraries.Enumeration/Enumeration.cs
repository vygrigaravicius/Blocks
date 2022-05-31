namespace Blocks.Libraries.Enumeration
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEnum"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public abstract record Enumeration<TEnum, TValue>:
        IEnumeration,
        IEquatable<Enumeration<TEnum, TValue>>,
        IComparable<Enumeration<TEnum, TValue>>
            where TEnum: Enumeration<TEnum, TValue>
            where TValue: notnull, IEquatable<TValue>, IComparable<TValue>
    {


        private readonly string _name;
        private readonly TValue _value;

        protected Enumeration(string name, TValue value)
        {
            _name = string.IsNullOrEmpty(name) ?
                throw new ArgumentNullException(nameof(name)) : name;

            _value = value ?? 
                throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string Name => 
            _name;

        /// <summary>
        /// 
        /// </summary>
        public TValue Value =>
            _value;

        public override string ToString()
            => _name;

        public override int GetHashCode()
            => _value.GetHashCode();

        public virtual int CompareTo(Enumeration<TEnum, TValue>? other)
            => _value.CompareTo(other._value);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEnum"></typeparam>
    public abstract record Enumeration<TEnum>:
        Enumeration<TEnum, int>
            where TEnum: Enumeration<TEnum, int>
    {
        protected Enumeration(string name, int value):
            base(name, value)
        {

        }
    }
}
