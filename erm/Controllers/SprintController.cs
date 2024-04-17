using Erm.Models;
using Erm.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
[Authorize]
public class SprintController : ControllerBase
{
    readonly ISprintService _service;
    public SprintController(ISprintService service)
    {
        _service = service;
    }

    [AllowAnonymous]
    [HttpGet("AllItems")]
    public IEnumerable<Sprint> Get()
    {
        return _service.GetAll();
    }

    [HttpGet("GetItemById")]
    public Sprint Get(Guid id)
    {
        return _service.GetById(id);
    }

    [HttpPost("Create")]
    public string Post([FromBody] Sprint item)
    {
        return _service.Create(item);
    }

    [HttpPut("Update")]
    public string Put([FromQuery] Guid id, [FromBody] Sprint item)
    {
        return _service.Update(id, item);
    }

    [HttpDelete("Delete")]
    public string Delete([FromQuery] Guid id)
    {
        return _service.Delete(id);
    }
}