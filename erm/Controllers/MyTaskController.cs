using Erm.Models;
using Erm.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
[Authorize(policy: "AdminOnly")]
public class MyTaskController : ControllerBase
{
    readonly IMyTaskService _service;
    public MyTaskController(IMyTaskService service)
    {
        _service = service;
    }

    [AllowAnonymous]
    [HttpGet("AllItems")]
    public IEnumerable<MyTask> Get()
    {
        return _service.GetAll();
    }

    [HttpGet("GetItemById")]
    public MyTask Get(Guid id)
    {
        return _service.GetById(id);
    }

    [HttpPost("Create")]
    public string Post([FromBody] MyTask item)
    {
        return _service.Create(item);
    }

    [HttpPut("Update")]
    public string Put([FromQuery] Guid id, [FromBody] MyTask item)
    {
        return _service.Update(id, item);
    }

    [HttpDelete("Delete")]
    public string Delete([FromQuery] Guid id)
    {
        return _service.Delete(id);
    }
}