using cs_todos_backend.Contexts;
using cs_todos_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace cs_todos_backend.Controllers;

[ApiController]
[Route("[controller]")]

public class StageController : ControllerBase
{
    private readonly MyDbContext _context;

    public StageController(MyDbContext context)
    {
        _context = context;
    }
    
    [HttpGet(Name = "GetStages")]
    public List<Stage> Get()
    {
        List<Stage> stages = _context.Stages.ToList();

        return stages;
    }

}