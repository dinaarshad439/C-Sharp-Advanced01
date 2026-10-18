
namespace C_Advanced01
{
    /// <summary>
    /// Represents a generic cache data structure with expiration support.
    /// </summary>
    /// <typeparam name="TKey">The type of the cache keys.</typeparam>
    /// <typeparam name="TValue">The type of the cached values.</typeparam>
    public class Cache<TKey, TValue>
    {
        private Dictionary<TKey, CacheItem<TValue>> store = new Dictionary<TKey, CacheItem<TValue>>();

        
        public void Add(TKey key, TValue value, TimeSpan duration)
        {
            var item = new CacheItem<TValue>
            {
                Value = value,
                ExpirationTime = DateTime.Now.Add(duration) 
            };
            store[key] = item;
        }

        
        public TValue Get(TKey key)
        {
            if (Contains(key))
            {
                return store[key].Value;
            }
            throw new Exception("Item not found or expired!");
        }

        
        public void Remove(TKey key)
        {
            store.Remove(key);
        }
 
        public bool Contains(TKey key)
        {
            if (store.ContainsKey(key))
            {
                
                if (store[key].ExpirationTime > DateTime.Now)
                {
                    return true;
                }
                
                store.Remove(key);
            }
            return false;
        }
    }
}
