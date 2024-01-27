namespace erm.Models;

public class RiskManager : BaseEntity
{
    public List<RiskCategory> RiskCategories { get; set; }
    public List<RiskAssessment> Assessments { get; set; }
        
    public Risk CreateRisk(string name, string description, Probability probability, Impact impact)
    {
        Risk newRisk = new()
        {
            Name = name,
            Description = description,
            Probability = probability,
            Impact = impact
        };
        return newRisk;
    }

    public void CreateRiskCategory(string name)
    {
        RiskCategory riskCategory = new()
        {
            Name = name
        };
        RiskCategories.Add(riskCategory);
        Console.WriteLine($"Risk category '{riskCategory.Name}' added in RiskCategories");
    }
        
    public void CreateRiskAssessment(DateTime date)
    {
        RiskAssessment assessment = new RiskAssessment
        {
            Date = date,
            AssessedRisks = new List<Risk>()
        };
        Assessments.Add(assessment);
        Console.WriteLine($"RiskAssessment added in Assessments on '{assessment.Date}'");
    }
}