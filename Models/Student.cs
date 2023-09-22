using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models;

public class Student
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public List<Class> Classes { get; set; }
    public List<Course> Courses { get; set; }

    public Student()
    {
    }

    public Student(string name, string email, string address, string phone, List<Class> classes, List<Course> courses)
    {
        Name = name;
        Email = email;
        Address = address;
        Phone = phone;
        Classes = classes;
        Courses = courses;
    }
}