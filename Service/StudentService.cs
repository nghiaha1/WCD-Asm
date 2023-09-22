using Application.Models;
using Application.Repository;

namespace Application.Service;

public class StudentService : IStudentService
{
    private readonly IRepository<Student> _studentRepository;

    public StudentService()
    {
    }

    public StudentService(IRepository<Student> studentRepository)
    {
        _studentRepository = studentRepository;
    }
    
    public IEnumerable<Student> GetAll()
    {
        return _studentRepository.GetAll();
    }

    public Student GetById(string id)
    {
        return _studentRepository.GetById(id);
    }

    public void Insert(Student entity)
    {
        _studentRepository.Insert(entity);
        _studentRepository.Save();
    }

    public void Update(Student entity)
    {
        _studentRepository.Update(entity);
        _studentRepository.Save();
    }

    public void Delete(string id)
    {
        _studentRepository.DeleteById(id);
        _studentRepository.Save();
    }
}