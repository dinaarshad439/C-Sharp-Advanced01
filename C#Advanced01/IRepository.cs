

namespace C_Advanced01
{
    /// <summary>
    /// Represents a generic repository interface for managing entities of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of entity being handled by the repository.</typeparam>
    internal interface IRepository<T>
    {
        void add(T entity);
        T Get(string id);
        List<T> GetAll();
    }
}
