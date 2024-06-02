namespace Erm.Models;

public class Project : BaseEntity
{
    public string Name { get; set; }= string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Sprints { get; set; }= string.Empty;
    public string Risks { get; set; }= string.Empty;
    public string AssignedTo { get; set; }= string.Empty;
}