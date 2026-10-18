

namespace C_Advanced01
{
    internal class Container<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item) => items.Add(item);

        public T Get(int index) => items[index];
    }
}
