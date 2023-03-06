namespace cs_todos_backend.Models;

public class Stage
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public List<MyTask> MyTasks { get; set; }
}