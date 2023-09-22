using System.ComponentModel.DataAnnotations;

namespace Application.Models;

public class Course
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Student> Students { get; set; }
}