

namespace C_Advanced01
{
    /// <summary>
    /// Represents a wrapper class for a cached item, storing its value and expiration time.
    /// </summary>
    /// <typeparam name="TValue">The type of the value being cached.</typeparam>
    internal class CacheItem<TValue>
    {
        public TValue Value { get; set; }
        public DateTime ExpirationTime { get; set; }
    }
}
