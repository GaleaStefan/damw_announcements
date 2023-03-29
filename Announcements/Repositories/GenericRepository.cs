namespace Announcements.Repositories;

public interface IGenericRepository<T> where T : class
{
    #region Public members
    IEnumerable<T> GetAll();
    T? GetById(Guid id);
    #endregion
}

public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
{
    #region Interface Implementations
    public abstract IEnumerable<T> GetAll();
    public abstract T? GetById(Guid id);
    #endregion
}
