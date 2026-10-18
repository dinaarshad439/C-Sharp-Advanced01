

namespace C_Advanced01
{
    /// <summary>
    /// A generic container class that stores a collection of items of type <typeparamref name="T"/> 
    /// and provides methods to add and retrieve items by index.
    /// </summary>
    /// <typeparam name="T">The type of elements stored in the container.</typeparam>
    internal class Container<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item) => items.Add(item);

        public T Get(int index) => items[index];
    }
}
