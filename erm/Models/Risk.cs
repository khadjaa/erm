namespace erm.Models;

public class Risk : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Probability { get; set; }
    public int Impact { get; set; }
}