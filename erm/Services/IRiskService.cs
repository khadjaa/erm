using erm.Models;

namespace erm.Services;

public interface IRiskService
{
    IEnumerable<Risk> GetAll();
    /// <summary>
    /// This is for getting item by Id
    /// </summary>
    /// <param name="id">Id of item</param>
    /// <returns>retruns item if found otherwase null</returns>
    Risk GetById(Guid id);
    string Create(Risk risk);
    string Update(Guid id, Risk item);
    string Delete(Guid id);
}