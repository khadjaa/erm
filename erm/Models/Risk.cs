namespace Erm.Models;

public class Risk : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Probability { get; set; }
    public int Impact { get; set; }
    public int ProjectId { get; set; }
    public Project Project { get; set; } = null!;
}
