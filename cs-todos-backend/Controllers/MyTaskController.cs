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

        // non ef
       // using (SqlConnection connection = new SqlConnection(builder.ConnectionString)) 
       //  {
       //      Console.WriteLine("made it here without an error?");
       //      connection.Open();
       //      String sql = "Select * from dbo.tasks";
       //      using (SqlCommand command = new SqlCommand(sql, connection))
       //      {
       //          using (SqlDataReader reader = command.ExecuteReader())
       //          {
       //              while (reader.Read())
       //              {
       //                  Console.WriteLine("{0} {1} {2}", reader.GetInt32(0),reader.GetString(1), reader.GetInt32(2));
       //                  var task = new MyTask
       //                  {
       //                      id = reader.GetInt32(0),
       //                      description = reader.GetString(1),
       //                      priority = reader.GetInt32(2)
       //                  };
       //                  otherTasks.Add(task);
       //              }
       //          }
       //      }

       

           return otherTasks;
    }
}