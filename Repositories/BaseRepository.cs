namespace WomemFashionManagement.Repositories
{
  public abstract class BaseRepository<T> : IRepository<T> where T : class
  {
    protected readonly List<T> _entities;
    public BaseRepository()
    {
      _entities = new List<T>();
    }

    public virtual List<T> GetAll()
    {
      return _entities.Where(e => e != null).Select(e => e).ToList();
    }

    public virtual T GetById(int id)
    {
      return _entities[id];
    }

    public virtual void Add(T entity)
    {
      _entities.Add(entity);
    }

    public virtual void Update(T entity)
    {
      var index = _entities.FindIndex(e => e == entity);
      _entities[index] = entity;
    }

    public virtual void Delete(T entity)
    {
      _entities.Remove(entity);
    }
  }
}