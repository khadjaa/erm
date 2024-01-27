using erm.Models;
using erm.Services;
using Microsoft.AspNetCore.Mvc;

namespace erm.Controllers;

[ApiController]
[Route("[controller]")]
public class RiskAssessmentController : ControllerBase
{
    private readonly IRiskAssessmentService _service;

    public RiskAssessmentController(IRiskAssessmentService service)
    {
        _service = service;
    }

    [HttpGet("AllItems")]
    public IEnumerable<RiskAssessment> Get()
    {
        return _service.GetAll();
    }

    [HttpGet("GetItemById")]
    public RiskAssessment GetById(Guid id)
    {
        return _service.GetById(id);
    }

    [HttpPost]
    public string Post([FromBody] RiskAssessment item)
    {
        return _service.Create(item);
    }

    [HttpPut("Update")]
    public string Put([FromQuery] Guid id, [FromBody] RiskAssessment item)
    {
        return _service.Update(id, item);
    }

    [HttpDelete("Delete")]
    public string Delete([FromQuery] Guid id)
    {
        return _service.Delete(id);
    }
}