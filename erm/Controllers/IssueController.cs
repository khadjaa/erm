using Erm.Models;
using Erm.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
[Authorize]
public class IssueController : ControllerBase
{
    readonly IIssueService _service;
    public IssueController(IIssueService service)
    {
        _service = service;
    }

    [AllowAnonymous]
    [HttpGet("AllItems")]
    public IEnumerable<Issue> Get()
    {
        return _service.GetAll();
    }

    [HttpGet("GetItemById")]
    public Issue Get(Guid id)
    {
        return _service.GetById(id);
    }

    [HttpPost("Create")]
    public string Post([FromBody] Issue item)
    {
        return _service.Create(item);
    }

    [HttpPut("Update")]
    public string Put([FromQuery] Guid id, [FromBody] Issue item)
    {
        return _service.Update(id, item);
    }

    [HttpDelete("Delete")]
    public string Delete([FromQuery] Guid id)
    {
        return _service.Delete(id);
    }
}