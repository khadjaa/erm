using erm.Models;
using erm.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class RiskController : ControllerBase
{
    readonly IRiskService _service;
    public RiskController(IRiskService service)
    {
        _service = service;
    }

    [HttpGet("AllItems")]
    public IEnumerable<Risk> Get()
    {
        return _service.GetAll();
    }

    [HttpGet("GetItemById")]
    public Risk Get(Guid id)
    {
        return _service.GetById(id);
    }

    [HttpPost("Create")]
    public string Post([FromBody] Risk item)
    {
        return _service.Create(item);
    }

    [HttpPut("Update")]
    public string Put([FromQuery] Guid id, [FromBody] Risk item)
    {
        return _service.Update(id, item);
    }

    [HttpDelete("Delete")]
    public string Delete([FromQuery] Guid id)
    {
        return _service.Delete(id);
    }
}