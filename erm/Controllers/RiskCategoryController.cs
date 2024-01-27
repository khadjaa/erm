using erm.Models;
using erm.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class RiskCategoryController : ControllerBase
{
    readonly IRiskCategoryService _service;
    public RiskCategoryController(IRiskCategoryService service)
    {
        _service = service;
    }

    [HttpGet("AllItems")]
    public IEnumerable<RiskCategory> Get()
    {
        return _service.GetAll();
    }

    [HttpGet("GetItemById")]
    public RiskCategory Get(Guid id)
    {
        return _service.GetById(id);
    }

    [HttpPost("Create")]
    public string Post([FromBody] RiskCategory item)
    {
        return _service.Create(item);
    }

    [HttpPut("Update")]
    public string Put([FromQuery] Guid id, [FromBody] RiskCategory item)
    {
        return _service.Update(id, item);
    }

    [HttpDelete("Delete")]
    public string Delete([FromQuery] Guid id)
    {
        return _service.Delete(id);
    }
}