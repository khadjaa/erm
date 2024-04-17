namespace Erm.Models;

public class Project : BaseEntity
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Sprints { get; set; }
    public string Risks { get; set; }
    public string AssignedTo { get; set; }
}