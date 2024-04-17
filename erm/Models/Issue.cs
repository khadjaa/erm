namespace Erm.Models;

public class Issue : BaseEntity
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string FindByWorker { get; set; }
}