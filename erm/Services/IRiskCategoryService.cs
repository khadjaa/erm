using erm.Models;

namespace erm.Services;

public interface IRiskCategoryService
{
    IEnumerable<RiskCategory> GetAll();
    RiskCategory GetById(Guid id);
    string Create(RiskCategory riskCategory);
    string Update(Guid id, RiskCategory item);
    string Delete(Guid id);
}