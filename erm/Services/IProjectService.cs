using Erm.Models;

namespace Erm.Services;

public interface IProjectService
{
    IEnumerable<Project> GetAll();
    Project GetById(Guid id);
    string Create(Project item);
    string Update(Guid id, Project item);
    string Delete(Guid id);
}