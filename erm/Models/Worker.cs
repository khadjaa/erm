using erm.Models;

namespace Erm.Models;

public class Worker : Person
{
    public string Responsibility { get; set; } = string.Empty;
    public ICollection<WorkerMyTask> WorkerTasks { get; set; } = new List<WorkerMyTask>();
}

