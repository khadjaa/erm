using Erm.Models;
using Erm.Repositories;
using Erm.Services;

public class IssueService : IIssueService
{
    ISQLRepository<Issue> _repository;
    
    public IssueService(ISQLRepository<Issue> repository)
    {
        _repository = repository;
    }
    
    public IEnumerable<Issue> GetAll()
    {
        return _repository.GetAll();
    }

    public Issue GetById(Guid id)
    {
        return _repository.GetById(id);
    }

    public string Create(Issue item)
    {
        if (string.IsNullOrEmpty(item.Name))
        {
            return "The name cannot be empty";
        }

        _repository.Create(item);
        return $"Created new item with this ID: {item.Id}";
    }

    public string Update(Guid id, Issue item)
    {
        var _item = _repository.GetById(id);
        if (_item is not null)
        {
            _item.Name = item.Name;
            _item.StartDate = item.StartDate;
            _item.EndDate = item.EndDate;
            _item.FindByWorker = item.FindByWorker;
            
            var result = _repository.Update(_item);
            return "Item updated";
        }
        return "Item not updated";
    }

    public string Delete(Guid id)
    {
        var result = _repository.Delete(id);
        if (result)
            return "Item deleted";
        else
            return "Item not found";
    }
}