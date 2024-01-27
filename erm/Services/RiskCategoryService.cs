using erm.Models;

namespace erm.Services;

public class RiskCategoryService : IRiskCategoryService
{
    static Dictionary<Guid, RiskCategory> Items = new();

    public IEnumerable<RiskCategory> GetAll()
    {
        return Items.Values;
    }

    public RiskCategory GetById(Guid id)
    {
        return Items.SingleOrDefault(w => w.Key == id).Value;
    }

    public string Create(RiskCategory item)
    {
        if (string.IsNullOrEmpty(item.Name))
        {
            return "The name cannot be empty";
        }

        Items.Add(item.Id, item);
        return $"Created new item with this ID: {item.Id}";
    }

    public string Update(Guid id, RiskCategory item)
    {
        var _item = Items.SingleOrDefault(w => w.Key == id).Value;
        if (_item is null)
        {
            return "Item not found";
        }

        _item.Name = item.Name;
        return "Item updated";
    }

    public string Delete(Guid id)
    {
        var _item = Items.SingleOrDefault(w => w.Key == id).Value;
        if (_item is null)
        {
            return "Item not found";
        }

        Items.Remove(id);
        return "Item deleted";
    }
}