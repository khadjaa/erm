using Erm.Models;
using Erm.Repositories;
using Erm.Services;

public class ProjectService : IProjectService
{
    ISQLRepository<Project> _repository;
    
    public ProjectService(ISQLRepository<Project> repository)
    {
        _repository = repository;
    }
    
    public IEnumerable<Project> GetAll()
    {
        return _repository.GetAll();
    }

    public Project GetById(Guid id)
    {
        return _repository.GetById(id);
    }

    public string Create(Project item)
    {
        if (string.IsNullOrEmpty(item.Name))
        {
            return "The name cannot be empty";
        }

        _repository.Create(item);
        return $"Created new item with this ID: {item.Id}";
    }

    public string Update(Guid id, Project item)
    {
        var _item = _repository.GetById(id);
        if (_item is not null)
        {
            _item.Name = item.Name;
            _item.StartDate = item.StartDate;
            _item.EndDate = item.EndDate;
            _item.Sprints = item.Sprints;
            _item.Risks = item.Risks;
            _item.AssignedTo = item.AssignedTo;
            
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