using cs_todos_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace cs_todos_backend.Controllers;

[ApiController]
[Route("[controller]")]

public class MyTaskController : ControllerBase
{
    [HttpGet(Name = "GetTasks")]
    public List<MyTask> Get()
    {
        List<MyTask> tasks = new List<MyTask>()
        {
            new MyTask{
                id = 1,
                Description = "first task",
                Priority = 5
            },
            new MyTask{
                id = 2,
                Description = "second task",
                Priority = 3
            }   
        };
        
        return tasks;
    }
}