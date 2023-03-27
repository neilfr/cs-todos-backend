using cs_todos_backend.Contexts;
using cs_todos_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace cs_todos_backend.Controllers;

[ApiController]
[Route("[controller]")]

public class MyTaskController : ControllerBase
{
    private readonly MyDbContext _context;

    public MyTaskController(MyDbContext context)
    {
        _context = context;
    }
    
    [HttpGet(Name = "GetTasks")]
    public List<MyTask> Get()
    {
        List<MyTask> myTasks = _context.MyTasks.ToList();;

        return myTasks;
    }
}