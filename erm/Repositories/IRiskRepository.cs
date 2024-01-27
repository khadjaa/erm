namespace erm.Repositories;

public interface IMemoryRepository<T> where T : BaseEntity
{
    IEnumerable<T> GetAll();
    T GetById(Guid id);
    bool Create(T item);
    bool Update(T item);
    bool Delete(Guid id);
}