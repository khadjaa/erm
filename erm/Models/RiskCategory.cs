namespace erm.Models;

public class RiskCategory : BaseEntity
{
    public string Name { get; set; }
        
    public void AddRisk(Risk risk)
    {
        Console.WriteLine($"Risk '{risk.Name}' added in category '{Name}'.");
    }
}