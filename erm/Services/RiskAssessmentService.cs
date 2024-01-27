using erm.Models;

namespace erm.Services;

public class RiskAssessmentService : IRiskAssessmentService
{
    private static readonly Dictionary<Guid, RiskAssessment> Items = new();
    
    public IEnumerable<RiskAssessment> GetAll()
    {
        return Items.Values;
    }

    public RiskAssessment GetById(Guid id)
    {
        return Items.SingleOrDefault(r => r.Key == id).Value;
    }

    public string Create(RiskAssessment item)
    {
        if (string.IsNullOrEmpty(item.Name))
        {
            return "the name cannot be empty";
        }
        
        Items.Add(item.Id, item);
        return $"Created new item with this ID: {item.Id}";
    }

    public string Update(Guid id, RiskAssessment item)
    {
        var _item = Items.SingleOrDefault(r => r.Key == id).Value;
        if (_item is null)
        {
            return "Item not found";
        }

        _item.Name = item.Name;
        _item.Date = item.Date;
        _item.AssessedRisks = item.AssessedRisks;
        return "Item updated";
    }

    public string Delete(Guid id)
    {
        var _item = Items.SingleOrDefault(r => r.Key == id).Value;
        if (_item is null)
        {
            return "Item not found";
        }

        Items.Remove(id);
        return "Item deleted";
    }
}