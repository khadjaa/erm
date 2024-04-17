namespace Erm.Models;

public class Sprint : BaseEntity
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Tasks { get; set; }
}