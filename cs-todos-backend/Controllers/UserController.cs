using cs_todos_backend.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace cs_todos_backend.Controllers;

public class UserController
{
    [HttpGet(Name = "GetUser")]
    public UserVm Get()
    {
        return new UserVm
        {
            Id = 1,
            Email = "test@example.com",
            Password = "password",
            UserName = "Tester"
        };
    }
}