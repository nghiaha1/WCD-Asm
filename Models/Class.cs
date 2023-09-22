using System.ComponentModel.DataAnnotations;

namespace Application.Models;

public class Class
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public List<Student> Students { get; set; }

    public Class()
    {
    }

    public Class(string name)
    {
        Name = name;
    }
}