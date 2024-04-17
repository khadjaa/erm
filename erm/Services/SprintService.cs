using Erm.Models;
using Erm.Repositories;
using Erm.Services;

public class SprintService : ISprintService
{
    ISQLRepository<Sprint> _repository;
    
    public SprintService(ISQLRepository<Sprint> repository)
    {
        _repository = repository;
    }
    
    public IEnumerable<Sprint> GetAll()
    {
        return _repository.GetAll();
    }

    public Sprint GetById(Guid id)
    {
        return _repository.GetById(id);
    }

    public string Create(Sprint item)
    {
        if (string.IsNullOrEmpty(item.Name))
        {
            return "The name cannot be empty";
        }

        _repository.Create(item);
        return $"Created new item with this ID: {item.Id}";
    }

    public string Update(Guid id, Sprint item)
    {
        var _item = _repository.GetById(id);
        if (_item is not null)
        {
            _item.Name = item.Name;
            _item.StartDate = item.StartDate;
            _item.EndDate = item.EndDate;
            _item.Tasks = item.Tasks;
            
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