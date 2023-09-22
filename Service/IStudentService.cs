using Application.Models;

namespace Application.Service;

public interface IStudentService
{
    IEnumerable<Student> GetAll();
    Student GetById(string id);
    void Insert(Student entity);
    void Update(Student entity);
    void Delete(string id);
}