using Erm.Models;

namespace Erm.Services;

public interface ISprintService
{
    IEnumerable<Sprint> GetAll();
    Sprint GetById(Guid id);
    string Create(Sprint item);
    string Update(Guid id, Sprint item);
    string Delete(Guid id);
}