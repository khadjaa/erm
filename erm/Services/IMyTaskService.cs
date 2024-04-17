using Erm.Models;

namespace Erm.Services;

public interface IMyTaskService
{
    IEnumerable<MyTask> GetAll();
    MyTask GetById(Guid id);
    string Create(MyTask task);
    string Update(Guid id, MyTask task);
    string Delete(Guid id);
}