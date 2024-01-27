namespace erm.Models;

public class Risk : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Probability Probability { get; set; }
    public Impact Impact { get; set; }
}

public enum Probability
{
    High,
    Medium,
    Low
}
public enum Impact
{
    High,
    Medium,
    Low
}