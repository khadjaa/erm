using erm.Models;

namespace Erm.Models;

public class Issue : BaseEntity //проблемы
{
    public string Name { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string FindByWorker { get; set; } = string.Empty;

    public Guid WorkerMyTaskId { get; set; }
    public WorkerMyTask WorkerMyTask { get; set; }
}