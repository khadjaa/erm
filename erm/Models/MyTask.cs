namespace Erm.Models;

public class MyTask : BaseEntity
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string AssignedTo { get; set; }
}