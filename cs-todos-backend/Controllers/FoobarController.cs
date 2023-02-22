using Microsoft.AspNetCore.Mvc;

namespace cs_todos_backend.Controllers;

[ApiController]
[Route("[controller]")]

public class FoobarController : ControllerBase
{
    private static readonly string[] Stuff = new[]
    {
        "To Do", "In Progress", "Done"
    };

    [HttpGet(Name = "GetFoobar")]
    public List<string> Get()
    {
        return Stuff.ToList();
    }

}