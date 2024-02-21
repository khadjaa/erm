using erm.Models;
using erm.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class RiskController : ControllerBase
{
    readonly IRiskService _service;
    private readonly ErmDbContext _context;
    public RiskController(IRiskService service, ErmDbContext context)
    {
        _service = service;
        _context = context;
    }

    [HttpGet("AllItems")]
    public IEnumerable<Risk> Get()
    {
        // return _service.GetAll();
        return _context.Risk;
    }

    [HttpGet("GetItemById")]
    public Risk Get(Guid id)
    {
        return _service.GetById(id);
    }

    [HttpPost("Create")]
    public string Post([FromBody] Risk item)
    {
        _service.Create(item);
        _context.Add(item);
        _context.SaveChanges();
        return "created";
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