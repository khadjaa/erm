using Erm.Models;
using Erm.Repositories;
using Erm.Services;

public class RiskService : IRiskService
{
    ISQLRepository<Risk> _repository;

    public RiskService(ISQLRepository<Risk> repository)
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
        if (_item is not null)
        {
            _item.Name = item.Name;
            _item.Description = item.Description;
            _item.Impact = item.Impact;
            _item.Probability = item.Probability;

            var result = _repository.Update(_item);
            if (result)
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