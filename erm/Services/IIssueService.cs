using Erm.Models;

namespace Erm.Services;

public interface IIssueService
{
    IEnumerable<Issue> GetAll();
    Issue GetById(Guid id);
    string Create(Issue item);
    string Update(Guid id, Issue item);
    string Delete(Guid id);
}