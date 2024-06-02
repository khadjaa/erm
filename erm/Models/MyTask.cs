namespace Erm.Models;

public class MyTask : BaseEntity
{
    public string Name { get; set; }= string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string AssignedTo { get; set; }= string.Empty;
}