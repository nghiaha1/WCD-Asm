using Application.Models;
using Application.Repository;

namespace Application.Service;

public class CourseService : ICourseService
{
    private readonly IRepository<Course> _courseRepository;

    public CourseService()
    {
    }

    public CourseService(IRepository<Course> courseRepository)
    {
        _courseRepository = courseRepository;
    }
    
    public IEnumerable<Course> GetAll()
    {
        return _courseRepository.GetAll();
    }

    public Course GetById(string id)
    {
        return _courseRepository.GetById(id);
    }

    public void Insert(Course entity)
    {
        _courseRepository.Insert(entity);
    }

    public void Update(Course entity)
    {
        _courseRepository.Update(entity);
    }

    public void Delete(string id)
    {
        _courseRepository.DeleteById(id);
    }
}