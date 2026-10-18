

namespace C_Advanced01
{
    /// <summary>
    /// Represents a safe list collection that stores items of type <typeparamref name="T"/> 
    /// and safely returns the default value if an invalid index is accessed.
    /// </summary>
    /// <typeparam name="T">The type of elements stored in the safe list.</typeparam>
    public class SafeList<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item) => items.Add(item);

        public T Get(int index)
        {
            if (index < 0 || index >= items.Count)
                return default; 

            return items[index];
        }
    }
}
