namespace Erm.Models;

public class Issue : BaseEntity
{
    public string Name { get; set; }= string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string FindByWorker { get; set; }= string.Empty;
}