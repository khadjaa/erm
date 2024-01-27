namespace erm.Models;

public class RiskAssessment : BaseEntity
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public List<Risk> AssessedRisks { get; set; }
        
    public void AddAssessedRisk(Risk risk)
    {
        AssessedRisks.Add(risk);
        Console.WriteLine($"Risk '{risk.Name}' added in risk assessment on {Date.ToShortDateString()}.");
    }
}