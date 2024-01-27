using erm.Models;

namespace erm.Services;

public interface IRiskAssessmentService
{
    IEnumerable<RiskAssessment> GetAll();
    RiskAssessment GetById(Guid id);
    string Create(RiskAssessment riskAssessmentServiceService);
    string Update(Guid id, RiskAssessment item);
    string Delete(Guid id);
}