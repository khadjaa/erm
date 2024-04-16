using Erm.Models;
using Erm.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
[Authorize]
public class RiskController : ControllerBase
{
    readonly IRiskService _service;
    public RiskController(IRiskService service)
    {
        _service = service;
    }

    [AllowAnonymous]
    [HttpGet("AllItems")]
    public IEnumerable<Risk> Get()
    {
        return _service.GetAll();
    }

    [HttpGet("GetItemById")]
    [Authorize(Roles = "admin")]
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

    [HttpGet("Exception")]
    public IEnumerable<Risk> Get(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}