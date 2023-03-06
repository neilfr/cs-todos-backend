namespace cs_todos_backend.Models;

public class MyTask
{
    public int Id { get; set; }
    public int Priority { get; set; }
    public string? Description { get; set; }
    
    public int StageId { get; set; }
    public Stage Stage { get; set; }
}