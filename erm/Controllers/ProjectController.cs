using Erm.Models;
using Erm.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
[Authorize]
public class ProjectController : ControllerBase
{
    readonly IProjectService _service;
    public ProjectController(IProjectService service)
    {
        _service = service;
    }

    [AllowAnonymous]
    [HttpGet("AllItems")]
    public IEnumerable<Project> Get()
    {
        return _service.GetAll();
    }

    [HttpGet("GetItemById")]
    public Project Get(Guid id)
    {
        return _service.GetById(id);
    }

    [HttpPost("Create")]
    public string Post([FromBody] Project item)
    {
        return _service.Create(item);
    }

    [HttpPut("Update")]
    public string Put([FromQuery] Guid id, [FromBody] Project item)
    {
        return _service.Update(id, item);
    }

    [HttpDelete("Delete")]
    public string Delete([FromQuery] Guid id)
    {
        return _service.Delete(id);
    }
}