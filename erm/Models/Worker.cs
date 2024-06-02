namespace Erm.Models;

public class Worker : Person
{
    public string Responsibility { get; set; } = string.Empty;

    public Guid MyTaskId { get; set; }
    public MyTask MyTasks { get; set; }
}

