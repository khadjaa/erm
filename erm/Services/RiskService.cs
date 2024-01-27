using erm.Models;
using erm.Repositories;
using erm.Services;

public class RiskService : IRiskService
{
    IMemoryRepository<Risk> _repository;

    public RiskService(IMemoryRepository<Risk> repository)
    {
        _repository = repository;
    }

    public IEnumerable<Risk> GetAll()
    {
        return _repository.GetAll();
    }

    public Risk GetById(Guid id)
    {
        return _repository.GetById(id);
    }

    public string Create(Risk item)
    {
        if (string.IsNullOrEmpty(item.Name))
        {
            return "The name cannot be empty";
        }

        _repository.Create(item);
        return $"Created new item with this ID: {item.Id}";
    }

    public string Update(Guid id, Risk item)
    {
        var _item = _repository.GetById(id);
        if (_item is null)
        {
            return "Item not found";
        }

        _repository.Update(_item);
        return "Item updated";
    }

    public string Delete(Guid id)
    {
        var _item = _repository.GetById(id);
        if (_item is null)
        {
            return "Item not found";
        }

        _repository.Delete(id);
        return "Item deleted";
    }
}