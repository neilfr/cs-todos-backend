using cs_todos_backend.Contexts;
using cs_todos_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

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
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        builder.DataSource = "localhost,1434";
        builder.UserID = "sa";
        builder.Password = "Super_Secret_Password_123";
        builder.InitialCatalog = "test_db";
        builder.TrustServerCertificate = true;
        
        List<MyTask> otherTasks = new List<MyTask>();

        otherTasks = _context.MyTasks.ToList(); 

        return otherTasks;
    }
}